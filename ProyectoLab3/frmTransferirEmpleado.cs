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
    public partial class frmTransferirEmpleado : Form
    {
        frmEmpleados padre;

        public frmTransferirEmpleado(frmEmpleados padre)
        {
            this.padre = padre;
            InitializeComponent();

        }

        private void frmTransferirEmpleado_Load(object sender, EventArgs e)
        {
            dgvSucursales.DataSource = clsSucursal.seleccionarSucursales();
            formatear();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            try
            {
                padre.idSucursalTransferencia = (int)dgvSucursales.SelectedRows[0].Cells["IdSucursal"].Value;
                this.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }


        private void formatear()
        {
            // dgvSucursaleses.Columns["IdLocalidad"].Visible = false;
            dgvSucursales.Columns["IdSucursal"].Visible = false;
            dgvSucursales.Columns["IdManager"].Visible = false;
            dgvSucursales.Columns["Estado"].Visible = false;
            //dgvSucursaleses.Columns["Direccion"].Width = 270;
            //  dgvEmpleados.Columns["IdSucursal"].Visible = false; //columna del Id
            tbFiltroSucursal.Focus();
        }

        private void tbFiltroSucursal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dgvSucursales.DataSource;
                dt.DefaultView.RowFilter = string.Format("[Nombre Sucursal] like '%{0}%' OR Direccion like '%{0}%' OR Telefono like '%{0}%' OR Manager like '%{0}%'", tbFiltroSucursal.Text);
                dgvSucursales.Refresh();
            }

            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
