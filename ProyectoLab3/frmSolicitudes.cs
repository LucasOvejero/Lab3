using System;
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
            try
            {
                dgvSolicitudes.DataSource = clsSolicitud.MisSolcitudesRecibidasVigentes(IdSession);
                dgvPeticiones.DataSource = clsSolicitud.MisSolcitudesRealizadasVigentes(IdSession);

                dgvPeticiones.Columns["fechaInicio"].HeaderText = "Inicio";
                dgvPeticiones.Columns["costoTotal"].HeaderText = "Costo Total";
                dgvPeticiones.Columns["costoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPeticiones.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                dgvSolicitudes.Columns["fechaInicio"].HeaderText = "Inicio";
                dgvSolicitudes.Columns["costoTotal"].HeaderText = "Costo Total";
                dgvSolicitudes.Columns["costoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvSolicitudes.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



                dgvDetalle.Columns.Add("cantidadFormateada", "Cantidad");

                dgvDetalle.Columns["CostoxKg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetalle.Columns["CostoxKg"].HeaderText = "Costo";
                dgvDetalle.Columns["cantidadFormateada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetalle.Columns["costoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                dgvDetalle.Rows.Clear();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

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
                    clsSolicitud.aceptarSolicitud((int)dgvSolicitudes.SelectedRows[0].Cells["IdSolicitud"].Value);
                    MessageBox.Show("Productos Enviados. Debera esperar confirmacion de llegada.");
                    RefrezcarVista();
                }

                dgvDetalle.DataSource = null;

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
                int IdPeticion = (int)dgvPeticiones.SelectedRows[0].Cells["IdSolicitud"].Value;

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
            lblEnViaje.Text = clsSolicitud.CountEnCamino();
        }

        private void DgvSolicitudes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvDetalle.DataSource = null;

                int IdSolicitud = (int)dgvSolicitudes.SelectedRows[0].Cells["IdSolicitud"].Value;

                dgvDetalle.DataSource = clsSolicitud.obtenerIngredientesDeSolicitud(IdSolicitud);

                FormatearDetalle();


                pnlAceptarRechazar.Visible = true;
            }
            catch (Exception ex) { Console.Write(ex.Message); }
        }

        private void FormatearDetalle()
        {
            dgvDetalle.Columns["cantidad"].Visible = false;


            dgvDetalle.Columns["CostoxKg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["CostoxKg"].HeaderText = "Costo";
            dgvDetalle.Columns["cantidadFormateada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["costoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



            foreach (DataGridViewRow r in dgvDetalle.Rows)
            {

                


                string unidad = r.Cells["Unidad"].Value.ToString();

                double costoxKg = Convert.ToDouble(dgvDetalle.SelectedRows[0].Cells["CostoxKg"].Value.ToString());

                double cantidadSinFormato = Convert.ToDouble(r.Cells["cantidad"].Value);

                double valor = 0;
                string unidadString = cantidadSinFormato + " Unidades";


                if (unidad.Contains("g")) { valor = costoxKg * (cantidadSinFormato / 1000); unidadString = (cantidadSinFormato / 1000).ToString() + " Kg"; }
                if (unidad.Contains("ml")) { valor = costoxKg * (cantidadSinFormato / 1000); unidadString = (cantidadSinFormato / 1000).ToString() + " L"; }
                if (unidad.Contains("u")) { valor = costoxKg * cantidadSinFormato; }


                r.Cells["cantidadFormateada"].Value = unidadString; ;

                dgvDetalle.Columns["cantidad"].DisplayIndex = 1;
                dgvDetalle.Columns["NombreProducto"].DisplayIndex = 2;
                dgvDetalle.Columns["costoTotal"].DisplayIndex = 3;
                dgvDetalle.Columns["costoTotal"].HeaderText = "Costo Total";


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