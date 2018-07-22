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
    public partial class frmVentaEmpleados : Form
    {
        int idEmpleado = -1,idSucursal=-1;
        DateTime fecha= new DateTime();
        DataTable Sucursales, Empleados,Ventas;
        DataSet ds = new DataSet();
        BindingSource bsSuc=new BindingSource(), bsEmp=new BindingSource();
        public frmVentaEmpleados()
        {
            InitializeComponent();
            Empleados = clsEmpleado.seleccionarVendedores();
            Sucursales = clsSucursal.seleccionarTodasLasSucursales();
            ds.Tables.Add(Empleados);
            ds.Tables.Add(Sucursales);
            ds.Relations.Add(new DataRelation("RelSucEm",ds.Tables["Sucursales"].Columns["IdSucursal"],ds.Tables["Empleados"].Columns["IdSucursal"]));
            chartVentas.Series.RemoveAt(0);
            chartVentas.Series.Add("Ventas");
            chartVentas.Series.Add("Ganancias");
            chartVentas.Series["Ventas"].XValueMember = "Dia";
            chartVentas.Series["Ventas"].YValueMembers = "Total";
            chartVentas.Series["Ganancias"].XValueMember = "Dia";
            chartVentas.Series["Ganancias"].YValueMembers = "Ganancia";
        }
       
        private void frmVentaEmpleados_Load(object sender, EventArgs e)
        {
            asignarGrilla();
        }
        private void asignarGrilla() {
            bsSuc.DataSource = ds;
            bsSuc.DataMember = "Sucursales";
            bsEmp.DataSource = bsSuc;
            bsEmp.DataMember = "RelSucEm";
            dgvSucursal.DataSource = bsSuc;
            dgvEmpleados.DataSource = bsEmp;
            formatearGrilla();
        }
        private void formatearGrilla() {
            dgvSucursal.Columns["Manager"].Visible = false;
            dgvSucursal.Columns["Telefono"].Visible = false;
            dgvSucursal.Columns["Estado"].Visible = false;
        }

        private void grillaFormatead1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbFiltroSuc_TextChanged(object sender, EventArgs e)
        {

            bsSuc.Filter = string.Format("[Nombre Sucursal] like '%{0}%' OR Direccion like '%{0}%' OR Telefono like '%{0}%' OR Manager like '%{0}%'", tbFiltroSuc.Text);
            dgvSucursal.Refresh();
        }

        private void tbFiltroEmp_TextChanged(object sender, EventArgs e)
        {
            bsEmp.Filter = string.Format("Nombre like '%{0}%' OR Apellido like '%{0}%' OR DNI like '%{0}%'", tbFiltroEmp.Text);
            dgvEmpleados.Refresh();
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                this.idEmpleado = int.Parse(dgvEmpleados.SelectedRows[0].Cells["IdEmpleado"].Value.ToString());
                this.idSucursal = int.Parse(dgvSucursal.SelectedRows[0].Cells["IdSucursal"].Value.ToString());
            }
            else {
                this.idEmpleado = -1;
                this.idSucursal = -1;
            }
             MostrarChart();
        }

        private void mcFecha_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            fecha=e.Start;
            MostrarChart();
        }
        private void MostrarChart() {
            if (idEmpleado != -1) {
                chartVentas.DataSource = null;
                Ventas = clsEstadisticas.getVentasXEmpleado(idEmpleado, idSucursal, fecha);
                //chartVentas.Series["Ventas"].XValueMember = fecha.Day.ToString();
                //chartVentas.Series["Ganancias"].XValueMember = fecha.Day.ToString();
                chartVentas.DataSource = Ventas;
                chartVentas.DataBind();
            }
        }

        private void dgvSucursal_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSucursal.SelectedRows.Count > 0) {
                
            }
        }

    }
}
