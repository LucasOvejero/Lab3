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

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            dgvHistorial.DataSource = clsSolicitud.GetHistorial();
            FormatoGrillaHistorial();
            rbAmbas.Checked = true;
            FormatoGrillaHistorial();
        }

        private void GrillaFormatead1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void RbAmbas_CheckedChanged(object sender, EventArgs e)
        {

            if (rbAmbas.Checked)
            {
                dgvHistorial.DataSource = clsSolicitud.GetHistorial();
                FormatoGrillaHistorial();
            }
        }

        private void RbEnviadas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEnviadas.Checked)
            {
                try
                {
                    dgvHistorial.DataSource = clsSolicitud.Enviadas();
                    dgvHistorial.Columns["Estado1"].Visible = false;

                    dgvHistorial.Columns["NombreInterno"].DisplayIndex = 0;
                    dgvHistorial.Columns["NombreInterno"].HeaderText = "Sucursal";
                    dgvHistorial.Columns["Telefono"].DisplayIndex = 1;
                    dgvHistorial.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvHistorial.Columns["Direccion"].DisplayIndex = 2;



                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                FormatoGrillaHistorial();
            }
        }

        private void RbRecibidas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRecibidas.Checked)
            {

                try
                {
                    dgvHistorial.DataSource = clsSolicitud.Enviadas();
                    dgvHistorial.Columns["Estado1"].Visible = false;

                    dgvHistorial.Columns["NombreInterno"].DisplayIndex = 0;
                    dgvHistorial.Columns["NombreInterno"].HeaderText = "Sucursal";
                    dgvHistorial.Columns["Telefono"].DisplayIndex = 1;
                    dgvHistorial.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvHistorial.Columns["Direccion"].DisplayIndex = 2;

                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                dgvHistorial.DataSource = clsSolicitud.Recibidas();
                FormatoGrillaHistorial();
            }
        }

        private void RbAceptadas_CheckedChanged(object sender, EventArgs e)
        {

            if (rbAceptadas.Checked)
            {
                DataTable dt = (DataTable)dgvHistorial.DataSource;
                dt.DefaultView.RowFilter = "Estado = 1";
                dgvHistorial.Refresh();
                FormatoGrillaHistorial();
            }

        }

        private void RbRechazadas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRechazadas.Checked)
            {
                DataTable dt = (DataTable)dgvHistorial.DataSource;
                dt.DefaultView.RowFilter = "Estado = 0";
                dgvHistorial.Refresh();
                FormatoGrillaHistorial();
            }
        }

        private void RbTodoEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodoEstado.Checked)
            {
                DataTable dt = (DataTable)dgvHistorial.DataSource;
                dt.DefaultView.RowFilter = "";
                dgvHistorial.Refresh();
                FormatoGrillaHistorial();
            }
        }

        private void FormatoGrillaHistorial()
        {
            //colores de fondo

            try
            {
                if (!rbAmbas.Checked)
                {
                    dgvHistorial.Columns["estado"].Visible = false;
                    dgvHistorial.Columns["recibido"].Visible = false;


                    colorearGrillas();


                    dgvHistorial.Columns["fechaInicio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvHistorial.Columns["fechaFin"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvHistorial.Columns["fechaEnvio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvHistorial.Columns["costoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dgvHistorial.Columns["fechaInicio"].DisplayIndex = 3;
                    dgvHistorial.Columns["fechaInicio"].HeaderText = "Inicio";

                    dgvHistorial.Columns["fechaEnvio"].DisplayIndex = 4;
                    dgvHistorial.Columns["fechaEnvio"].HeaderText = "Enviado";

                    dgvHistorial.Columns["costoTotal"].DisplayIndex = 5;
                    dgvHistorial.Columns["costoTotal"].HeaderText = "Monto";

                    dgvHistorial.Columns["fechaFin"].DisplayIndex = 6;
                    dgvHistorial.Columns["fechaFin"].HeaderText = "Recibido";

                    dgvHistorial.Columns["observacion"].DisplayIndex = 7;
                    dgvHistorial.Columns["observacion"].HeaderText = "Observaciones";
                }
                else
                {
                    dgvHistorial.Columns["estado"].Visible = false;
                    dgvHistorial.Columns["recibido"].Visible = false;
                    dgvHistorial.Columns["Fin"].HeaderText = "Recibido";


                    colorearGrillas();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }

        private void colorearGrillas()
        {
            try
            {
                foreach (DataGridViewRow r in dgvHistorial.Rows)
                {


                    string recibido = r.Cells["recibido"].Value.ToString();


                    if (r.Cells["Fin"].Value.ToString().Length > 0 && recibido == "True")
                    {
                        //Si todo correcto = VERDE
                        r.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else
                    {
                        if (r.Cells["Fin"].Value.ToString().Length > 0 && r.Cells["Envio"].Value.ToString().Length == 0)
                        {
                            // Si termino y no fue enviada (rechazada) : rojo
                            r.DefaultCellStyle.BackColor = Color.Red;
                        }
                        //Si esta en camino
                        else if (r.Cells["Fin"].Value.ToString().Length == 0 && r.Cells["Envio"].Value.ToString().Length > 0)
                            r.DefaultCellStyle.BackColor = Color.Yellow;
                        //Si llego con dificultad
                        else if (r.Cells["Observaciones"].Value.ToString().Length > 0)
                            r.DefaultCellStyle.BackColor = Color.Orange;
                    }

                }
            }

            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }

        private void DgvHistorial_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvDetalle.DataSource = null;

                int IdSolicitud = (int)dgvHistorial.SelectedRows[0].Cells["IdSolicitud"].Value;

                dgvDetalle.DataSource = clsSolicitud.obtenerIngredientesDeSolicitud(IdSolicitud);

                dgvDetalle.Columns["CostoxKg"].Visible = false;
                dgvDetalle.Columns["stockCritico"].Visible = false;
                dgvDetalle.Columns["estado"].Visible = false;
                dgvDetalle.Columns["fechaInicio"].Visible = false;
                dgvDetalle.Columns["fechaFin"].Visible = false;

                dgvDetalle.Columns["Nombre"].HeaderText = "Producto";
                dgvDetalle.Columns["cantidad"].HeaderText = "Cantidad";
                dgvDetalle.Columns["costoTotal"].HeaderText = "Costo";



                dgvDetalle.Columns["cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetalle.Columns["costoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                //formatearDetalle();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void DgvHistorial_Sorted(object sender, EventArgs e)
        {
            FormatoGrillaHistorial();
        }


        private void tbFiltro_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dgvHistorial.DataSource;

                if (rbAmbas.Checked)
                {
                    dt.DefaultView.RowFilter = string.Format("Solicitante like '%{0}%' OR Solicitado like '%{0}%' OR Observaciones like '%{0}%'", tbFiltro.Text);
                }
                else if (rbEnviadas.Checked)
                {
                    dt.DefaultView.RowFilter = string.Format("NombreInterno like '%{0}%' OR Direccion like '%{0}%' OR Telefono like '%{0}%' OR observacion like '%{0}%'", tbFiltro.Text);
                }
                else
                {
                    dt.DefaultView.RowFilter = string.Format("NombreInterno like '%{0}%' OR Direccion like '%{0}%' OR Telefono like '%{0}%' OR observacion like '%{0}%'", tbFiltro.Text);
                }

                dgvHistorial.Refresh();
                FormatoGrillaHistorial();
            }
            catch (Exception ex) { Console.Write(ex.Message); }





        }
    }
}
