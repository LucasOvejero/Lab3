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
    public partial class frmSucursales : Form
    {


        #region variables
        BindingSource bsLoc = new BindingSource(), bsProv = new BindingSource(), bsSuc = new BindingSource();
        BindingSource bsEmps = new BindingSource();
        DataSet ds;
        SqlDataAdapter adapter;
        DataRelation relacion;
        #endregion
        public frmSucursales()
        {
            InitializeComponent();
        }

        private void frmSucursales_Load(object sender, EventArgs e)
        {

            configurar();
        }



        private void configurar()
        {

            ds = new DataSet();
            ds.Tables.Add(clsLocalidad.seleccionarLocalidad());
            ds.Tables.Add(clsProvincia.seleccionarProvincias());
            ds.Tables.Add(clsSucursal.seleccionarSucursales());
            ds.Tables.Add(clsEmpleado.selectActivos());
            relacion = new DataRelation("RelProvLoc", ds.Tables["Provincias"].Columns["IdProvincia"], ds.Tables["Localidades"].Columns["IdProvincia"]);
            ds.Relations.Add(relacion);
            ds.Relations.Add(new DataRelation("RelLocSuc", ds.Tables["Localidades"].Columns["IdLocalidad"], ds.Tables["Sucursales"].Columns["IdLocalidad"]));
            AsignarGrillas();
        }
        private void AsignarGrillas()
        {
            bsProv.DataSource = ds;
            bsProv.DataMember = "Provincias";
            bsLoc.DataSource = bsProv;
            bsLoc.DataMember = "RelProvLoc";
            dgvLocalidad.DataSource = bsLoc;
            dgvProvincia.DataSource = bsProv;
            bsSuc.DataSource = bsLoc;
            bsSuc.DataMember = "RelLocSuc";
            dgvSucursal.DataSource = bsSuc;

            bsEmps.DataSource = ds;
            bsEmps.DataMember = "Activos";

            dgvManagers.DataSource = bsEmps;

            formatearGrillas();
        }
        private void formatearGrillas()
        {
            dgvLocalidad.Columns["IdLocalidad"].Visible = false;
            dgvLocalidad.Columns["IdProvincia"].Visible = false;
            dgvProvincia.Columns["IdProvincia"].Visible = false;
            dgvSucursal.Columns["IdLocalidad"].Visible = false;
            dgvSucursal.Columns["IdSucursal"].Visible = false;
            dgvSucursal.Columns["Direccion"].Width = 270;
            dgvProvincia.Columns["NombreProvincia"].Width = 120;
            dgvProvincia.Columns["NombreProvincia"].HeaderText = "Nombre de provincia";
            dgvLocalidad.Columns["NombreLocalidad"].Width = 122;
            dgvLocalidad.Columns["NombreLocalidad"].HeaderText = "Nombre de localidad";
            
            dgvManagers.Columns["Tipo"].Visible = false;
            dgvManagers.Columns["IdSucursal"].Visible = false;
            dgvManagers.Columns["IdEmpleado"].Visible = false;
            dgvManagers.Columns["Estado"].Visible = false;


        }

        private void btnAddProv_Click(object sender, EventArgs e)
        {
            if (tbProvincia.Text != string.Empty)
            {
                string respuesta = clsProvincia.insertProvincia(tbProvincia.Text);
                MessageBox.Show(respuesta);
                tbProvincia.Clear();
            }
            else
            {
                MessageBox.Show("No se puede ingresar un campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddLocalidad_Click(object sender, EventArgs e)
        {
            if (dgvProvincia.SelectedRows.Count == 1 && tbLocalidad.Text != string.Empty)
            {
                int idProvincia = Convert.ToInt32(dgvProvincia.SelectedRows[0].Cells["IdProvincia"].Value);
                string resp = clsLocalidad.insertarLocalidad(tbLocalidad.Text, idProvincia);
                MessageBox.Show(resp);
                tbLocalidad.Clear();
            }
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void btnAddSucursal_Click(object sender, EventArgs e)
        {
            string error = "";
            if (dgvLocalidad.SelectedRows.Count == 1 && rtbDir.Text != string.Empty && tbTelefono.Text != string.Empty)
            {
                int idSucursal = Convert.ToInt32(dgvLocalidad.SelectedRows[0].Cells["IdLocalidad"].Value);
                string resp = clsSucursal.insertarSucursal(rtbDir.Text, tbTelefono.Text, idSucursal);
                MessageBox.Show(resp);
                rtbDir.Clear();
                tbTelefono.Clear();
            }
            else if (rtbDir.Text == string.Empty)
            {
                error += "Ingrese una Direccion valida \n";
            }
            else if (tbTel.Text == string.Empty)
            {
                error += "Ingrese un telefono Valido";
            }

            if (error != "") {
                MessageBox.Show(error, "Error");
            }

        }

        private void dgvLocalidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSucursal_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSucursal_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSucursal.SelectedRows.Count > 0)
            {
                pnlConfig.Visible = true;

                DataGridViewRow row = dgvSucursal.SelectedRows[0];
                string dir = row.Cells["Direccion"].Value.ToString();
                string tel = row.Cells["Telefono"].Value.ToString();
                bool activo = (bool)row.Cells["Estado"].Value;



                tbDir.Text = dir;
                tbTel.Text = tel;


                btnEstado.Tag = row.Cells["IdSucursal"].Value.ToString();

                if (activo)
                {
                    btnEstado.Text = "Dar de Baja";
                }
                else
                {
                    btnEstado.Text = "Dar de Alta";
                }

            }
        }
        

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Dar de Baja")
            {
                clsSucursal.darDeBaja(Convert.ToInt32((sender as Button).Tag));
            }
            else
            {
                clsSucursal.darDeAlta(Convert.ToInt32((sender as Button).Tag));
            }
            configurar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblDir.Text.Length < 5)
            {
                MessageBox.Show("Ingrese una Direccion Valida");
            }
            else if (tbTel.Text.Length < 5)
            {
                MessageBox.Show("Ingrese un telefono valido");
            }
            else 
            {
                int idSucursal = (int)dgvSucursal.SelectedRows[0].Cells["IdSucursal"].Value;
                int idManager = (int)dgvManagers.SelectedRows[0].Cells["IdEmpleado"].Value;

                clsSucursal.actualizar(idSucursal, tbDir.Text, idManager, tbTel.Text);
                configurar();
            }
        }

        private void dgvManagers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
