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
    public partial class frmGraficos : Form
    {
        int IdSucursal;
        DataTable sucursales;

        frmVentaEmpleados ofrmVentaEmpleados;



        public frmGraficos(int IdSucursal)
        {
            InitializeComponent();
            this.IdSucursal = IdSucursal;
            pnlAdmin.Visible = false;
            btnInforme.Visible = false;
        }
        public frmGraficos()
        {
            InitializeComponent();
            lbSucursal.SelectedIndexChanged += lbSucursal_SelectedIndexChanged;
            tbDirSuc.TextChanged += tbDirSuc_TextChanged;
            sucursales=clsSucursal.getTodasSuc2();
            lbSucursal.DataSource = sucursales;
            lbSucursal.DisplayMember = "NombreInterno";
            lbSucursal.ValueMember = "IdSucursal";
            
            lbSucursal.SelectedIndex = 0;
            
        }
        private void frmGraficosVenta_Load(object sender, EventArgs e)
        {
            chartCantidad.Series.Add("Cantidad de ventas");
          
            chartVntas.Series.Add("Costo");
            chartVntas.Series.Add("Recaudado");
            chartVntas.Series.Add("Ganancia total");
          
            chartVntas.Series.RemoveAt(0);
            chartCantidad.Series.RemoveAt(0);

            cPMV.Series.RemoveAt(0);
            cPMV.Series.Add("Plato mas vendido");
            cBMV.Series.RemoveAt(0);
            cBMV.Series.Add("Bebidas mas vendidas");
            chartVntas.Series["Costo"].XValueMember = "Nombre";
            chartVntas.Series["Costo"].YValueMembers = "Costo";
            chartVntas.Series["Recaudado"].XValueMember = "Nombre";
            chartVntas.Series["Recaudado"].YValueMembers = "Precio";
            chartVntas.Series["Ganancia total"].XValueMember = "Nombre";
            chartVntas.Series["Ganancia total"].YValueMembers = "Ganancia";
            chartCantidad.Series["Cantidad de ventas"].XValueMember = "Nombre";
            chartCantidad.Series["Cantidad de ventas"].YValueMembers = "Cantidad";
            //chartVntas.Series["Cantidad"].XValueMember = "Mes";
            //chartVntas.Series["Cantidad"].YValueMembers = "Cantidad";

            cBMV.Series["Bebidas mas vendidas"].XValueMember = "Nombre";
            cBMV.Series["Bebidas mas vendidas"].YValueMembers = "Cantidad";
            cPMV.Series["Plato mas vendido"].XValueMember = "Nombre";
            cPMV.Series["Plato mas vendido"].YValueMembers = "Cantidad";
            calcular();
        }

        private void lbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.IdSucursal=int.Parse(((DataRowView)lbSucursal.SelectedItem)["IdSucursal"].ToString());
            
        }

        private void tbDirSuc_TextChanged(object sender, EventArgs e)
        {
            sucursales.DefaultView.RowFilter = string.Format("NombreInterno like '%{0}%'", tbDirSuc.Text);
          
        }
        private void btnGraficosPorEmp_Click(object sender, EventArgs e)
        {
            ofrmVentaEmpleados = new frmVentaEmpleados();
            ofrmVentaEmpleados.ShowDialog();
        }


        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            dtpHasta.MinDate = dtpDesde.Value;
            calcular();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void calcular() {
            DataTable ventas = clsEstadisticas.getVentas(dtpDesde.Value, dtpHasta.Value, this.IdSucursal);
            chartVntas.DataSource = ventas;
            chartVntas.DataBind();

            chartCantidad.DataSource = ventas;
            chartCantidad.DataBind();

            DataTable BMV = clsEstadisticas.BebidasMasVendidasSuc(dtpDesde.Value, dtpHasta.Value, this.IdSucursal);
            DataTable PMV = clsEstadisticas.PlatosMasVendidosSuc(dtpDesde.Value, dtpHasta.Value, this.IdSucursal);
            cPMV.DataSource = PMV;
            cPMV.DataBind();

            cBMV.DataSource = BMV;
            cBMV.DataBind();
        }

        private void lbSucursal_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.IdSucursal = int.Parse(((DataRowView)lbSucursal.SelectedItem)["IdSucursal"].ToString());
            calcular();
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            reporteGlobal rptGlobalCR = new reporteGlobal();
            rptGlobalCR.SetDataSource(clsEstadisticas.getVentasPInforme(dtpDesde.Value,dtpHasta.Value));
            rptGlobalCR.SetParameterValue("Desde",dtpDesde.Value);
            rptGlobalCR.SetParameterValue("Hasta", dtpHasta.Value);
            frmTicketVenta frmTicket = new frmTicketVenta(rptGlobalCR);
            frmTicket.ShowDialog();
        }


    }
}
