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
using Modelo;
namespace ProyectoLab3
{
    public partial class FrmEditPlato : Form
    {
        public FrmEditPlato()
        {
            InitializeComponent();
        }
        DataTable platos,ingredientes;
        DataSet ds;
        BindingSource bsPlato = new BindingSource(), bsIng = new BindingSource();
        private void FrmEditPlato_Load(object sender, EventArgs e)
        {
            try
            {
                Setear();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Setear() {
            dgvIngredientes.DataSource = null;
            dgvPlatos.DataSource = null;
            platos = clsPlato.seleccionarPlato();
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
            //dgvBebidas.Columns["Costo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvBebidas.Columns["Costo"].DefaultCellStyle.Format = "c";
            dgvPlatos.Columns["Costo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlatos.Columns["Costo"].DefaultCellStyle.Format = "c";
            dgvPlatos.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlatos.Columns["Precio"].DefaultCellStyle.Format = "c";
            dgvIngredientes.Columns["Cant"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIngredientes.Columns["Cantidad"].Visible = false;
            dgvIngredientes.Columns["Unidad"].Visible = false;
            dgvIngredientes.Columns["CostoxKg"].Visible = false;
            dgvIngredientes.Columns["NombreProducto"].HeaderText = "Ingrediente";
            dgvIngredientes.Columns["Cant"].HeaderText = "Cantidad";

        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            List<Ingrediente> ingredientes = new List<Ingrediente>();
            foreach (DataGridViewRow r in dgvIngredientes.Rows) {
                Ingrediente ing = new Ingrediente
                {
                    IdIngrediente = int.Parse(r.Cells["IdIngrediente"].Value.ToString())
                };
                int cantidad = int.Parse(r.Cells["Cantidad"].Value.ToString());
                ing.NombreProducto = r.Cells["NombreProducto"].Value.ToString();
                ing.CostoxKg = double.Parse(r.Cells["CostoxKg"].Value.ToString());
                ing.IdCategoria = int.Parse(r.Cells["IdCategoria"].Value.ToString());
                ing.Unidad = r.Cells["Unidad"].Value.ToString();
                string unidad = ing.Unidad.Trim() == "g" ? "gramos" : ing.Unidad.Trim() == "u" ? "unidades" : "milimetros";
                ing.Plato = new PanelPlato(ing.NombreProducto,unidad)
                {
                    Tag = ing.IdIngrediente
                };
                ing.Plato.NudGramos.Value = cantidad;
                ingredientes.Add(ing);
            }
            DataGridViewRow plato= dgvPlatos.SelectedRows[0];

            Plato p = new Plato() { Nombre = plato.Cells["Nombre"].Value.ToString()
                , IdPlato = int.Parse(plato.Cells["IdPlato"].Value.ToString())
                ,Precio = decimal.Parse(plato.Cells["Precio"].Value.ToString())
                ,TACC= bool.Parse(plato.Cells["TACC"].Value.ToString())
                ,Costo=decimal.Parse(plato.Cells["Costo"].Value.ToString())
                
                ,IdCategoria=int.Parse(plato.Cells["IdCategoria"].Value.ToString())
            };
            frmCrearPlatoSeleccionIng ofrmSelIng = new frmCrearPlatoSeleccionIng(ingredientes, p);
            ofrmSelIng.ShowDialog();
            Setear();
        }

        private void TbNombre_TextChanged(object sender, EventArgs e)
        {
            //platos.DefaultView.RowFilter=string.Format("Nombre like '%{0}%'",tbNombre.Text);
            //(bsPlato.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre like '%{0}%'", tbNombre.Text);
            bsPlato.Filter = string.Format("Nombre like '%{0}%'", tbNombre.Text);
            dgvPlatos.Refresh();
        }

        private void dgvPlatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow r in dgvPlatos.Rows)
            {
                decimal costo = decimal.Parse(r.Cells["Costo"].Value.ToString());
                decimal precio = decimal.Parse(r.Cells["Precio"].Value.ToString());
                if (precio<costo)
                {
                    r.DefaultCellStyle.BackColor = Color.Red;
                    r.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }



       


     
    }
}
