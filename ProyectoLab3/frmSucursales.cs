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
        BindingSource bsLoc= new BindingSource(), bsProv=new BindingSource(), bsSuc= new BindingSource();
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
            relacion = new DataRelation("RelProvLoc", ds.Tables["Provincias"].Columns["IdProvincia"], ds.Tables["Localidades"].Columns["IdProvincia"]);
            ds.Relations.Add(relacion);
            ds.Relations.Add(new DataRelation("RelLocSuc",ds.Tables["Localidades"].Columns["IdLocalidad"],ds.Tables["Sucursales"].Columns["IdLocalidad"]));
            AsignarGrillas();
        }
        private void AsignarGrillas() {
            bsProv.DataSource = ds;
            bsProv.DataMember = "Provincias";
            bsLoc.DataSource = bsProv;
            bsLoc.DataMember = "RelProvLoc";
            dgvLocalidad.DataSource = bsLoc;
            dgvProvincia.DataSource = bsProv;
            bsSuc.DataSource = bsLoc;
            bsSuc.DataMember = "RelLocSuc";
            dgvSucursal.DataSource = bsSuc;
            formatearGrillas();
        }
        private void formatearGrillas() {
            dgvLocalidad.Columns["IdLocalidad"].Visible = false;
            dgvLocalidad.Columns["IdProvincia"].Visible = false;
            dgvProvincia.Columns["IdProvincia"].Visible = false;
            dgvSucursal.Columns["IdLocalidad"].Visible = false;
            dgvSucursal.Columns["IdSucursal"].Visible = false;
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
                MessageBox.Show("No se puede ingresar un campo vacío","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAddLocalidad_Click(object sender, EventArgs e)
        {
            if (dgvProvincia.SelectedRows.Count ==1 && tbLocalidad.Text!=string.Empty)
            {   
                int idProvincia= Convert.ToInt32(dgvProvincia.SelectedRows[0].Cells["IdProvincia"].Value);
                string resp= clsLocalidad.insertarLocalidad(tbLocalidad.Text, idProvincia);
                MessageBox.Show(resp);
                tbLocalidad.Clear();
            }
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }
    }
}
