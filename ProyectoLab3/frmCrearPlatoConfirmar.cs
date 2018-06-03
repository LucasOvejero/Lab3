using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Componentes;
using Clases;
using System.Data.SqlClient;
namespace ProyectoLab3
{
    public partial class frmCrearPlatoConfirmar : Form
    {
        public frmCrearPlatoConfirmar(List<Ingrediente> ingredientes)
        {
            InitializeComponent();
            this.ingredientes = ingredientes;
        }
        int x = 20, y = 0;
        int yvar = 80;
        List<Ingrediente> ingredientes;
        double total=0;
        private void frmCrearPlatoConfirmar_Load(object sender, EventArgs e)
        {
            int index;
            dgvIngredientes.Columns.Add("Ingrediente", "Ingrediente");
            dgvIngredientes.Columns.Add("Costo x Kg", "Costo x Kg");
            dgvIngredientes.Columns.Add("Gramos", "Gramos");
            dgvIngredientes.Columns.Add("Costo Total", "Costo Total");
            dgvIngredientes.Columns["Costo x Kg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIngredientes.Columns["Gramos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIngredientes.Columns["Costo x Kg"].DefaultCellStyle.Format = "c";
            dgvIngredientes.Columns["Costo Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIngredientes.Columns["Costo Total"].DefaultCellStyle.Format = "c";
            
            foreach (Ingrediente i in ingredientes) {
                index=dgvIngredientes.Rows.Add();
                dgvIngredientes.Rows[index].Cells["Ingrediente"].Value = i.NombreProducto;
                dgvIngredientes.Rows[index].Cells["Costo x Kg"].Value=i.CostoxKg;
                dgvIngredientes.Rows[index].Cells["Gramos"].Value = i.Plato.NudGramos.Value+"g";
                double coste = (i.CostoxKg * Convert.ToInt32(i.Plato.NudGramos.Value)) / 1000;
                dgvIngredientes.Rows[index].Cells["Costo Total"].Value = coste;
                total += coste;
            }
            index = dgvIngredientes.Rows.Add();
            dgvIngredientes.Rows[index].Cells["Gramos"].Value = "Total:";
            dgvIngredientes.Rows[index].Cells["Costo Total"].Value = total;
            cboCategorias.DataSource= clsPlato.seleccionarCategorias();
            cboCategorias.DisplayMember = "Nombre";
            nudPrecio.Minimum = decimal.Parse(total.ToString());
            
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            errpPlatos.Clear();
            if (tbCat.Text != string.Empty)
            {
                string resp= clsPlato.insertarCategoria(tbCat.Text);
                if (resp == "")
                {
                    MessageBox.Show("Se agregó la categoría correctamente", "Éxito!", MessageBoxButtons.OK);
                    tbCat.Clear();
                }
                else
                {
                    MessageBox.Show(resp, "Error!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                errpPlatos.SetError(tbCat, "No puede ser vacío");
            }
        }

        private void nudPrecio_ValueChanged(object sender, EventArgs e)
        {

            lblGanancia.Text = (nudPrecio.Value-decimal.Parse(total.ToString())).ToString("c");
        }

    

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            errpPlatos.Clear();
            if (tbNombre.Text == string.Empty) {
                errpPlatos.SetError(tbNombre, "No se puede ingresar un plato sin nombre");
            }
            else if(cboCategorias.Items.Count==0){
                errpPlatos.SetError(cboCategorias,"Primero ingrese una categoria");
                tbCat.Focus();
            }
            else{
                 DataRowView fila = cboCategorias.SelectedItem as DataRowView;//cboCategorias.SelectedItem as DataRowView;
                int idCategoria;
                idCategoria = int.TryParse(fila[0].ToString(), out idCategoria) ? idCategoria : 0;
                string resp=clsPlato.insertarPlato(tbNombre.Text,double.Parse(nudPrecio.Value.ToString()),total,true,idCategoria,cbTACC.Checked,this.ingredientes);
                if(resp==""){
                    MessageBox.Show("Se ha ingresado el plato y sus ingredientes correctamente","Éxito");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                 MessageBox.Show(resp,"Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

    }
}
