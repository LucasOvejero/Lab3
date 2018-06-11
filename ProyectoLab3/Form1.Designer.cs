namespace ProyectoLab3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSolicitudes = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnNewSolicitudes = new System.Windows.Forms.Button();
            this.pnlVendedor = new System.Windows.Forms.Panel();
            this.gbVentas = new System.Windows.Forms.GroupBox();
            this.gbDeposito = new System.Windows.Forms.GroupBox();
            this.gbSucursal = new System.Windows.Forms.GroupBox();
            this.btnGraficosVentaGeneral = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnSuc = new System.Windows.Forms.Button();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.btnDepositos = new System.Windows.Forms.Button();
            this.btnBebidas = new System.Windows.Forms.Button();
            this.gbPlatos = new System.Windows.Forms.GroupBox();
            this.btnEditPlato = new System.Windows.Forms.Button();
            this.btnPlato = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.pnlVendedor.SuspendLayout();
            this.gbVentas.SuspendLayout();
            this.gbDeposito.SuspendLayout();
            this.gbSucursal.SuspendLayout();
            this.gbProductos.SuspendLayout();
            this.gbPlatos.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.Location = new System.Drawing.Point(106, 27);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(75, 42);
            this.btnSolicitudes.TabIndex = 9;
            this.btnSolicitudes.Text = "Administrar \r\nSolicitudes";
            this.btnSolicitudes.UseVisualStyleBackColor = true;
            this.btnSolicitudes.Click += new System.EventHandler(this.btnSolicitudes_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(12, 27);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(75, 42);
            this.btnDeposito.TabIndex = 8;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(87, 27);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(75, 42);
            this.btnVenta.TabIndex = 11;
            this.btnVenta.Text = "Vender";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(218, 27);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(75, 42);
            this.btnVentas.TabIndex = 12;
            this.btnVentas.Text = "Graficos Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnNewSolicitudes
            // 
            this.btnNewSolicitudes.Location = new System.Drawing.Point(200, 27);
            this.btnNewSolicitudes.Name = "btnNewSolicitudes";
            this.btnNewSolicitudes.Size = new System.Drawing.Size(75, 42);
            this.btnNewSolicitudes.TabIndex = 10;
            this.btnNewSolicitudes.Text = "Nueva Solicitud";
            this.btnNewSolicitudes.UseVisualStyleBackColor = true;
            this.btnNewSolicitudes.Click += new System.EventHandler(this.btnNewSolicitudes_Click);
            // 
            // pnlVendedor
            // 
            this.pnlVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVendedor.Controls.Add(this.gbVentas);
            this.pnlVendedor.Controls.Add(this.gbDeposito);
            this.pnlVendedor.Location = new System.Drawing.Point(1, 115);
            this.pnlVendedor.Name = "pnlVendedor";
            this.pnlVendedor.Size = new System.Drawing.Size(1217, 192);
            this.pnlVendedor.TabIndex = 12;
            // 
            // gbVentas
            // 
            this.gbVentas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.gbVentas.Controls.Add(this.btnVentas);
            this.gbVentas.Controls.Add(this.btnVenta);
            this.gbVentas.Location = new System.Drawing.Point(410, 39);
            this.gbVentas.Name = "gbVentas";
            this.gbVentas.Size = new System.Drawing.Size(381, 97);
            this.gbVentas.TabIndex = 12;
            this.gbVentas.TabStop = false;
            this.gbVentas.Text = "Ventas";
            // 
            // gbDeposito
            // 
            this.gbDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            this.gbDeposito.Controls.Add(this.btnDeposito);
            this.gbDeposito.Controls.Add(this.btnHistorial);
            this.gbDeposito.Controls.Add(this.btnNewSolicitudes);
            this.gbDeposito.Controls.Add(this.btnSolicitudes);
            this.gbDeposito.Location = new System.Drawing.Point(11, 39);
            this.gbDeposito.Name = "gbDeposito";
            this.gbDeposito.Size = new System.Drawing.Size(381, 97);
            this.gbDeposito.TabIndex = 11;
            this.gbDeposito.TabStop = false;
            this.gbDeposito.Text = "Deposito";
            // 
            // gbSucursal
            // 
            this.gbSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.gbSucursal.Controls.Add(this.btnGraficosVentaGeneral);
            this.gbSucursal.Controls.Add(this.btnEmpleados);
            this.gbSucursal.Controls.Add(this.btnSuc);
            this.gbSucursal.Location = new System.Drawing.Point(12, 7);
            this.gbSucursal.Name = "gbSucursal";
            this.gbSucursal.Size = new System.Drawing.Size(381, 97);
            this.gbSucursal.TabIndex = 8;
            this.gbSucursal.TabStop = false;
            this.gbSucursal.Text = "Sucursales";
            // 
            // btnGraficosVentaGeneral
            // 
            this.btnGraficosVentaGeneral.Location = new System.Drawing.Point(266, 27);
            this.btnGraficosVentaGeneral.Name = "btnGraficosVentaGeneral";
            this.btnGraficosVentaGeneral.Size = new System.Drawing.Size(75, 42);
            this.btnGraficosVentaGeneral.TabIndex = 3;
            this.btnGraficosVentaGeneral.Text = "Graficos Ventas";
            this.btnGraficosVentaGeneral.UseVisualStyleBackColor = true;
            this.btnGraficosVentaGeneral.Click += new System.EventHandler(this.btnGraficosVentaGeneral_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(148, 27);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(75, 42);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnSuc
            // 
            this.btnSuc.Location = new System.Drawing.Point(40, 27);
            this.btnSuc.Name = "btnSuc";
            this.btnSuc.Size = new System.Drawing.Size(75, 42);
            this.btnSuc.TabIndex = 1;
            this.btnSuc.Text = "Sucursales";
            this.btnSuc.UseVisualStyleBackColor = true;
            this.btnSuc.Click += new System.EventHandler(this.btnSuc_Click);
            // 
            // gbProductos
            // 
            this.gbProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.gbProductos.Controls.Add(this.btnDepositos);
            this.gbProductos.Controls.Add(this.btnBebidas);
            this.gbProductos.Location = new System.Drawing.Point(411, 7);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(381, 97);
            this.gbProductos.TabIndex = 9;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos";
            // 
            // btnDepositos
            // 
            this.btnDepositos.Location = new System.Drawing.Point(84, 27);
            this.btnDepositos.Name = "btnDepositos";
            this.btnDepositos.Size = new System.Drawing.Size(75, 42);
            this.btnDepositos.TabIndex = 4;
            this.btnDepositos.Text = "Depositos";
            this.btnDepositos.UseVisualStyleBackColor = true;
            this.btnDepositos.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // btnBebidas
            // 
            this.btnBebidas.Location = new System.Drawing.Point(221, 27);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(75, 42);
            this.btnBebidas.TabIndex = 5;
            this.btnBebidas.Text = "Productos";
            this.btnBebidas.UseVisualStyleBackColor = true;
            this.btnBebidas.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // gbPlatos
            // 
            this.gbPlatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPlatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.gbPlatos.Controls.Add(this.btnEditPlato);
            this.gbPlatos.Controls.Add(this.btnPlato);
            this.gbPlatos.Location = new System.Drawing.Point(824, 7);
            this.gbPlatos.Name = "gbPlatos";
            this.gbPlatos.Size = new System.Drawing.Size(381, 97);
            this.gbPlatos.TabIndex = 10;
            this.gbPlatos.TabStop = false;
            this.gbPlatos.Text = "Platos";
            // 
            // btnEditPlato
            // 
            this.btnEditPlato.Location = new System.Drawing.Point(210, 27);
            this.btnEditPlato.Name = "btnEditPlato";
            this.btnEditPlato.Size = new System.Drawing.Size(75, 42);
            this.btnEditPlato.TabIndex = 7;
            this.btnEditPlato.Text = "Ver Platos";
            this.btnEditPlato.UseVisualStyleBackColor = true;
            this.btnEditPlato.Click += new System.EventHandler(this.btnEditPlato_Click);
            // 
            // btnPlato
            // 
            this.btnPlato.Location = new System.Drawing.Point(96, 27);
            this.btnPlato.Name = "btnPlato";
            this.btnPlato.Size = new System.Drawing.Size(75, 42);
            this.btnPlato.TabIndex = 6;
            this.btnPlato.Text = "Agregar Platos";
            this.btnPlato.UseVisualStyleBackColor = true;
            this.btnPlato.Click += new System.EventHandler(this.btnPlato_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.gbPlatos);
            this.pnlAdmin.Controls.Add(this.gbProductos);
            this.pnlAdmin.Controls.Add(this.gbSucursal);
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(1219, 110);
            this.pnlAdmin.TabIndex = 11;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(294, 27);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(75, 42);
            this.btnHistorial.TabIndex = 10;
            this.btnHistorial.Text = "Historial de Solicitudes";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1219, 725);
            this.Controls.Add(this.pnlVendedor);
            this.Controls.Add(this.pnlAdmin);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.pnlVendedor.ResumeLayout(false);
            this.gbVentas.ResumeLayout(false);
            this.gbDeposito.ResumeLayout(false);
            this.gbSucursal.ResumeLayout(false);
            this.gbProductos.ResumeLayout(false);
            this.gbPlatos.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSolicitudes;
        private System.Windows.Forms.Button btnPlatos;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnNewSolicitudes;
        private System.Windows.Forms.Panel pnlVendedor;
        private System.Windows.Forms.GroupBox gbVentas;
        private System.Windows.Forms.GroupBox gbDeposito;
        private System.Windows.Forms.GroupBox gbSucursal;
        private System.Windows.Forms.Button btnGraficosVentaGeneral;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnSuc;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Button btnDepositos;
        private System.Windows.Forms.Button btnBebidas;
        private System.Windows.Forms.GroupBox gbPlatos;
        private System.Windows.Forms.Button btnEditPlato;
        private System.Windows.Forms.Button btnPlato;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Button btnHistorial;
    }
}

