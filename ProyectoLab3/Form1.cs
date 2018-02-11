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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        #region Formularios
        frmBebidas ofrmBebidas;
        frmSucursales ofrmSuc;
        frmEmpleados ofrmEmp;
        frmDepositos ofrmDepositos;
        frmSolicitudes ofrmSolicitudes;
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
           // clsConexion con = new clsConexion();
          //  con.insertar();
            Console.WriteLine("Hola");
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            ofrmBebidas = new frmBebidas();
            ofrmBebidas.Show();
        }

        private void btnSuc_Click(object sender, EventArgs e)
        {
            ofrmSuc = new frmSucursales();
            ofrmSuc.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ofrmEmp = new frmEmpleados();
            ofrmEmp.ShowDialog();
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            ofrmDepositos = new frmDepositos();
            ofrmDepositos.ShowDialog();
        }

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            ofrmSolicitudes = new frmSolicitudes();
            ofrmSolicitudes.ShowDialog();
        }
    }
}
