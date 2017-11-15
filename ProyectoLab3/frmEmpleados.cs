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

namespace ProyectoLab3
{
    public partial class frmEmpleados : Form
    {

        BindingSource bsEmp;
        BindingSource bsSuc;

        DataSet ds;
        SqlDataAdapter adapter;

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {

            configurar();
        }

        private void formatear(){
           // dgvSucursales.Columns["IdLocalidad"].Visible = false;
            dgvSucursales.Columns["IdSucursal"].Visible = false;
            dgvSucursales.Columns["Telefono"].Visible = false;
            dgvSucursales.Columns["IdManager"].Visible = false;
            //dgvSucursales.Columns["Direccion"].Width = 270;


          //  dgvEmpleados.Columns["IdSucursal"].Visible = false; //columna del Id
            tbNombre.Focus();
        }

        private void configurar()
        {
            bsEmp = new BindingSource();
            bsSuc = new BindingSource();
            ds = new DataSet();
            try
            {
                ds.Tables.Add(clsEmpleado.joinSucursales());
                ds.Tables.Add(clsSucursal.seleccionarSucursales());

                bsEmp.DataSource = ds;
                bsEmp.DataMember = "JoinSucursal";

                bsSuc.DataSource = ds;
                bsSuc.DataMember = "Sucursales";

                dgvEmpleados.DataSource = bsEmp;
                dgvSucursales.DataSource = bsSuc;
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
            if (verificacion() == string.Empty)
            {
                int idSucursal = Convert.ToInt32(dgvSucursales.SelectedRows[0].Cells["IdSucursal"].Value);


                //Hacer que el CB TIPO este relacionado con el ID de los TIPO de trabajo (Es INT? Otra tabla?)
                //Realizar Join con tabla TIPO, para mostrar fila del puesto.
                //CAMBIAR type de campo tipo?
                string resp = clsEmpleado.insertarEmpleado(tbNombre.Text,
                    tbApellido.Text,
                    tbDni.Text,
                    tbTelefono.Text,
                    idSucursal,
                    cbTipo.SelectedItem.ToString(),
                    true);
                


                MessageBox.Show(resp);
                limpiarCampos();
                configurar();
                
                }
            else 
            {
                MessageBox.Show(verificacion(), "Verifique los datos ingresados");
            }
        }


        private string verificacion() { 
            string msj = string.Empty;
            if (tbNombre.Text.Length < 3)
                msj += "El campo nombre es muy corto \n";
            if (tbApellido.Text.Length < 3)
                msj += "El campo apellido es muy corto \n";
            if (tbTelefono.Text.Length < 3)
                msj += "El campo telefono es muy corto \n";
            if (tbDni.Text.Length < 3)
                msj += "El campo dni es muy corto \n";
            return msj;
        }

        private void limpiarCampos() {
            tbNombre.Clear();
            tbApellido.Clear();
            tbTelefono.Clear();
            tbDni.Clear();
            cbTipo.SelectedItem = 0;
            tbNombre.Focus();
        }

    }
}
