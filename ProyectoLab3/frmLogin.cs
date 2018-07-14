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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogear_Click(object sender, EventArgs e)
        {
            lblerr.Visible = false;
            if (clsConexion.SucursalSession == -1)
            {
                bool valid=clsEmpleado.logeo(tbUser.Text, tbPass.Text);
                if (valid)
                    this.Dispose();
                else {
                    lblerr.Visible = true;
                }
            }
            else
                this.Dispose();
            
        }
    }
}
