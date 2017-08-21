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

        private void Form1_Load(object sender, EventArgs e)
        {
           // clsConexion con = new clsConexion();
          //  con.insertar();
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            frmBebidas ofrmBebidas = new frmBebidas();


            ofrmBebidas.Show();
        }

        private void btnSuc_Click(object sender, EventArgs e)
        {
            frmSucursales ofrmSuc = new frmSucursales();
            ofrmSuc.ShowDialog();
        }

       

     
    }
}
