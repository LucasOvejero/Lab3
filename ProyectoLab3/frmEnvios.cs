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
        public frmEnvios()
        {
            InitializeComponent();
        }

        private void frmEnvios_Load(object sender, EventArgs e)
        {
            DgvSolicitudes.DataSource = clsSolicitud.MisSolcitudesPorRecibir();
            rbAceptar.Checked = true;

        }

        private void DgvSolicitudes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvDetalle.DataSource = null;
                int IdSolicitud = (int)DgvSolicitudes.SelectedRows[0].Cells["IdSolicitud"].Value;
                dgvDetalle.DataSource = clsSolicitud.obtenerIngredientesDeSolicitud(IdSolicitud);
            }
            catch (Exception ex) { Console.Write(ex.Message); }
        }

        private void btnInconveniente_Click(object sender, EventArgs e)
        {
            if (tbInconveniente.Text.Length < 0)
            {
                MessageBox.Show("Especifique el inconveniente");
            }
            else
            {
                if (rbAceptar.Checked)
                {
                    MigrarStock();
                 
                    
                }
                else
                {
                    //clsSolicitud.marcarError();
                }
            }
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
