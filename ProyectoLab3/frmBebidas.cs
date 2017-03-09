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
    public partial class frmBebidas : Form
    {
        public frmBebidas()
        {
            InitializeComponent();
        }
        clsBebida bebida;
        private void frmBebidas_Load(object sender, EventArgs e)
        {
            bebida = new clsBebida();
            refrescar();
        }

        private void refrescar()
        {
            dgvBebidas.DataSource = null;
            dgvBebidas.DataSource = bebida.seleccionarBebidas();
        }
    }
}
