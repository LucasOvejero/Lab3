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
    public partial class frmIngredientes : Form
    {
        #region variables
        DataSet ds;
        #endregion

        public frmIngredientes()
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
                dgvIngredientes.DataSource = clsIngrediente.seleccionarIngredientes();
               
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

        private void btnAddIngrediente_Click(object sender, EventArgs e)
        {
            string r;
            if (tbNombreIngrediente.Text == string.Empty)
                MessageBox.Show("No se puede ingresar un ingrediente sin nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (nudCostoPorKilo.Value == 0)
                MessageBox.Show("No se puede ingresar un ingrediente sin coste","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                r= clsIngrediente.insertarIngrediente(tbNombreIngrediente.Text,(double) nudCostoPorKilo.Value);
                MessageBox.Show(r,"Mensaje", MessageBoxButtons.OK);
                configurar();
            }
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSucursales.Items.Clear();
            cboLocalidad.Items.Clear();
            try{
                string provincia=cboProvincia.SelectedItem.ToString();
                if (provincia == "Todas")
                    lbSucursales.Items.AddRange(clsSucursal.getTodas());
                else
                {
                    cboLocalidad.Items.AddRange(clsLocalidad.getLocPerProv(provincia));
                }
             
                  
            }catch(SqlException ex){
            MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


           
        }
    }
}
