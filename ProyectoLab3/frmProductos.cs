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
                dgvBebidas.Rows[row].Selected=true;
            }
            catch (SqlException e) {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bebida.NombreBebida = tbNombre.Text;
            bebida.Alcohol = cbAlcohol.Checked;
            bebida.Costo = nudCosto.Value;
            bebida.Precio = nudPrecio.Value;
            bebida.Litros = nudLitros.Value;
            try
            {
                bebida.insertarBebida();
                refrescarInterfaz();
            }
            catch (SqlException sqlEx) { MessageBox.Show(sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void darFormato() {
            if (dgvBebidas.DataSource != null)
            {
               
                dgvBebidas.Columns["Costo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvBebidas.Columns["Costo"].DefaultCellStyle.Format = "c";
                dgvBebidas.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvBebidas.Columns["Precio"].DefaultCellStyle.Format = "c";
                dgvBebidas.Columns["Litros"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgvIngredientes.DataSource != null) {
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
                bebida.UpdateEstadoBebida(idSeleccionado,(bool)dgvBebidas.SelectedRows[0].Cells["Estado"].Value);
                MessageBox.Show("Se ha actualizado el estado correctamente la bebida", "Actualizado"); 
                refrescarInterfaz();
            }
            else
                MessageBox.Show("Seleccione la bebida en la grilla que desea eliminar","No se ha seleccionado bebida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                catch (Exception ex) {
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
                
            }
        }

        private void btnAddIngrediente_Click(object sender, EventArgs e)
        {

            string r;
            if (tbNombreIngrediente.Text == string.Empty)
                MessageBox.Show("No se puede ingresar un ingrediente sin nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (nudCostoPorKilo.Value == 0)
                MessageBox.Show("No se puede ingresar un ingrediente sin coste", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    DataRowView fila = cboCategorias.SelectedItem as DataRowView;
                    int idCategoria;
                    idCategoria= int.TryParse(fila.Row["IdCategoria"].ToString(), out idCategoria)?idCategoria:0;
                    r = clsIngrediente.insertarIngrediente(tbNombreIngrediente.Text, (double)nudCostoPorKilo.Value,idCategoria);
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
                dgvIngredientes.DataSource = null;
                dgvIngredientes.DataSource = clsIngrediente.seleccionarIngredientes();
                cboCategorias.DataSource = clsIngrediente.obtenerCategoriasIngredientes();
                cboCategorias.DisplayMember = "Nombre";

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void btnActualizarIngrediente_Click(object sender, EventArgs e)
        {
            int c= dgvIngredientes.Rows.Count;
            if (c > 0) {
                DataGridViewRow fila=dgvIngredientes.SelectedRows[0];
                try
                {
                    string resp = clsIngrediente.actualizar(getIntValue(fila.Cells["IdIngrediente"]), tbEditNombreIngrediente.Text, nudEditCostoIngrediente.Value);
                    MessageBox.Show(resp, "Exito!", MessageBoxButtons.OK);
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void dgvIngredientes_SelectionChanged(object sender, EventArgs e)
        {
            int c= dgvIngredientes.Rows.Count;
            if (c > 0) { 
                DataGridViewRow fila=dgvIngredientes.SelectedRows[0];
                nudEditCostoIngrediente.Value=getDecimalValue(fila.Cells["CostoxKg"]);
                tbEditNombreIngrediente.Text = fila.Cells["NombreProducto"].Value.ToString();
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
        private int getIntValue(DataGridViewCell celda) {
            int res;
            return int.TryParse(celda.Value.ToString(),out res)?res:0;
        }
        #endregion

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            string categoria = tbNombreCategoria.Text;
            if (categoria != string.Empty)
            {
                string respuesta = clsIngrediente.agregarCategoriaIngrediente(categoria);
                if (respuesta == "")
                    MessageBox.Show(string.Format("Se ha agregado la categoria {0} correctamente la bebida", categoria), "Agregado Correctament");
                else
                    MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNombreCategoria.Clear();
            }
        }
    }
}
