using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Clases;
using Componentes;

namespace ProyectoLab3
{
    public partial class frmEmpleados : Form
    {

        DataSet ds;
        SqlDataAdapter adapter;

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            cbTipo.SelectedIndex = 0;
            configurar();
            dgvEmpleados.DataSource = clsEmpleado.seleccionarEmpleados();
            dgvSucursales.ClearSelection();
            formatearGrillas();
        }

        private void formatear()
        {
            // dgvSucursaleses.Columns["IdLocalidad"].Visible = false;
            dgvSucursales.Columns["IdSucursal"].Visible = false;
            dgvSucursales.Columns["IdManager"].Visible = false;
            //dgvSucursaleses.Columns["Direccion"].Width = 270;


            //  dgvEmpleados.Columns["IdSucursal"].Visible = false; //columna del Id
            tbNombre.Focus();
        }

        private void configurar()
        {

            ds = new DataSet();
            try
            {
                dgvEmpleados.DataSource = clsEmpleado.joinSucursales();
                dgvSucursales.DataSource = clsSucursal.seleccionarSucursales();
                formatear();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }



        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificacion() == string.Empty)
                {
                    int idSucursal = Convert.ToInt32(dgvSucursales.SelectedRows[0].Cells["IdSucursal"].Value);


                    /// Tipo Manager = ascender manager.
                    /// 




                    int empId = clsEmpleado.insertarEmpleado(tbNombre.Text,
                        tbApellido.Text,
                        tbDni.Text,
                        tbTelefono.Text,
                        idSucursal,
                        cbTipo.SelectedItem.ToString(),
                        true,
                        tbUser.Text,
                        tbPass.Text
                        );

                    if (cbTipo.SelectedItem.ToString() == "Manager") {
                        clsEmpleado.ascenderAManager(idSucursal, empId);
                    }

                                        
                    limpiarCampos();
                    configurar();

                }
                else
                {
                    MessageBox.Show(verificacion(), "Verifique los datos ingresados");
                }
            }
            catch (Exception ex) { Console.Write(ex.Message); }
        }


        private string verificacion()
        {
            string msj = string.Empty;
            if (tbNombre.Text.Length < 3)
                msj += "El campo nombre es muy corto \n";
            if (tbApellido.Text.Length < 3)
                msj += "El campo apellido es muy corto \n";
            if (tbTelefono.Text.Length < 10)
                msj += "El campo telefono debe tener 10 numeros  \n";
            if (tbDni.Text.Length < 8)
                msj += "El campo dni debe tener 8 numeros \n";
            return msj;
        }

        private void limpiarCampos()
        {
            tbNombre.Clear();
            tbApellido.Clear();
            tbTelefono.Clear();
            tbDni.Clear();
            cbTipo.SelectedItem = 0;
            tbNombre.Focus();
            tbUser.Clear();
            tbPass.Clear();
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void formatearGrillas()
        {
            try
            {

                dgvSucursales.Columns["Nombre Sucursal"].Width = 120;
                dgvSucursales.Columns["Direccion"].Width = 200;

                dgvEmpleados.Columns["Estado"].Visible = false;

                dgvSucursales.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvEmpleados.Columns["DNI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvEmpleados.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //dgvEmpleados.Columns["Tel. Contacto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                dgvEmpleados.Columns["Usuario"].Visible = false;
                dgvEmpleados.Columns["Clave"].Visible = false;

                dgvSucursales.Columns["Estado"].Visible = false;


            }
            catch (Exception ex) { Console.Write(ex.Message); }
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void dgvSucursales_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            cbTodasSucursales.Checked = false;
            try
            {
                int sucursal = Convert.ToInt32(dgvSucursales.SelectedRows[0].Cells["IdSucursal"].Value);
                dgvEmpleados.DataSource = clsEmpleado.empleadosDeSucrursal(sucursal);
                formatearGrillas();
            }
            catch (Exception ex) { Console.Write(ex.Message); }
        }

        private void cbTodasSucursales_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTodasSucursales.Checked)
            {
                dgvEmpleados.DataSource = clsEmpleado.seleccionarEmpleados();
                dgvSucursales.ClearSelection();
                formatearGrillas();
            }
        }

        private void tbFiltroSucursal_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvSucursales.DataSource;
            dt.DefaultView.RowFilter = string.Format("Nombre Sucursal like '%{0}%' OR Direccion like '%{0}%' OR Telefono like '%{0}%' OR Manager like '%{0}%'", tbFiltroSucursal.Text);
            dgvSucursales.Refresh();
        }

        private void tbFiltroEmpleado_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvEmpleados.DataSource;
            dt.DefaultView.RowFilter = string.Format("Nombre like '%{0}%' OR Apellido like '%{0}%' OR DNI like '%{0}%' OR Tipo like '%{0}%' OR Telefono like '%{0}%' OR Tipo like '%{0}%'", tbFiltroEmpleado.Text);
            dgvEmpleados.Refresh();
        }
    }
}
