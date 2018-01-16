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
            dgvBebidas.DataSource = null;
            try
            {
                dgvBebidas.DataSource = bebida.seleccionarBebidas();
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
                bebida.eliminarBebida(idSeleccionado);
                MessageBox.Show("Se ha eliminado correctamente la bebida", "Borrado"); 
                refrescarInterfaz();
            }
            else
                MessageBox.Show("Seleccione la bebida en la grilla que desea eliminar","No se ha seleccionado bebida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }


    }
}
