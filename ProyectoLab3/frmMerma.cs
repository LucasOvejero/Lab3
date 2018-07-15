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
using System.Data.SqlClient;
namespace ProyectoLab3
{
    public partial class frmMerma : Form
    {
        int IdSucursal;
        bool ingrediente;
        Merma merma;
        DataTable dtBebidas, dtIngredientes, dtEmpleado, dtMerma;
        int IdsolicitudMerma;
        public frmMerma()
        {
            IdsolicitudMerma = -1;
            InitializeComponent();
            IdSucursal = clsConexion.SucursalSession;
            try
            {
                dtBebidas = clsBebida.getBebidas(IdSucursal);
                dtIngredientes = clsIngrediente.getIngredientes(IdSucursal);
                dtEmpleado = clsEmpleado.empleadosDeSucrursalMerma(IdSucursal);
                dtMerma = clsMerma.getMerma(IdSucursal);
                DataRow ninguno = dtEmpleado.NewRow();
                ninguno["Nombre"] = "Nadie";
                ninguno["IdEmpleado"] = 0;
                dtEmpleado.Rows.InsertAt(ninguno, 0);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            merma = new Merma();
            merma.IdInformante = Convert.ToInt32(clsConexion.IdEmpleado);
            merma.IdSucursal = clsConexion.SucursalSession;
        }

        public frmMerma(int IdSol)
        {
            this.IdsolicitudMerma = IdSol;
            InitializeComponent();
            IdSucursal = clsConexion.SucursalSession;
            try
            {
                dtBebidas = clsBebida.getBebidas(IdSucursal);
                dtIngredientes = clsIngrediente.getIngredientes(IdSucursal);
                dtEmpleado = clsEmpleado.empleadosDeSucrursalMerma(IdSucursal);
                dtMerma = clsMerma.getMerma(IdSucursal);
                DataRow ninguno = dtEmpleado.NewRow();
                ninguno["Nombre"] = "Nadie";
                ninguno["IdEmpleado"] = 0;
                dtEmpleado.Rows.InsertAt(ninguno, 0);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            merma = new Merma();
            merma.IdInformante = Convert.ToInt32(clsConexion.IdEmpleado);
            merma.IdSucursal = clsConexion.SucursalSession;
        }

        private void frmMerma_Load(object sender, EventArgs e)
        {
            try
            {
                pnlSol.Visible = IdsolicitudMerma > -1;

                lbEmpleado.DataSource = dtEmpleado;
                lbEmpleado.DisplayMember = "Nombre";
                rbIngrediente.Checked = true;
                lbIngBeb.DataSource = dtIngredientes;
                lbIngBeb.DisplayMember = "Nombre";
                dgvMermas.DataSource = dtMerma;
                dgvMermas.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                dgvSol.DataSource = clsSolicitud.obtenerIngredientesDeSolicitud(this.IdsolicitudMerma);
                dgvSol.Columns["stockCritico"].Visible = false;
                dgvSol.Columns["estado"].Visible = false;
                dgvSol.Columns["fechaFin"].Visible = false;
                dgvSol.Columns["recibido"].Visible = false;
                dgvSol.Columns["Observacion"].Visible = false;
                dgvSol.Columns["fechaEnvio"].Visible = false;
                dgvSol.Columns["fechaInicio"].Visible = false;
                dgvSol.Columns["stockCritico"].Visible = false;

                dgvSol.Columns["NombreProducto"].HeaderText = "Producto";
                dgvSol.Columns["CostoxKg"].HeaderText = "Costo Producto";
                dgvSol.Columns["cantidad"].HeaderText = "Cantidad";
                dgvSol.Columns["costoTotal"].HeaderText = "Costo Total";


                dgvSol.Columns["cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvSol.Columns["costoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvSol.Columns["CostoxKg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void rbIngrediente_CheckedChanged(object sender, EventArgs e)
        {
            ingrediente = rbIngrediente.Checked;
            lbIngBeb.DataSource = null;
            lbIngBeb.DataSource = ingrediente ? dtIngredientes : dtBebidas;
            lbIngBeb.DisplayMember = "Nombre";
        }

        private void tbFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = string.Format(" Nombre like '%{0}%'", tbFiltro.Text);
            dtIngredientes.DefaultView.RowFilter = filtro;
            dtBebidas.DefaultView.RowFilter = filtro;
            lbIngBeb.Refresh();
        }

        private void tbFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = string.Format(" Nombre like '%{0}%'", tbFiltro.Text);
            dtEmpleado.DefaultView.RowFilter = filtro;
            lbEmpleado.Refresh();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            merma.Motivo = tbMotivo.Text;
            if (merma.Motivo != string.Empty)
            {
                merma.Cantidad = Convert.ToInt32(nupCantidad.Value);
                string resp = clsMerma.InsertMerma(merma);
                if (resp != string.Empty)
                {
                    MessageBox.Show(resp, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dtMerma = clsMerma.getMerma(IdSucursal);
                dgvMermas.DataSource = null;
                dgvMermas.DataSource = dtMerma;
                dgvMermas.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                tbMotivo.Clear();
            }
            else
            {
                error.SetError(tbMotivo, "Por favor ingresé un motivo");
            }
        }

        private void lbIngBeb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbIngBeb.DataSource != null)
            {
                DataRowView i = (lbIngBeb.SelectedItem as DataRowView);
                nupCantidad.Maximum = Convert.ToDecimal(i["Stock"].ToString());
                if (ingrediente)
                {
                    merma.IdIngrediente = Convert.ToInt32(i["IdIngrediente"].ToString());
                    merma.IdBebida = -1;
                    string u = i["Unidad"].ToString().Trim();
                    lblMerma.Text = u == "g" ? "Gramos" : u == "u" ? "Unidades" : "Milimetros";
                }
                else
                {
                    merma.IdBebida = Convert.ToInt32(i["IdBebida"].ToString());
                    merma.IdIngrediente = -1;
                    lblMerma.Text = "Unidades";
                }
            }
        }

        private void tbFiltroMerma_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvMermas.DataSource;
            dt.DefaultView.RowFilter = string.Format("Informante  like '%{0}%' OR Causante like '%{0}%' OR Producto like '%{0}%' OR Motivo like '%{0}%' ", tbFiltroMerma.Text);
            dgvMermas.Refresh();
        }

        private void nupCantidad_ValueChanged(object sender, EventArgs e)
        {
            merma.Cantidad = Convert.ToInt32(nupCantidad.Value.ToString());
        }

        private void lbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView empleado = (lbEmpleado.SelectedItem as DataRowView);
            merma.IdEmpleado = Convert.ToInt32(empleado["IdEmpleado"].ToString());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}
