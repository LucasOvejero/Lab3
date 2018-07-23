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
        }
        public frmGraficos()
        {
            InitializeComponent();
            lbSucursal.SelectedIndexChanged += lbSucursal_SelectedIndexChanged;
            tbDirSuc.TextChanged += tbDirSuc_TextChanged;
            sucursales=clsSucursal.getTodasSuc();
            lbSucursal.DataSource = sucursales;
            lbSucursal.DisplayMember = "Direccion";
            lbSucursal.ValueMember = "IdSucursal";
            
            lbSucursal.SelectedIndex = 0;
            
        }
        String[] meses = new String[13] {"Todos", "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
        private void frmGraficosVenta_Load(object sender, EventArgs e)
        {
            chartCantidad.Series.Add("Cantidad de ventas");
          
            chartVntas.Series.Add("Costo");
            chartVntas.Series.Add("Venta neta");
            chartVntas.Series.Add("Ganancia total");
            cboMeses.Items.AddRange(meses);
            chartVntas.Series.RemoveAt(0);
            chartCantidad.Series.RemoveAt(0);

            cPMV.Series.RemoveAt(0);
            cPMV.Series.Add("Plato mas vendido");
            cBMV.Series.RemoveAt(0);
            cBMV.Series.Add("Bebidas mas vendidas");
            try
            {
                int[] MinMax = clsEstadisticas.getMaxMinYear();
                nudAnio.Minimum = MinMax[0];
                nudAnio.Maximum = MinMax[1];
               
            }
            catch(SqlException ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            
            cboMeses.SelectedIndex = 0;
        }

        private void cboMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            chartVntas.Series["Costo"].XValueMember = "Mes";
            chartVntas.Series["Costo"].YValueMembers = "Costo";
            chartCantidad.Series["Cantidad de ventas"].XValueMember = "Mes";
            chartCantidad.Series["Cantidad de ventas"].YValueMembers = "Cantidad";
            //chartVntas.Series["Cantidad"].XValueMember = "Mes";
            //chartVntas.Series["Cantidad"].YValueMembers = "Cantidad";
            chartVntas.Series["Venta neta"].XValueMember = "Mes";
            chartVntas.Series["Venta neta"].YValueMembers = "Precio";
            chartVntas.Series["Ganancia total"].XValueMember = "Mes";
            chartVntas.Series["Ganancia total"].YValueMembers = "Ganancia";
            cBMV.Series["Bebidas mas vendidas"].XValueMember = "Nombre";
            cBMV.Series["Bebidas mas vendidas"].YValueMembers = "Cantidad";
            cPMV.Series["Plato mas vendido"].XValueMember = "Nombre";
            cPMV.Series["Plato mas vendido"].YValueMembers = "Cantidad";
            setearDatasource();
            
        }

        private void lbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.IdSucursal=int.Parse(((DataRowView)lbSucursal.SelectedItem)["IdSucursal"].ToString());
            setearDatasource();
        }

        private void tbDirSuc_TextChanged(object sender, EventArgs e)
        {
            sucursales.DefaultView.RowFilter = string.Format("Direccion like '%{0}%'", tbDirSuc.Text);
            lbSucursal.Refresh();
        }

        private void setearDatasource() {
            chartVntas.DataSource = null;
            chartCantidad.DataSource = null;
            cBMV.DataSource = null;
            int anio = (int)nudAnio.Value;
            int mes = cboMeses.SelectedIndex;
            DataTable source = clsEstadisticas.getVentas(anio, mes, IdSucursal,null);
            chartVntas.DataSource = source;
            chartCantidad.DataSource = source;
            DataTable BMV = clsEstadisticas.BebidasMasVendidasSuc(anio, mes, IdSucursal, null);
            DataTable PMV = clsEstadisticas.PlatosMasVendidosSuc(anio, mes, IdSucursal, null);
            cPMV.DataSource = PMV;
            cPMV.DataBind();
            chartVntas.DataBind();
            chartCantidad.DataBind();
            cBMV.DataSource = BMV;
            cBMV.DataBind();

        
        }

        private void cboHoy_CheckedChanged(object sender, EventArgs e)
        {
            bool hoy=cbHoy.Checked;
            cboMeses.Enabled = !hoy;
            nudAnio.Enabled = !hoy;
            if (hoy)
            {
                chartVntas.DataSource = null;
                chartCantidad.DataSource = null;
                cBMV.DataSource = null;
                int dia = int.Parse(DateTime.Now.Date.Day.ToString());
                int mes = int.Parse(DateTime.Now.Date.Month.ToString());
                int anio = int.Parse(DateTime.Now.Date.Year.ToString());
                DataTable source = clsEstadisticas.getVentas(anio, mes, IdSucursal, dia);
                DataTable BMV = clsEstadisticas.BebidasMasVendidasSuc(anio, mes, IdSucursal, dia);
                DataTable PMV = clsEstadisticas.PlatosMasVendidosSuc(anio, mes, IdSucursal, dia);
                cPMV.DataSource = PMV;
                cPMV.DataBind();
                chartVntas.DataSource = source;
                chartCantidad.DataSource = source;
                cBMV.DataSource = BMV;
                chartVntas.DataBind();
                chartCantidad.DataBind();
                cBMV.DataBind();
            }
            else {
                setearDatasource();
            }
        }

        private void btnGraficosPorEmp_Click(object sender, EventArgs e)
        {
            ofrmVentaEmpleados = new frmVentaEmpleados();
            ofrmVentaEmpleados.ShowDialog();
        }




    }
}
