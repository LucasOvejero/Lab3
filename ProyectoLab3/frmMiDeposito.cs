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
    public partial class frmMiDeposito : Form
    {
        int idSucursal;
        DataSet ds;
        SqlCommandBuilder scbIngredientes, scbBebidas;
        string direccion;
        public frmMiDeposito(int IdMiSucursal)
        {
            InitializeComponent();
            idSucursal = IdMiSucursal;
        }

        private void frmMiDeposito_Load(object sender, EventArgs e)
        {
            dgvIngredientes.ReadOnly = false;
            dgvBebidas.ReadOnly = false;
            direccion = clsSucursal.getDirecciónSucursal(idSucursal);
            if (!direccion.Contains("Error:"))
            {
                ds = clsDeposito.getDepositoPorDireccion(direccion);

                dgvBebidas.DataSource = ds.Tables["Bebidas"];
                dgvIngredientes.DataSource = ds.Tables["Ingredientes"];
                dgvIngredientes.DataSourceChanged+=new EventHandler(dgvIngredientes_DataSourceChanged);
                dgvBebidas.DataSourceChanged += new EventHandler(dgvIngredientes_DataSourceChanged);
                dgvBebidas.DataError += new DataGridViewDataErrorEventHandler(dgvBebidas_DataError);
                dgvIngredientes.DataError += new DataGridViewDataErrorEventHandler(dgvBebidas_DataError);
                //ds.Tables["Ingredientes"].RowChanged+=new DataRowChangeEventHandler(frmMiDeposito_RowChanged);
                //ds.Tables["Bebidas"].RowChanged += new DataRowChangeEventHandler(frmMiDeposito_RowChanged);
            }
            else {
                MessageBox.Show(direccion,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
            }
        }

        void dgvBebidas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {            
            MessageBox.Show("Solamente puede ingresar numeros mayores a 0", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);     
        }

     
        private void tbBebidas_TextChanged(object sender, EventArgs e)
        {
            
            DataTable dt = (DataTable)dgvBebidas.DataSource;
            dt.DefaultView.RowFilter = string.Format("NombreBebida like '%{0}%'", tbBebidas.Text.Trim().Replace("'", "''"));
            dgvBebidas.Refresh();
        }

        private void tbIngredientes_TextChanged(object sender, EventArgs e)
        {
            
            DataTable dt = (DataTable)dgvIngredientes.DataSource;
            dt.DefaultView.RowFilter = string.Format("Nombre like '%{0}%'", tbIngredientes.Text.Trim().Replace("'", "''"));
            dgvIngredientes.Refresh();
        }

        private void dgvIngredientes_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvBebidas.DataSource != null && dgvIngredientes.DataSource != null)
            {
                dgvBebidas.Columns["Stock"].ReadOnly = true;
                dgvBebidas.Columns["NombreBebida"].ReadOnly = true;
                dgvBebidas.Columns["NombreBebida"].HeaderText = "Nombre";
                dgvIngredientes.Columns["Stock"].ReadOnly = true;
                dgvIngredientes.Columns["Nombre"].HeaderText = "Nombre";
                dgvIngredientes.Columns["Nombre"].ReadOnly = true;
                dgvBebidas.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvBebidas.Columns["Agregar U."].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvIngredientes.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvIngredientes.Columns["Agregar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvBebidas.Columns["Agregar U."].ValueType = typeof(uint);
                dgvIngredientes.Columns["Agregar"].ValueType = typeof(uint);
            }
        }

        private void btnActI_Click(object sender, EventArgs e)
        {
            DataTable ingredientes = (DataTable)dgvIngredientes.DataSource;
            DataTable nuevaTablaIngredientes;
            tbIngredientes.Clear();
            string resp = clsDeposito.actualizarIngredientes(ingredientes, direccion, out nuevaTablaIngredientes);
            if (resp == "")
            {
                dgvIngredientes.DataSource = null;
                dgvIngredientes.DataSource = nuevaTablaIngredientes;
                MessageBox.Show("Stock de ingredientes actualizado correctamente", "Éxito!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     
        }

        private void btnActB_Click(object sender, EventArgs e)
        {
             DataTable bebidas = (DataTable)dgvBebidas.DataSource;
             DataTable nuevaTablaBebidas;
             tbBebidas.Clear();
             string resp = clsDeposito.actualizarBebidas(bebidas, direccion, out nuevaTablaBebidas);
             if (resp == "")
             {
                 dgvBebidas.DataSource = null;
                 dgvBebidas.DataSource = nuevaTablaBebidas;
                 MessageBox.Show("Stock de bebidas actualizado correctamente", "Éxito!", MessageBoxButtons.OK);
             }
             else {
                 MessageBox.Show(resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

        }
    }
}
