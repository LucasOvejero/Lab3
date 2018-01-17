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
    public partial class frmBebidas : Form
    {
        public frmBebidas()
        {
            InitializeComponent();
        }
        clsBebida bebida;
        
        private void frmBebidas_Load(object sender, EventArgs e)
        {
            bebida = new clsBebida();
       
            refrescarInterfaz();
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
            darFormato();
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
            
        }

        private void dgvBebidas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
                
        }

        private decimal getDecimalValue(DataGridViewCell celda) {
            decimal res;
            return decimal.TryParse(celda.Value.ToString(), out res) ? res : 0;
        }
        private bool getBoolValue(DataGridViewCell celda) {
            return bool.Parse(celda.Value.ToString());
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
                if (getBoolValue(fila.Cells["Estado"]))
                {

                }
            }
        }
    }
}
