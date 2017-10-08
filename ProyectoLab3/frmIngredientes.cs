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
                ds.Tables.Add(clsIngrediente.seleccionarIngredientes());
                AsignarGrillas();
            }
            catch (SqlException e) {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void AsignarGrillas() {
            dgvIngred.DataSource = ds;
            dgvIngred.DataMember = "Ingredientes";
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
    }
}
