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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        clsBebida bebida;

        private void frmBebidas_Load(object sender, EventArgs e)
        {
            bebida = new clsBebida();
            refrescarInterfaz();
            dgvIngredientes.DataSource = null;
            dgvIngredientes.DataSource = clsIngrediente.seleccionarIngredientes();
            configurarIngredientes();
            darFormato();

        }
        private void refrescarInterfaz()
        {

            try
            {
                int row = dgvBebidas.SelectedRows.Count > 0 ? dgvBebidas.SelectedRows[0].Index : 0;
                dgvBebidas.DataSource = null;
                dgvBebidas.DataSource = bebida.seleccionarBebidas();
                dgvBebidas.Rows[row].Selected = true;
                actualizarCboCatBebida();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        private void actualizarCboCatBebida()
        {
            cboCatAddBebida.DataSource = null;
            cboCatAddBebida.DataSource = bebida.obtenerCategorias();
            cboCatAddBebida.DisplayMember = "Nombre";
            cboEditCatBebida.DataSource = null;
            cboEditCatBebida.DataSource = bebida.obtenerCategorias();
            cboEditCatBebida.DisplayMember = "Nombre";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            errpNBebida.Clear();
            if (tbNombre.Text == "" || tbNombre.Text == string.Empty)
                errpNBebida.SetError(tbNombre, "No se puede ingresar una bebida sin nombre");
            else if (nudPrecio.Value==0)
                errpNBebida.SetError(nudPrecio, "No se puede ingresar un precio 0");
            else if (nudCosto.Value == 0)
                errpNBebida.SetError(nudCosto, "No se puede ingresar un precio 0");
            else if (nudLitros.Value == 0)
                errpNBebida.SetError(nudLitros, "No se puede ingresar un precio 0");
            else
            {
                bebida.NombreBebida = tbNombre.Text;
                bebida.Alcohol = cbAlcohol.Checked;
                bebida.Costo = nudCosto.Value;
                bebida.Precio = nudPrecio.Value;
                bebida.Litros = nudLitros.Value;
                DataRowView fila = cboCatAddBebida.SelectedItem as DataRowView;//cboCategorias.SelectedItem as DataRowView;
                int idCategoria;
                idCategoria = int.TryParse(fila[0].ToString(), out idCategoria) ? idCategoria : 0;
                bebida.IdCategoria = idCategoria;
                try
                {
                    bebida.insertarBebida();
                    refrescarInterfaz();
                }
                catch (SqlException sqlEx) { MessageBox.Show(sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void darFormato()
        {
            if (dgvBebidas.DataSource != null)
            {

                dgvBebidas.Columns["Costo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvBebidas.Columns["Costo"].DefaultCellStyle.Format = "c";
                dgvBebidas.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvBebidas.Columns["Precio"].DefaultCellStyle.Format = "c";
                dgvBebidas.Columns["Litros"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgvIngredientes.DataSource != null)
            {
                dgvIngredientes.Columns["CostoxKg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvIngredientes.Columns["CostoxKg"].DefaultCellStyle.Format = "c";
                dgvIngredientes.Columns["NombreProducto"].HeaderText = "Nombre";
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idSeleccionado;
            if (dgvBebidas.SelectedRows != null)
            {
                idSeleccionado = (Int32)dgvBebidas.SelectedRows[0].Cells["IdBebida"].Value;
                bebida.UpdateEstadoBebida(idSeleccionado, (bool)dgvBebidas.SelectedRows[0].Cells["Estado"].Value);
                MessageBox.Show("Se ha actualizado el estado correctamente la bebida", "Actualizado");
                refrescarInterfaz();
            }
            else
                MessageBox.Show("Seleccione la bebida en la grilla que desea eliminar", "No se ha seleccionado bebida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvBebidas.SelectedRows.Count > 0)
            {
                bebida.NombreBebida = tbEditName.Text;
                bebida.Precio = nudEditPrecio.Value;
                bebida.Costo = nudEditCosto.Value;
                bebida.Alcohol = cbEditAlcohol.Checked;
                bebida.Litros = nudEditLitros.Value;
                DataRowView cat = cboEditCatBebida.SelectedItem as DataRowView;
                int idCategoria;
                idCategoria = int.TryParse(cat[0].ToString(), out idCategoria) ? idCategoria : 0;
                bebida.IdCategoria = idCategoria;
                try
                {
                    bebida.modificarBebida((Int32)dgvBebidas.SelectedRows[0].Cells["IdBebida"].Value);
                    MessageBox.Show("Se ha actualizado correctamente la bebida", "Actualizado");
                    refrescarInterfaz();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dgvBebidas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {


        }



        private void dgvBebidas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvBebidas.SelectedRows.Count > 0 ? dgvBebidas.SelectedRows[0] : null;
            if (fila != null)
            {
                tbEditName.Text = fila.Cells["NombreBebida"].Value.ToString();
                nudEditPrecio.Value = getDecimalValue(fila.Cells["Precio"]);
                nudEditCosto.Value = getDecimalValue(fila.Cells["Costo"]);
                nudEditLitros.Value = getDecimalValue(fila.Cells["Litros"]);
                cbEditAlcohol.Checked = getBoolValue(fila.Cells["Alcohol"]);
                btnBorrar.Text = getBoolValue(fila.Cells["Estado"]) ? "Baja" : "Alta";
                string categoria = fila.Cells["Categoria"].Value.ToString();//IdCategoria no tiene nada, ver TODO
                int indice = -1;

                foreach (DataRowView item in cboEditCatBebida.Items)
                {
                    indice++;
                    if (item.Row.ItemArray[1].ToString() == categoria)
                        break;
                }
                cboEditCatBebida.SelectedIndex = indice;

            }
        }

        private void btnAddIngrediente_Click(object sender, EventArgs e)
        {
            errpNBebida.Clear();
            string r;
            if (tbNombreIngrediente.Text == string.Empty)
                errpNBebida.SetError(tbNombreIngrediente,"No se puede ingresar un ingrediente sin nombre");
            else if (nudCostoPorKilo.Value == 0)
                errpNBebida.SetError(nudCostoPorKilo,"No se puede ingresar un ingrediente sin coste");
            else
            {
                try
                {
                    DataRowView fila = cboCategorias.SelectedItem as DataRowView;
                    int idCategoria;
                    idCategoria = int.TryParse(fila[0].ToString(), out idCategoria) ? idCategoria : 0;
                    r = clsIngrediente.insertarIngrediente(tbNombreIngrediente.Text, (double)nudCostoPorKilo.Value, idCategoria);
                    MessageBox.Show(r, "Mensaje", MessageBoxButtons.OK);
                    configurarIngredientes();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void configurarIngredientes()
        {

            try
            {
                //dgvIngredientes.DataSource = null;
                //dgvIngredientes.DataSource = clsIngrediente.seleccionarIngredientes();
                actualizarCategoriasIngredientes();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        private void actualizarCategoriasIngredientes()
        {
            cboCategorias.DataSource = null;
            cboCategorias.DataSource = clsIngrediente.obtenerCategoriasIngredientes();
            cboCategorias.DisplayMember = "Nombre";
            cboEditCateg.DataSource = null;
            cboEditCateg.DataSource = clsIngrediente.obtenerCategoriasIngredientes();
            cboEditCateg.DisplayMember = "Nombre";
        }
        private void btnActualizarIngrediente_Click(object sender, EventArgs e)
        {
            int c = dgvIngredientes.Rows.Count;
            if (c > 0)
            {
                DataGridViewRow fila = dgvIngredientes.SelectedRows[0];
                try
                {

                    DataRowView cat = cboEditCateg.SelectedItem as DataRowView;
                    int idCategoria;
                    idCategoria = int.TryParse(cat[0].ToString(), out idCategoria) ? idCategoria : 0;
                    string resp = clsIngrediente.actualizar(getIntValue(fila.Cells["IdIngrediente"]), tbEditNombreIngrediente.Text, nudEditCostoIngrediente.Value, idCategoria);
                    MessageBox.Show(resp, "Exito!", MessageBoxButtons.OK);
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dgvIngredientes_SelectionChanged(object sender, EventArgs e)
        {
            int c = dgvIngredientes.Rows.Count;
            if (c > 0)
            {
                DataGridViewRow fila = dgvIngredientes.SelectedRows[0];
                nudEditCostoIngrediente.Value = getDecimalValue(fila.Cells["CostoxKg"]);
                tbEditNombreIngrediente.Text = fila.Cells["NombreProducto"].Value.ToString();
                string categoria = fila.Cells["IdCategoria"].Value.ToString();
                int indice = -1;

                foreach (DataRowView item in cboEditCateg.Items)
                {
                    indice++;
                    if (item.Row.ItemArray[0].ToString() == categoria)
                        break;
                }
                cboEditCateg.SelectedIndex = indice;
            }
        }
        #region getValues
        private decimal getDecimalValue(DataGridViewCell celda)
        {
            decimal res;
            return decimal.TryParse(celda.Value.ToString(), out res) ? res : 0;
        }
        private bool getBoolValue(DataGridViewCell celda)
        {
            return bool.Parse(celda.Value.ToString());
        }
        private int getIntValue(DataGridViewCell celda)
        {
            int res;
            return int.TryParse(celda.Value.ToString(), out res) ? res : 0;
        }
        #endregion



        private void btnAgregarCategoria_Click_1(object sender, EventArgs e)
        {
            string categoria = tbNombreCategoria.Text;
            if (categoria != string.Empty)
            {
                string respuesta = clsIngrediente.agregarCategoriaIngrediente(categoria);
                if (respuesta == "")
                    MessageBox.Show(string.Format("Se ha agregado la categoria {0} correctamente ", categoria), "Agregado Correctamente");
                else
                    MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNombreCategoria.Clear();
                actualizarCategoriasIngredientes();
            }
            else {
                errpNBebida.Clear();
                errpNBebida.SetError(tbNombreCategoria, "No se puede agregar una categoria sin nombre");
            }
        }

        private void cbAlcohol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cbAlcohol.Checked = !cbAlcohol.Checked;   // Enter key pressed
            }
            //TODO: al apretar enter cambiar el estado del control;
        }

        private void btnAgregarCatBebida_Click(object sender, EventArgs e)
        {
            errpNBebida.Clear();
            string categoria = tbCatBeb.Text;
            if (categoria != string.Empty)
            {
                string respuesta = bebida.agregarCategoria(categoria); //clsIngrediente.agregarCategoriaIngrediente(categoria);
                if (respuesta == "")
                    MessageBox.Show(string.Format("Se ha agregado la categoria {0} correctamente ", categoria), "Agregado Correctamente");
                else
                    MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCatBeb.Clear();
                actualizarCboCatBebida();
            }
            else {
                errpNBebida.SetError(tbCatBeb, "No se puede agregar una bebida sin nombre");
            }
        }




    }
}