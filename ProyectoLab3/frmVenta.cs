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
using Componentes;
namespace ProyectoLab3
{
    public partial class frmVenta : Form
    {
        int idSucursal,nroVenta;
        DataTable platos,bebidas;
        List<PanelPlato> listaProductosVenta;
        int x = 20, y = 20;
        int yvar = 80;
        decimal total = 0;
        
        public frmVenta(int idSucursal)
        {
            InitializeComponent();
            this.idSucursal = idSucursal;
            listaProductosVenta = new List<PanelPlato>();
            nroVenta = clsVenta.numeroVenta();
        }
        
        private void frmVenta_Load(object sender, EventArgs e)
        {
            cargarPlatos();
            cargarBebidas();
            lblTotal.Text = total.ToString("c");
            nudPago.Minimum = total;
        }

        private void cargarBebidas() {
            bebidas = clsBebida.seleccionarBebidasxStock(this.idSucursal);
            dgvBebidas.DataSource = null;
            dgvBebidas.DataSource = bebidas;
            dgvBebidas.Columns["Precio"].DefaultCellStyle.Format = "c";
            dgvBebidas.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBebidas.Columns["Litros"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBebidas.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvBebidas.Columns["Alcohol"].Width = 50;
            dgvBebidas.Columns["Precio"].Width = 50;
            dgvBebidas.Columns["Litros"].Width = 50;
            dgvBebidas.Columns["Stock"].Width = 50;
            dgvBebidas.Columns["Costo"].Visible = false;
            dgvBebidas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            DataTable categoriaBebidas = clsBebida.getCategorias();
            DataRow todas = categoriaBebidas.NewRow();
            todas["Nombre"] = "Todas";
            categoriaBebidas.Rows.InsertAt(todas, 0);
            cboCategoriaBebida.DataSource = categoriaBebidas;
            cboCategoriaBebida.DisplayMember = "Nombre";
            

        }
        private void cargarPlatos() {
            platos = clsPlato.seleccionarPlatoxCategoria(idSucursal);
            dgvPlatos.DataSource = null;
            dgvPlatos.DataSource = platos;
            dgvPlatos.Columns["Suficiente"].Visible = false;
            dgvPlatos.Columns["Costo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
            dgvPlatos.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlatos.Columns["Posible Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlatos.Columns["Costo"].Visible = false;
            dgvPlatos.Columns["Costo"].DefaultCellStyle.Format = "c";
            dgvPlatos.Columns["Precio"].DefaultCellStyle.Format = "c";
            dgvPlatos.Columns["Precio"].Width = 50;
            dgvPlatos.Columns["Costo"].Width = 50;
            dgvPlatos.Columns["TACC"].Width = 50;
            

            DataTable categoriaPlatos = clsPlato.seleccionarCategorias();
            DataRow todas = categoriaPlatos.NewRow();
            todas["Nombre"] = "Todas";
            categoriaPlatos.Rows.InsertAt(todas, 0);
            cboCategoriaPlato.DataSource = categoriaPlatos;
            cboCategoriaPlato.DisplayMember = "Nombre";
        
        
        }
        private void dgvPlatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            foreach (DataGridViewRow r in dgvPlatos.Rows)
                {
                    if (r.Cells["Suficiente"].Value.ToString() != "True")
                    {
                        r.DefaultCellStyle.BackColor = Color.Red;
                        r.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            
        }
        private void dgvBebidas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
         
            foreach (DataGridViewRow r in dgvBebidas.Rows)
            {
                if ( r.Cells["Stock"].Value.ToString() == "0")
                {
                    r.DefaultCellStyle.BackColor = Color.Red;
                    r.DefaultCellStyle.ForeColor = Color.White;
                }
            }

        }

        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvPlatos.SelectedRows.Count > 0 ? dgvPlatos.SelectedRows[0] : null;
            if (fila != null) {
                string nombre=fila.Cells["Nombre"].Value.ToString();
                int id=int.Parse(fila.Cells["IdPlato"].Value.ToString());
                int maxCantidad = int.Parse(fila.Cells["Posible Cantidad"].Value.ToString());
                decimal costo = decimal.Parse(fila.Cells["Costo"].Value.ToString());
                decimal precio = decimal.Parse(fila.Cells["Precio"].Value.ToString());
                agregarOsumarPlato(id, nombre,maxCantidad,costo,precio);
               /* total += precio;
                lblTotal.Text = total.ToString("c");
                nudPago.Minimum = total;*/
            }
        }

        private void agregarOsumarPlato(int id,string nombre,int maxCantidad,decimal costo, decimal precio) {
            bool existe = false;
            foreach (PanelPlato p in listaProductosVenta)
            {
                if (p.Id == id && !p.EsBebida )
                { 
                    if(p.NudGramos.Value<maxCantidad)
                        p.NudGramos.Value = p.NudGramos.Value + 1;
                    existe = true;
                    break;
                }
            }
            if (!existe) //si no existe agregar
            {
                PanelPlato i = new PanelPlato(nombre, false, id);
                this.listaProductosVenta.Add(i);
                i.Location = new Point(x, y);
                i.Cerrar.Click += new EventHandler(Cerrar_Click);
                i.NudGramos.Maximum = maxCantidad;
                i.NudGramos.ValueChanged += nudproducto_ValueChanged;
                total += precio;
                lblTotal.Text = total.ToString("c");
                nudPago.Minimum = total;
                y += yvar;
                i.Costo = costo;
                i.Precio = precio;
                pnlDescripcion.Controls.Add(i);
            }
           
        }
        void Cerrar_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Parent as PanelPlato).Id;
            foreach (PanelPlato prod in listaProductosVenta)
            {
                if (prod.Id == id && !prod.EsBebida)
                {
                    total -= prod.Precio * prod.NudGramos.Value;
                    lblTotal.Text = total.ToString("c");
                    nudPago.Minimum = total;
                    listaProductosVenta.RemoveAt(listaProductosVenta.IndexOf(prod));
                    break;
                }
            }
            repintar();
        }
        private void repintar() {
            pnlDescripcion.Controls.Clear();
            y = 20;
            foreach (PanelPlato producto in listaProductosVenta) {
                producto.Location = new Point(x, y);
                y += yvar;
                pnlDescripcion.Controls.Add(producto);
            
            }
        
        }
        private void dgvPlatos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
                DataGridViewRow fila = dgvPlatos.Rows[e.RowIndex];//.Cells["Suficiente"].Value.ToString()
                if (fila != null)
                {
                    if (fila.Cells["Suficiente"].Value.ToString() != "True")
                    {
                        btnAgregarPlato.Enabled = false;
                        //MessageBox.Show("No hay ingredientes suficientes para preparar este plato", "Imposible seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //fila.Selected = false;
                    }
                    else {
                        btnAgregarPlato.Enabled = true;
                    }
                }
           
        }
       /* private bool controlarSiHaySuficiente(){
            bool retorno=true;
            DataGridViewRow fila = dgvPlatos.SelectedRows[0];//.Cells["Suficiente"].Value.ToString()
                if (fila != null)
                {
                    if (fila.Cells["Suficiente"].Value.ToString() != "True")
                    {
                        
                       // MessageBox.Show("No hay ingredientes suficientes para preparar este plato", "Imposible seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       // fila.Selected = false;
                        retorno=false;
                    }
                }
            return retorno;
        }*/
        private void tbNombreBebida_TextChanged(object sender, EventArgs e)
        {
            
                cambiarFiltro();
            
        }
    
