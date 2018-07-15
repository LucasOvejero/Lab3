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
                DgvSolicitudes.Columns["costoTotal"].HeaderText = "Costo Total";
                DgvSolicitudes.Columns["fechaInicio"].HeaderText = "Inicio";


                DgvSolicitudes.Columns["costoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                DgvSolicitudes.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                


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


                dgvDetalle.Columns["cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetalle.Columns["costoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetalle.Columns["CostoxKg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                
                    

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

                    clsSolicitud.marcarInconveniente(IdSolicitud,tbInconveniente.Text);
                    MessageBox.Show("Se ha cargado la solicitud, por favor, especifique la merma si la hubiese.");
                    ofrmMerma = new frmMerma(IdSolicitud);
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
            formatearGrilla();
            dgvDetalle.DataSource = null;
        }


        private void MigrarStock()
        {
            foreach (DataGridViewRow r in dgvDetalle.Rows)
            {
                int IdIngrediente = (int)r.Cells["IdIngrediente"].Value;
                string nombre = r.Cells["NombreProducto"].Value.ToString();
                int cantidad = (int)r.Cells["cantidad"].Value;

                clsDeposito.recibirEnvio(IdIngrediente, cantidad);
            }
        }

        private void tbInconveniente_TextChanged(object sender, EventArgs e)
        {
            btnInconveniente.Enabled = tbInconveniente.Text.Length > 0;
        }

        private void DgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
