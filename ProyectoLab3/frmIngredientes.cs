using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;
using Componentes;
using System.Data.SqlClient;
namespace ProyectoLab3
{
    public partial class frmDepositos : Form
    {
        #region variables
        DataSet ds;
        #endregion

        public frmDepositos()
        {
            InitializeComponent();
        }

        private void frmIngredientes_Load(object sender, EventArgs e)
        {
            configurar();
        }
        private void configurar() {
            ds = new DataSet();
            try
            {
               
               
                cboProvincia.Items.AddRange( clsProvincia.getProvinciasConSucursales().ToArray());
                cboProvincia.SelectedIndex = 0;
               // ds.Tables.Add(clsIngrediente.seleccionarIngredientes());
              //  AsignarGrillas();
            }
            catch (SqlException e) {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void AsignarGrillas() {
           // dgvIngredientes.DataSource = ds;
          //  dgvIngredientes.DataMember = "Ingredientes";
        }

    
        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSucursales.Items.Clear();
            cboLocalidad.Items.Clear();
            try{
                string provincia=cboProvincia.SelectedItem.ToString();
                if (provincia == "Todas")
                {
                    lbSucursales.Items.AddRange(clsSucursal.getTodas());
                    cboLocalidad.Items.AddRange(clsLocalidad.getTodas());
                    cboLocalidad.SelectedIndex = 0;
                }
                else
                {
                    cboLocalidad.Items.AddRange(clsLocalidad.getLocPerProv(provincia));
                    cboLocalidad.SelectedIndex = 0;
                }
             
                  
            }catch(SqlException ex){
            MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


           
        }

        private void cboLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSucursales.Items.Clear();
            try
            {
                string localidad = cboLocalidad.SelectedItem.ToString();
                string provincia = cboProvincia.SelectedItem.ToString();
                if (localidad == "Todas" && provincia=="Todas" )
                {
                    lbSucursales.Items.AddRange(clsSucursal.getTodas());
                    
                }
                else if(localidad == "Todas"){
                    lbSucursales.Items.AddRange(clsSucursal.getPerProv(provincia));
                    
                }
                else
                {
                       lbSucursales.Items.AddRange(clsSucursal.getPerLocProv(localidad, provincia));
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            string direccion=lbSucursales.SelectedItem.ToString();
            ds=clsDeposito.getDepositoPorDireccion(direccion);
            dgvBebidas.DataSource = ds.Tables["Bebidas"];
            dgvBebidas.Columns["Agregar U."].Visible = false;
            dgvBebidas.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIngredientes.DataSource = ds.Tables["Ingredientes"];
            dgvIngredientes.Columns["Agregar"].Visible = false;
            dgvIngredientes.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void dgvIngredientes_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int i = 2;
        }
    }
}