        private void cambiarFiltro() {

            DataTable dt = (DataTable)dgvPlatos.DataSource;
            string nombre=tbNombrePlato.Text.Trim().Replace("'", "''");
            bool tacc= cbTACC.Checked;
            System.Data.DataRowView cat = (System.Data.DataRowView)cboCategoriaPlato.SelectedValue;
            string categoria=cat["Nombre"].ToString();
            if ( categoria== "Todas" || categoria == "")
                categoria = "NOT LIKE 'Todas'";
            else
                categoria = string.Format("like '{0}'",categoria);
            dt.DefaultView.RowFilter = string.Format("Nombre like '%{0}%' AND TACC= '{1}' AND Categoria {2} ",nombre,tacc,categoria );
            dgvPlatos.Refresh();
            

            
        }

        private void dgvBebidas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvBebidas.Rows[e.RowIndex];//.Cells["Suficiente"].Value.ToString()
            if (fila != null)
            {
                if (fila.Cells["Stock"].Value.ToString() == "0")
                {
                    
                    btnAgregarBebida.Enabled = false;
                }
                else
                {
                    btnAgregarBebida.Enabled = true;
                }
            }
        }

        private void btnAgregarBebida_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvBebidas.SelectedRows.Count > 0 ? dgvBebidas.SelectedRows[0] : null;
            if (fila != null)
            {
                string nombre = fila.Cells["Nombre"].Value.ToString();
                int id = int.Parse(fila.Cells["IdBebida"].Value.ToString());
                int maxCantidad = int.Parse(fila.Cells["Stock"].Value.ToString());
                decimal precio = decimal.Parse(fila.Cells["Precio"].Value.ToString());
                decimal costo = decimal.Parse(fila.Cells["Costo"].Value.ToString());
                agregarOsumarBebida(id, nombre, maxCantidad,precio,costo);
                /*total += precio;
                lblTotal.Text = total.ToString("c");
                nudPago.Minimum = total;*/
            }
        }

        private void agregarOsumarBebida(int id, string nombre, int maxCantidad,decimal precio,decimal costo)
        {
            bool existe = false;
            foreach (PanelPlato p in listaProductosVenta)
            {
                if (p.Id == id && p.EsBebida)
                {
                    if(p.NudGramos.Value < maxCantidad)
                         p.NudGramos.Value = p.NudGramos.Value + 1;
                    existe = true;
                    break;
                }
            }
            if (!existe) //si no existe agregar
            {
                PanelPlato i = new PanelPlato(nombre, true, id);
                this.listaProductosVenta.Add(i);
                i.Location = new Point(x, y);
                i.Cerrar.Click += new EventHandler(CerrarBebida_Click);
                i.NudGramos.Maximum = maxCantidad;
                i.NudGramos.ValueChanged += nudproducto_ValueChanged;
                total += precio;
                lblTotal.Text = total.ToString("c");
                nudPago.Minimum = total;
                i.Precio = precio;
                i.Costo = costo;
                y += yvar;
                
                pnlDescripcion.Controls.Add(i);
            }
        }

        void CerrarBebida_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Parent as PanelPlato).Id;
            foreach (PanelPlato prod in listaProductosVenta)
            {
                if (prod.Id == id && prod.EsBebida)
                {
                    total -= prod.Precio * prod.NudGramos.Value;
                    lblTotal.Text = total.ToString("c");
                    nudPago.Minimum = total;
                    listaProductosVenta.RemoveAt(listaProductosVenta.IndexOf(prod));
                    break;
                }
            }
            repintar();
        }

        private void tbNombreBebida_TextChanged_1(object sender, EventArgs e)
        {
            cambiarFiltroBebida();
        }

        private void cambiarFiltroBebida() {
            DataTable dt = (DataTable)dgvBebidas.DataSource;

            string nombre = tbNombreBebida.Text.Trim().Replace("'", "''");
            //bool tacc = cbAlcohol.Checked;

            System.Data.DataRowView cat = (System.Data.DataRowView)cboCategoriaBebida.SelectedValue;
            string categoria = cat["Nombre"].ToString();
            if (categoria == "Todas" || categoria == "")
                categoria = "NOT LIKE 'Todas'";
            else
                categoria = string.Format("like '{0}'", categoria);
            dt.DefaultView.RowFilter = string.Format("Nombre like '%{0}%' AND Categoria {1} ", nombre, categoria);
            dgvBebidas.Refresh();
        
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            List<Producto> listaProductos;
            if (this.listaProductosVenta.Count > 0)
            {
                string resp = clsVenta.vender(this.listaProductosVenta, this.idSucursal, int.Parse(clsConexion.IdEmpleado),out listaProductos);
                if (resp != "")
                {
                    MessageBox.Show(resp, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    TicketVenta ticket = new TicketVenta();
                    ticket.SetDataSource(listaProductos);
                    ticket.SetParameterValue("Pago",nudPago.Value);
                    ticket.SetParameterValue("IdSucursal", this.idSucursal.ToString());
                    ticket.SetParameterValue("NumeroVenta", this.nroVenta.ToString());
                    ticket.SetParameterValue("NombreSucursal", clsConexion.NombreSucursal);
                    ticket.SetParameterValue("CUIT", "20-3434343-0");
                    frmTicketVenta frmTicket = new frmTicketVenta(ticket);
                    frmTicket.ShowDialog();
                    limpiar();
                }
            }
            else {
                MessageBox.Show("No sea han seleccionado productos para vender", "Error", MessageBoxButtons.OK);

            }

        }


        private void nudproducto_ValueChanged(object sender, EventArgs e)
        {
            decimal precio = ((sender as NumericUpDown).Parent as PanelPlato).Precio;
            decimal antes = decimal.Parse((sender as Control).Text);
            decimal despues = (sender as NumericUpDown).Value;
            decimal aux = (precio * despues)-(precio * antes);
            total += aux;
            lblTotal.Text = total.ToString("c");
            nudPago.Minimum = total;
        }

        private void limpiar() {
            this.pnlDescripcion.Controls.Clear();
            this.listaProductosVenta.Clear();
            total = 0;
            nudPago.Minimum = total;
            nudPago.Value = 0;
            cargarPlatos();
            cargarBebidas();
            lblTotal.Text = total.ToString("c");
            nudPago.Minimum = total;
            y = 20;
            nroVenta = clsVenta.numeroVenta();
        }


    }
}
