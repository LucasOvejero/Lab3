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
    public partial class frmGraficosVenta : Form
    {
        int IdSucursal;
        public frmGraficosVenta(int IdSucursal)
        {
            InitializeComponent();
            this.IdSucursal = IdSucursal;
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
            chartVntas.DataSource = null;
            int anio=(int)nudAnio.Value;
            int mes=cboMeses.SelectedIndex;
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
        
            DataTable source = clsEstadisticas.getVentas(anio, mes, IdSucursal);
            chartVntas.DataSource = source;
            chartCantidad.DataSource = source;
            chartVntas.DataBind();
            chartCantidad.DataBind();
        }
    }
}
