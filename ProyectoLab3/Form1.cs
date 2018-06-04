﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;
using Modelo;
namespace ProyectoLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
       

        #region Formularios
        frmProductos ofrmBebidas;
        frmSucursales ofrmSuc;
        frmEmpleados ofrmEmp;
        frmDepositos ofrmDepositos;
        frmSolicitudes ofrmSolicitudes;
        frmLogin ofrmLogin;
        frmCrearPlatoSeleccionIng ofrmPlato;
        frmMiDeposito ofrMiDepo;
        frmEditPlato ofrmEditPlato;
        frmVenta ofrmVenta;
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {            
          //  verificarLogeo();
          
          
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            ofrmBebidas = new frmProductos();
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

        private void btnPlatos_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            verificarLogeo();
        }


        private void verificarLogeo() {
/*
            if (clsConexion.SucursalSession == -1)
            {
                ofrmLogin = new frmLogin();
                ofrmLogin.ShowDialog();
            }*/

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            verificarLogeo();
        }

        private void btnPlato_Click(object sender, EventArgs e)
        {
            ofrmPlato = new frmCrearPlatoSeleccionIng();
            ofrmPlato.ShowDialog();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            ofrMiDepo = new frmMiDeposito(2);//TODO:asignarle el deposito del usuario actual
            ofrMiDepo.ShowDialog();
        }

        private void btnEditPlato_Click(object sender, EventArgs e)
        {
            ofrmEditPlato = new frmEditPlato();
            ofrmEditPlato.ShowDialog();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            ofrmVenta = new frmVenta(2);//TODO:asignarle el deposito del usuario actual
            ofrmVenta.ShowDialog();
        }

    }
}
