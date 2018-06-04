using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;
using Modelo;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            List<Ingrediente> ingredientes = new List<Ingrediente>();
            foreach (DataGridViewRow r in dgvIngredientes.Rows) {
                Ingrediente ing=new Ingrediente();
                ing.IdIngrediente=int.Parse(r.Cells["IdIngrediente"].Value.ToString());

                ing.NombreProducto = r.Cells["NombreProducto"].Value.ToString();
                ing.CostoxKg = double.Parse(r.Cells["CostoxKg"].Value.ToString());
                ing.IdCategoria = int.Parse(r.Cells["IdCategoria"].Value.ToString());
                ingredientes.Add(ing);
            }
            DataGridViewRow plato= dgvPlatos.SelectedRows[0];

            Plato p = new Plato() { Nombre = plato.Cells["Nombre"].Value.ToString()
                , IdPlato = int.Parse(plato.Cells["IdPlato"].Value.ToString())
                ,Precio = decimal.Parse(plato.Cells["Precio"].Value.ToString())
                ,TACC= bool.Parse(plato.Cells["TACC"].Value.ToString())
                ,Costo=decimal.Parse(plato.Cells["Costo"].Value.ToString())
                ,Estado=bool.Parse(plato.Cells["Estado"].Value.ToString())
                ,IdCategoria=int.Parse(plato.Cells["IdCategoria"].Value.ToString())
            };
            frmCrearPlatoSeleccionIng ofrmSelIng = new frmCrearPlatoSeleccionIng(ingredientes, p);
            ofrmSelIng.ShowDialog();
        }

       


     
    }
}
