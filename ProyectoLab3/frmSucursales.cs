using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Clases;
namespace ProyectoLab3
{
    public partial class frmSucursales : Form
    {
        #region variables
        BindingSource bsLoc= new BindingSource(), bsProv=new BindingSource(), bsSuc= new BindingSource();
        DataSet ds;
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
            ds.Tables.Add(clsLocalidad.seleccionar());
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
    }
}
