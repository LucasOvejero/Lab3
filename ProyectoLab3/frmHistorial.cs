using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;

namespace ProyectoLab3
{
    public partial class frmHistorial : Form
    {
        public frmHistorial()
        {
            InitializeComponent();
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            dgvHistorial.DataSource = clsSolicitud.GetHistorial(); formatoGrillaHistorial();
            rbAmbas.Checked = true;
            formatoGrillaHistorial();
        }

        private void grillaFormatead1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbFiltro_TextChanged(object sender, EventArgs e)
        {
            /*DataTable dt = (DataTable)dgvHistorial.DataSource;
            dt.DefaultView.RowFilter.ToString = 
            dgvHistorial.Refresh();*/
        }

        private void rbAmbas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAmbas.Checked)
            {
                dgvHistorial.DataSource = clsSolicitud.GetHistorial();
                formatoGrillaHistorial();
            }
        }

        private void rbEnviadas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEnviadas.Checked)
            {
                dgvHistorial.DataSource = clsSolicitud.Enviadas();
                formatoGrillaHistorial();
            }
        }

        private void rbRecibidas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRecibidas.Checked)
            {
                dgvHistorial.DataSource = clsSolicitud.Recibidas();
                formatoGrillaHistorial();
            }
        }

        private void rbAceptadas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAceptadas.Checked)
            {
                DataTable dt = (DataTable)dgvHistorial.DataSource;
                dt.DefaultView.RowFilter = "Estado = 1";
                dgvHistorial.Refresh();
                formatoGrillaHistorial();
            }
        }

        private void rbRechazadas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRechazadas.Checked)
            {
                DataTable dt = (DataTable)dgvHistorial.DataSource;
                dt.DefaultView.RowFilter = "Estado = 0";
                dgvHistorial.Refresh();
                formatoGrillaHistorial();
            }
        }

        private void rbTodoEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodoEstado.Checked)
            {
                DataTable dt = (DataTable)dgvHistorial.DataSource;
                dt.DefaultView.RowFilter = "";
                dgvHistorial.Refresh();
                formatoGrillaHistorial();
            }
        }

        private void formatoGrillaHistorial()
        {
            dgvHistorial.Columns["estado"].Visible = false;

            foreach (DataGridViewRow r in dgvHistorial.Rows)
            {
                if (r.Cells["estado"].Value.ToString() == "1")
                {
                    r.DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    r.DefaultCellStyle.BackColor = Color.Red;
                }
            }

            dgvHistorial.Columns["fechaInicio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvHistorial.Columns["fechaFin"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvHistorial.Columns["costoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


        }

        private void dgvHistorial_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvDetalle.DataSource = null;

                int IdSolicitud = (int)dgvHistorial.SelectedRows[0].Cells[0].Value;

                dgvDetalle.DataSource = clsSolicitud.obtenerIngredientesDeSolicitud(IdSolicitud);

                dgvDetalle.Columns["CostoxKg"].Visible = false;
                dgvDetalle.Columns["stockCritico"].Visible = false;
                dgvDetalle.Columns["estado"].Visible = false;
                dgvDetalle.Columns["fechaInicio"].Visible = false;
                dgvDetalle.Columns["fechaFin"].Visible = false;

                dgvDetalle.Columns["cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetalle.Columns["costoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                //formatearDetalle();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void dgvHistorial_Sorted(object sender, EventArgs e)
        {
            formatoGrillaHistorial();
        }
    }
}
