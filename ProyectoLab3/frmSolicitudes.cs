﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;
using System.Data.SqlClient;
namespace ProyectoLab3
{
    public partial class FrmSolicitudes : Form
    {
        frmEnvios ofrmEnvios;

        int IdSession = clsConexion.SucursalSession;

        public FrmSolicitudes()
        {
            InitializeComponent();

            int IdSession = clsConexion.SucursalSession;

            if (IdSession <= 0) { IdSession = 1; }


            RefrezcarVista();

        }

        private void RefrezcarVista()
        {
            dgvSolicitudes.DataSource = clsSolicitud.MisSolcitudesRecibidasVigentes(IdSession);
            dgvPeticiones.DataSource = clsSolicitud.MisSolcitudesRealizadasVigentes(IdSession);
            dgvDetalle.Columns.Add("cantidadFormateada", "Cantidad");
            dgvDetalle.Rows.Clear();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string res = VerificarStocks();

                if (res.Length > 0)
                {
                    MessageBox.Show(res);
                }
                else
                {
                    MigrarStock();
                    clsSolicitud.aceptarSolicitud((int)dgvSolicitudes.SelectedRows[0].Cells[0].Value);
                    MessageBox.Show("Productos Enviados. Debera esperar confirmacion de llegada.");
                    RefrezcarVista();
                }

                //
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private string VerificarStocks()
        {
            string respuesta = "";
            foreach (DataGridViewRow r in dgvDetalle.Rows)
            {
                int IdIngrediente = (int)r.Cells["IdIngrediente"].Value;
                string nombre = r.Cells["NombreProducto"].Value.ToString();
                int cantidad = (int)r.Cells["cantidad"].Value;
                bool haySuficiente = clsDeposito.ObtenerStockIngrediente(IdIngrediente, cantidad);

                if (!haySuficiente)
                {
                    respuesta = "No posee la cantidad de " + cantidad + " del ingrediente:" + nombre + '\n';
                }
            }
            return respuesta;
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult dialogResult = MessageBox.Show("¿Quiere Rechazar la solicitud?", "Confirmar Accion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    clsSolicitud.rechazarSolicitud((int)dgvSolicitudes.SelectedRows[0].Cells["IdSolicitud"].Value);
                    RefrezcarVista();
                }
            }
            catch (Exception ex) { Console.Write(ex.Message); }
        }

        private void DgvPeticiones_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int IdPeticion = (int)dgvPeticiones.SelectedRows[0].Cells[0].Value;

                dgvDetalle.DataSource = clsSolicitud.obtenerIngredientesDeSolicitud(IdPeticion);
                FormatearDetalle();
                pnlAceptarRechazar.Visible = false;
            }
            catch (Exception ex) { Console.Write(ex); }

        }

        private void DgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmSolicitudes_Load(object sender, EventArgs e)
        {

        }

        private void DgvSolicitudes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvDetalle.DataSource = null;

                int IdSolicitud = (int)dgvSolicitudes.SelectedRows[0].Cells[0].Value;

                dgvDetalle.DataSource = clsSolicitud.obtenerIngredientesDeSolicitud(IdSolicitud);

                FormatearDetalle();


                pnlAceptarRechazar.Visible = true;
            }
            catch (Exception ex) { Console.Write(ex.Message); }
        }

        private void FormatearDetalle()
        {
            dgvDetalle.Columns["cantidad"].Visible = false;


            foreach (DataGridViewRow r in dgvDetalle.Rows)
            {
                double cantidadSinFormato = Convert.ToDouble(r.Cells["cantidad"].Value);
                int unidades = 0;

                if (cantidadSinFormato > 500) { cantidadSinFormato /= 1000; }
                else unidades = (int)cantidadSinFormato;



                if (unidades > 0) r.Cells["cantidadFormateada"].Value = unidades + " Unidades";
                else r.Cells["cantidadFormateada"].Value = cantidadSinFormato + " Kg";

            }

        }

        private void MigrarStock()
        {
            foreach (DataGridViewRow r in dgvDetalle.Rows)
            {
                int IdIngrediente = (int)r.Cells["IdIngrediente"].Value;
                string nombre = r.Cells["NombreProducto"].Value.ToString();
                int cantidad = (int)r.Cells["cantidad"].Value;
                int sucursalDestino = (int)r.Cells["IdSolicitado"].Value;

                clsDeposito.hacerEnvio(sucursalDestino, IdIngrediente, cantidad);
            }
        }

        private void dgvPeticiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            ofrmEnvios = new frmEnvios();
            ofrmEnvios.ShowDialog();
        }
    }
}