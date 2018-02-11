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
    public partial class frmSolicitudes : Form
    {
        


        public frmSolicitudes()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            clsSolicitud.aceptarSolicitud((int)dgvSolicitudes.SelectedRows[0].Cells["IdSolicitud"].Value);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clsSolicitud.rechazarSolicitud((int)dgvSolicitudes.SelectedRows[0].Cells["IdSolicitud"].Value);
        }


    }
}
