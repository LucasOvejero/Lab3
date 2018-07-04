using System;
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
        FrmSolicitudes ofrmSolicitudes;
        frmLogin ofrmLogin;
        frmCrearPlatoSeleccionIng ofrmPlato;
        frmMiDeposito ofrMiDepo;
        FrmEditPlato ofrmEditPlato;
        frmVenta ofrmVenta;
        frmGraficos ofrmGraficos;
        frmNuevaSolicitud ofrmNSolicitud;
        frmHistorial ofrmHistorial;
        frmTransferencias ofrmTransferencias;
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            VerificarLogeo();

            switch (clsConexion.Tipo)
            {
                case "Administrador":
                    pnlVendedor.Visible = false;
                    break;

                case "Vendedor":
                    ofrmVenta = new frmVenta(clsConexion.SucursalSession);//TODO:asignarle el deposito del usuario actual
                    ofrmVenta.ShowDialog();
                    clsConexion.SucursalSession = -1;
                    VerificarLogeo();
                    break;
                case "Manager":
                    pnlAdmin.Visible = false;
                    break;

                default: break;
            }

            updateCritico();

        }

        private void updateCritico()
        {
            dgvCritico.DataSource = clsDeposito.ObtenerCriticos();

            if (dgvCritico.Rows.Count <= 0)
            {
                pnlCritico.Visible = false;
            }
            else
            {
                pnlCritico.Visible = true;
            }
        }

        private void BtnBebidas_Click(object sender, EventArgs e)
        {
            ofrmBebidas = new frmProductos();
            ofrmBebidas.Show();
        }

        private void BtnSuc_Click(object sender, EventArgs e)
        {
            ofrmSuc = new frmSucursales();
            ofrmSuc.ShowDialog();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            ofrmEmp = new frmEmpleados();
            ofrmEmp.ShowDialog();
        }

        private void BtnIngredientes_Click(object sender, EventArgs e)
        {
            ofrmDepositos = new frmDepositos();
            ofrmDepositos.ShowDialog();
        }

        private void BtnSolicitudes_Click(object sender, EventArgs e)
        {
            ofrmSolicitudes = new FrmSolicitudes();
            ofrmSolicitudes.ShowDialog();
        }

        private void BtnPlatos_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            VerificarLogeo();
            updateCritico();
        }


        private void VerificarLogeo()
        {
            if (clsConexion.SucursalSession == -1)
            {
                ofrmLogin = new frmLogin();
                ofrmLogin.ShowDialog();
            }

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            VerificarLogeo();
            updateCritico();
        }

        private void BtnPlato_Click(object sender, EventArgs e)
        {
            ofrmPlato = new frmCrearPlatoSeleccionIng();
            ofrmPlato.ShowDialog();
        }

        private void BtnDeposito_Click(object sender, EventArgs e)
        {
            ofrMiDepo = new frmMiDeposito(clsConexion.SucursalSession);//TODO:asignarle el deposito del usuario actual
            ofrMiDepo.ShowDialog();
        }

        private void BtnEditPlato_Click(object sender, EventArgs e)
        {
            ofrmEditPlato = new FrmEditPlato();
            ofrmEditPlato.ShowDialog();
        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
            ofrmVenta = new frmVenta(clsConexion.SucursalSession);//TODO:asignarle el deposito del usuario actual
            ofrmVenta.ShowDialog();
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            ofrmGraficos = new frmGraficos(clsConexion.SucursalSession);//TODO asignarle el id de la sucursal actual
            ofrmGraficos.ShowDialog();
        }

        private void BtnNewSolicitudes_Click(object sender, EventArgs e)
        {
            ofrmNSolicitud = new frmNuevaSolicitud();
            ofrmNSolicitud.ShowDialog();
        }

        private void BtnGraficosVentaGeneral_Click(object sender, EventArgs e)
        {
            ofrmGraficos = new frmGraficos();
            ofrmGraficos.ShowDialog();
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            ofrmHistorial = new frmHistorial();
            ofrmHistorial.ShowDialog();
        }

        private void pnlVendedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            clsConexion.SucursalSession = -1;
            dgvCritico.DataSource = null;
            VerificarLogeo();
        }
    }
}
