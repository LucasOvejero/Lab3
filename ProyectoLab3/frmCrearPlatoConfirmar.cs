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
        public Plato Plato { get; set; }
        int x = 20, y = 0;
        int yvar = 80;
        List<Ingrediente> ingredientes;
        double total=0;
        private void frmCrearPlatoConfirmar_Load(object sender, EventArgs e)
        {
            int index;
            dgvIngredientes.Columns.Add("Ingrediente", "Ingrediente");
            dgvIngredientes.Columns.Add("Costo", "Costo");
            dgvIngredientes.Columns.Add("Cantidad", "Cantidad");
            dgvIngredientes.Columns.Add("Costo Total", "Costo Total");
            dgvIngredientes.Columns["Costo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIngredientes.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIngredientes.Columns["Costo"].DefaultCellStyle.Format = "c";
            dgvIngredientes.Columns["Costo Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIngredientes.Columns["Costo Total"].DefaultCellStyle.Format = "c";
            
            foreach (Ingrediente i in ingredientes) {
                index=dgvIngredientes.Rows.Add();
                dgvIngredientes.Rows[index].Cells["Ingrediente"].Value = i.NombreProducto;
                dgvIngredientes.Rows[index].Cells["Costo"].Value=i.CostoxKg;
                dgvIngredientes.Rows[index].Cells["Cantidad"].Value = i.Plato.NudGramos.Value+" "+i.Unidad.Trim();
                double coste = i.Unidad.Trim() == "u" ? (i.CostoxKg * Convert.ToInt32(i.Plato.NudGramos.Value)) : (i.CostoxKg * Convert.ToInt32(i.Plato.NudGramos.Value)) / 1000;
                dgvIngredientes.Rows[index].Cells["Costo Total"].Value = coste;
                total += coste;
            }
            index = dgvIngredientes.Rows.Add();
            dgvIngredientes.Rows[index].Cells["Cantidad"].Value = "Total:";
            dgvIngredientes.Rows[index].Cells["Costo Total"].Value = total;
            cboCategorias.DataSource= clsPlato.seleccionarCategorias();
            cboCategorias.DisplayMember = "Nombre";
            nudPrecio.Minimum = decimal.Parse(total.ToString());
            if (Plato != null) {
                btnAgregar.Visible = false;
                btnEditarPlato.Visible = true;
                tbNombre.Text = Plato.Nombre;
                nudPrecio.Value = Plato.Precio>nudPrecio.Minimum?Plato.Precio:nudPrecio.Minimum;
                cbTACC.Checked = Plato.TACC;
                int indice = -1;

                foreach (DataRowView item in cboCategorias.Items)
                {
                    indice++;
                    if (int.Parse(item.Row.ItemArray[0].ToString()) == Plato.IdCategoria)
                        break;
                }
                cboCategorias.SelectedIndex = indice;

            }
            
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

        private void btnEditarPlato_Click(object sender, EventArgs e)
        {
            errpPlatos.Clear();
            if (tbNombre.Text == string.Empty)
            {
                errpPlatos.SetError(tbNombre, "No se puede ingresar un plato sin nombre");
            }
            else if (cboCategorias.Items.Count == 0)
            {
                errpPlatos.SetError(cboCategorias, "Primero ingrese una categoria");
                tbCat.Focus();
            }
            else
            {
                DataRowView fila = cboCategorias.SelectedItem as DataRowView;//cboCategorias.SelectedItem as DataRowView;
                int idCategoria;
                idCategoria = int.TryParse(fila[0].ToString(), out idCategoria) ? idCategoria : 0;
                Plato.IdCategoria = idCategoria;
                Plato.Nombre = tbNombre.Text;
                Plato.Precio = nudPrecio.Value;
                Plato.Costo = decimal.Parse(total.ToString());
                Plato.TACC = cbTACC.Checked;
                string resp = clsPlato.actualizarPlato(Plato, ingredientes);
                if (resp == "")
                {
                    MessageBox.Show("Se ha actualizado el plato y sus ingredientes correctamente", "Éxito");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(resp, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
