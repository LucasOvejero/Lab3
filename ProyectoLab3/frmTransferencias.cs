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
    public partial class frmTransferencias : Form
    {
        public frmTransferencias()
        {
            InitializeComponent();
        }

        private void frmTransferencias_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTransferencia.DataSource = clsEmpleado.HistorialDeTransferencias();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void tbFiltroTransferencia_TextChanged(object sender, EventArgs e)
        {
            //TODO : filtro
            DataTable dt = (DataTable)dgvTransferencia.DataSource;
            dt.DefaultView.RowFilter = string.Format("[Nombre Destino] like '%{0}%' OR [Direccion Destino] like '%{0}%' OR [Direccion Desde] like '%{0}%' OR [Nombre Desde] like '%{0}%' OR [Nombre] like '%{0}%' OR [Apellido] like '%{0}%' OR  [Motivo] like '%{0}%'", tbFiltroTransferencia.Text);
            //dt.DefaultView.RowFilter = string.Format("[Nombre Sucursal] like '%{0}%' OR Direccion like '%{0}%' OR Telefono like '%{0}%' OR Manager like '%{0}%'", tbFiltroSucursal.Text);
            dgvTransferencia.Refresh();
        }
    }
}
