using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoLab3
{
    public partial class frmNuevaSolicitud : Form
    {
        public frmNuevaSolicitud()
        {
            InitializeComponent();

        }

        private void dgvSucursales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmNuevaSolicitud_Load(object sender, EventArgs e)
        {
            dgvSucursales.DataSource = clsSucursal.seleccionarSucursales();
            dgvSucursales.Columns[3].Visible = false;
            dgvSucursales.Columns[5].Visible = false;


            dgvIngredientes.DataSource = clsIngrediente.seleccionarIngredientes();
            dgvIngredientes.Columns["Categoria"].Visible = false;
            dgvIngredientes.Columns["StockCritico"].Visible = false;
            dgvIngredientes.Columns["Unidad"].Visible = false;
            dgvIngredientes.Columns["Costo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIngredientes.Columns["Costo"].DefaultCellStyle.Format = "c";
            dgvSeleccion.Columns.Add("IdIngrediente", "IdIngrediente");
            dgvSeleccion.Columns["IdIngrediente"].Visible = false;

            dgvSeleccion.Columns.Add("Nombre", "Nombre");
            dgvSeleccion.Columns.Add("Cantidad", "Cantidad");
            dgvSeleccion.Columns.Add("Costo Total", "Costo Total");


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = dgvIngredientes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                int IdIngrediente = Convert.ToInt32(dgvIngredientes.SelectedRows[0].Cells["IdIngrediente"].Value);
                double costoxKg = Convert.ToDouble(dgvIngredientes.SelectedRows[0].Cells["Costo"].Value.ToString());
                double cantidadGramos = Convert.ToDouble(this.tbCantidad.Text);
                string gramosString;
                double valor;
                if (cantidadGramos >= 500) { valor = costoxKg * (cantidadGramos / 1000); gramosString = (cantidadGramos / 1000).ToString() + " Kg"; }
                else { valor = costoxKg * cantidadGramos; gramosString = cantidadGramos.ToString() + " Unidades"; }

                string[] nuevaRow = new string[] { IdIngrediente.ToString(), nombre, gramosString, valor.ToString("C", CultureInfo.CurrentCulture) };



                dgvSeleccion.Rows.Add(nuevaRow);

                tbCantidad.Clear();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }


        }

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSeleccion.Rows.Remove(dgvSeleccion.SelectedRows[0]);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string detalle = "";
            double precioTotal = 0;
            try
            {

                detalle = "Solicitar a: " + dgvSucursales.SelectedRows[0].Cells["direccion"].Value.ToString() + "\n \n";
                precioTotal = 0;
                foreach (DataGridViewRow r in dgvSeleccion.Rows)
                {
                    detalle += r.Cells["Nombre"].Value.ToString() + " " + r.Cells["Cantidad"].Value.ToString() + "\n";
                    precioTotal += borrarSigno(r.Cells["Costo Total"].Value.ToString());
                }
                detalle += "\nPrecio Total : $" + precioTotal;
            }
            catch (Exception ex)
            {
                detalle = "Desea confirmar envio de solicitud?";
                Console.WriteLine(ex.Message);
            }

            DialogResult dialogResult = MessageBox.Show(detalle, "Confirmar Accion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int IdPara = Convert.ToInt32(dgvSucursales.SelectedRows[0].Cells["IdSucursal"].Value);
                int nuevaSolicitudId = clsSolicitud.nuevaSolicitud(clsConexion.SucursalSession, IdPara, precioTotal);
                try
                {
                    foreach (DataGridViewRow r in dgvSeleccion.Rows)
                    {
                        String[] unidad = r.Cells["Cantidad"].Value.ToString().Split(' ');

                        double cantidad = Convert.ToDouble(unidad[0]);
                        if (unidad[1] == "Kg") { cantidad *= 1000; }

                        clsSolicitud.nuevoDetalleSolicitud(nuevaSolicitudId, Convert.ToInt32(r.Cells["IdIngrediente"].Value), cantidad);
                    }
                    dgvSeleccion.Rows.Clear();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }

        private double borrarSigno(string cadena)
        {
            double valor = Convert.ToDouble(cadena.Split('$')[1]);

            return valor;
        }

        private void tbBusquedaIngrediente_TextChanged(object sender, EventArgs e)
        {
            //NombreProducto
            DataTable dt = (DataTable)dgvIngredientes.DataSource;
            dt.DefaultView.RowFilter = string.Format("Nombre like '%{0}%'", tbBusquedaIngrediente.Text);
            dgvIngredientes.Refresh();
        }

        private void tbBusquedaSucursal_TextChanged(object sender, EventArgs e)
        {
            //Direccion
            DataTable dt = (DataTable)dgvSucursales.DataSource;
            dt.DefaultView.RowFilter = string.Format("Direccion like '%{0}%'", tbBusquedaSucursal.Text);
            dgvSucursales.Refresh();
        }

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
