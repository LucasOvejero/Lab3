using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ProyectoLab3
{
    public partial class frmEnvios : Form
    {
        frmMerma ofrmMerma;

        public frmEnvios()
        {
            InitializeComponent();
        }

        private void frmEnvios_Load(object sender, EventArgs e)
        {
            formatearGrilla();
        }

        private void formatearGrilla()
        {
            try
            {
                DgvSolicitudes.DataSource = clsSolicitud.MisSolcitudesPorRecibir();
                dgvDetalle.Columns["costoTotal"].HeaderText = "Costo Total";
                dgvDetalle.Columns["fechaInicio"].HeaderText = "Inicio";

            }
            catch (Exception ex) { Console.Write(ex.Message); }
        }

        private void DgvSolicitudes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvDetalle.DataSource = null;
                int IdSolicitud = (int)DgvSolicitudes.SelectedRows[0].Cells["IdSolicitud"].Value;
                dgvDetalle.DataSource = clsSolicitud.obtenerIngredientesDeSolicitud(IdSolicitud);

                dgvDetalle.Columns["stockCritico"].Visible = false;
                dgvDetalle.Columns["estado"].Visible = false;
                dgvDetalle.Columns["fechaFin"].Visible = false;
                dgvDetalle.Columns["recibido"].Visible = false;
                dgvDetalle.Columns["Observacion"].Visible = false;
                dgvDetalle.Columns["fechaEnvio"].Visible = false;
                dgvDetalle.Columns["fechaInicio"].Visible = false;
                dgvDetalle.Columns["stockCritico"].Visible = false;

                dgvDetalle.Columns["NombreProducto"].HeaderText = "Producto";
                dgvDetalle.Columns["CostoxKg"].HeaderText = "Costo Producto";
                dgvDetalle.Columns["cantidad"].HeaderText = "Cantidad";
                dgvDetalle.Columns["costoTotal"].HeaderText = "Costo Total";


            }
            catch (Exception ex) { Console.Write(ex.Message); }
        }

        private void btnInconveniente_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbInconveniente.Text.Length < 0)
                {
                    MessageBox.Show("Especifique el inconveniente");
                }
                else
                {
                    MigrarStock();

                    int IdSolicitud = (int)DgvSolicitudes.SelectedRows[0].Cells["IdSolicitud"].Value;

                    clsSolicitud.marcarInconveniente(IdSolicitud);
                    MessageBox.Show("Se ha cargado la solicitud, por favor, especifique la merma si la hubiese.");
                    ofrmMerma = new frmMerma();
                    ofrmMerma.ShowDialog();
                }
            }
            catch (Exception ex) { Console.Write(ex.Message); }
        }

        private void btnRecibir_Click(object sender, EventArgs e)
        {
            int IdSolicitud = (int)DgvSolicitudes.SelectedRows[0].Cells["IdSolicitud"].Value;
            MigrarStock();
            clsSolicitud.marcarRecibida(IdSolicitud);
        }


        private void MigrarStock()
        {
            foreach (DataGridViewRow r in dgvDetalle.Rows)
            {
                int IdIngrediente = (int)r.Cells["IdIngrediente"].Value;
                string nombre = r.Cells["NombreProducto"].Value.ToString();
                int cantidad = (int)r.Cells["cantidad"].Value;
                int sucursalDestino = (int)r.Cells["IdSolicitado"].Value;

                clsDeposito.recibirEnvio(sucursalDestino, IdIngrediente, cantidad);
            }
        }

    }
}
