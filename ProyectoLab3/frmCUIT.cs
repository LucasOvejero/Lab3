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
    public partial class frmCUIT : Form
    {
        public frmCUIT()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
        }
        bool borrando;
        private void tbCUIT_TextChanged(object sender, EventArgs e)
        {
            if (!borrando&&(tbCUIT.TextLength == 2 || tbCUIT.TextLength == 11))
                tbCUIT.AppendText("-");
            else if (borrando && (tbCUIT.TextLength == 2 || tbCUIT.TextLength == 11))
            {
                tbCUIT.Text = tbCUIT.Text.Remove(tbCUIT.TextLength - 1);
                tbCUIT.Focus();
                tbCUIT.Select(tbCUIT.Text.Length, 0);

            }
            if (tbCUIT.TextLength == 13)
                btnGuardar.Enabled = true;
            else
                btnGuardar.Enabled = false;
        }

        private void tbCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            borrando=char.IsControl(e.KeyChar) ? true : false;
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;

        }

        private void frmCUIT_Load(object sender, EventArgs e)
        {
            if (clsConexion.CUIT != string.Empty)
                tbCUIT.Text = clsConexion.CUIT;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string resp=clsVenta.updateCUIT(tbCUIT.Text);
            if (resp != string.Empty) {
                MessageBox.Show(resp, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else{
                MessageBox.Show("Se ha guardado el CUIT correctamente", "Guardado Correctamente", MessageBoxButtons.OK);
                this.Close();
            }

        }
    }
}
