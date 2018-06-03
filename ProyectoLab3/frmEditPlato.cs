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
    public partial class frmEditPlato : Form
    {
        public frmEditPlato()
        {
            InitializeComponent();
        }
        DataTable platos,ingredientes;
        DataSet ds;
        BindingSource bsPlato = new BindingSource(), bsIng = new BindingSource();
        private void frmEditPlato_Load(object sender, EventArgs e)
        {
            try
            {
                platos=clsPlato.seleccionarPlato();
                ingredientes = clsIngrediente.obtenerIngredientesxReceta();
                ds = new DataSet();
                ds.Tables.Add(platos);
                ds.Tables.Add(ingredientes);
                ds.Relations.Add(new DataRelation("RelPlatoIng", ds.Tables["Platos"].Columns["IdPlato"], ds.Tables["Ingredientes"].Columns["IdPlato"]));
                bsPlato.DataSource = ds;
                bsPlato.DataMember = "Platos";
                bsIng.DataSource = bsPlato;
                bsIng.DataMember = "RelPlatoIng";
                dgvPlatos.DataSource = bsPlato;
                dgvIngredientes.DataSource = bsIng;
                
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       


     
    }
}
