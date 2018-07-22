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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSolicitudes = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnNewSolicitudes = new System.Windows.Forms.Button();
            this.pnlVendedor = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlCritico = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCritico = new Componentes.GrillaFormatead();
            this.label1 = new System.Windows.Forms.Label();
            this.gbVentas = new System.Windows.Forms.GroupBox();
            this.gbDeposito = new System.Windows.Forms.GroupBox();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.gbSucursal = new System.Windows.Forms.GroupBox();
            this.btnGraficosVentaGeneral = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnSuc = new System.Windows.Forms.Button();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.btnMerma = new System.Windows.Forms.Button();
            this.btnDepositos = new System.Windows.Forms.Button();
            this.btnBebidas = new System.Windows.Forms.Button();
            this.gbPlatos = new System.Windows.Forms.GroupBox();
            this.btnEditPlato = new System.Windows.Forms.Button();
            this.btnPlato = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.btnGraficosPorEmp = new System.Windows.Forms.Button();
            this.btnCUIT = new System.Windows.Forms.Button();
            this.lblSucursalInfo = new System.Windows.Forms.Label();
            this.pnlVendedor.SuspendLayout();
            this.pnlCritico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCritico)).BeginInit();
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
            this.btnSolicitudes.Location = new System.Drawing.Point(95, 27);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(75, 42);
            this.btnSolicitudes.TabIndex = 1;
            this.btnSolicitudes.Text = "Administrar \r\nSolicitudes";
            this.btnSolicitudes.UseVisualStyleBackColor = true;
            this.btnSolicitudes.Click += new System.EventHandler(this.BtnSolicitudes_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(12, 27);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(75, 42);
            this.btnDeposito.TabIndex = 0;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.BtnDeposito_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(68, 27);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(75, 42);
            this.btnVenta.TabIndex = 0;
            this.btnVenta.Text = "Vender";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.BtnVenta_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(199, 27);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(75, 42);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Graficos Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // btnNewSolicitudes
            // 
            this.btnNewSolicitudes.Location = new System.Drawing.Point(178, 27);
            this.btnNewSolicitudes.Name = "btnNewSolicitudes";
            this.btnNewSolicitudes.Size = new System.Drawing.Size(75, 42);
            this.btnNewSolicitudes.TabIndex = 2;
            this.btnNewSolicitudes.Text = "Nueva Solicitud";
            this.btnNewSolicitudes.UseVisualStyleBackColor = true;
            this.btnNewSolicitudes.Click += new System.EventHandler(this.BtnNewSolicitudes_Click);
            // 
            // pnlVendedor
            // 
            this.pnlVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVendedor.Controls.Add(this.btnLogout);
            this.pnlVendedor.Controls.Add(this.pnlCritico);
            this.pnlVendedor.Controls.Add(this.label1);
            this.pnlVendedor.Controls.Add(this.gbVentas);
            this.pnlVendedor.Controls.Add(this.gbDeposito);
            this.pnlVendedor.Location = new System.Drawing.Point(0, 150);
            this.pnlVendedor.Name = "pnlVendedor";
            this.pnlVendedor.Size = new System.Drawing.Size(782, 493);
            this.pnlVendedor.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLogout.Location = new System.Drawing.Point(572, 465);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(89, 37);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlCritico
            // 
            this.pnlCritico.Controls.Add(this.label2);
            this.pnlCritico.Controls.Add(this.dgvCritico);
            this.pnlCritico.Location = new System.Drawing.Point(11, 157);
            this.pnlCritico.Name = "pnlCritico";
            this.pnlCritico.Size = new System.Drawing.Size(412, 345);
            this.pnlCritico.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(24, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Atencion, los siguientes productos estan en stock critico:\r\n";
            // 
            // dgvCritico
            // 
            this.dgvCritico.AllowUserToAddRows = false;
            this.dgvCritico.AllowUserToResizeColumns = false;
            this.dgvCritico.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCritico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCritico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCritico.Location = new System.Drawing.Point(27, 42);
            this.dgvCritico.MultiSelect = false;
            this.dgvCritico.Name = "dgvCritico";
            this.dgvCritico.ReadOnly = true;
            this.dgvCritico.RowHeadersVisible = false;
            this.dgvCritico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCritico.Size = new System.Drawing.Size(342, 300);
            this.dgvCritico.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sin Ningun Stock en cantidad Critica.";
            // 
            // gbVentas
            // 
            this.gbVentas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.gbVentas.Controls.Add(this.btnVentas);
            this.gbVentas.Controls.Add(this.btnVenta);
            this.gbVentas.Location = new System.Drawing.Point(232, 39);
            this.gbVentas.Name = "gbVentas";
            this.gbVentas.Size = new System.Drawing.Size(342, 97);
            this.gbVentas.TabIndex = 1;
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
            this.gbDeposito.Size = new System.Drawing.Size(357, 97);
            this.gbDeposito.TabIndex = 0;
            this.gbDeposito.TabStop = false;
            this.gbDeposito.Text = "Deposito";
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(261, 27);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(88, 42);
            this.btnHistorial.TabIndex = 3;
            this.btnHistorial.Text = "Historial de Solicitudes";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.BtnHistorial_Click);
            // 
            // gbSucursal
            // 
            this.gbSucursal.AutoSize = true;
            this.gbSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.gbSucursal.Controls.Add(this.btnGraficosVentaGeneral);
            this.gbSucursal.Controls.Add(this.btnEmpleados);
            this.gbSucursal.Controls.Add(this.btnSuc);
            this.gbSucursal.Location = new System.Drawing.Point(12, 44);
            this.gbSucursal.Name = "gbSucursal";
            this.gbSucursal.Size = new System.Drawing.Size(357, 97);
            this.gbSucursal.TabIndex = 0;
            this.gbSucursal.TabStop = false;
            this.gbSucursal.Text = "Sucursales";
            // 
            // btnGraficosVentaGeneral
            // 
            this.btnGraficosVentaGeneral.Location = new System.Drawing.Point(143, 27);
            this.btnGraficosVentaGeneral.Name = "btnGraficosVentaGeneral";
            this.btnGraficosVentaGeneral.Size = new System.Drawing.Size(75, 42);
            this.btnGraficosVentaGeneral.TabIndex = 1;
            this.btnGraficosVentaGeneral.Text = "Graficos Ventas";
            this.btnGraficosVentaGeneral.UseVisualStyleBackColor = true;
            this.btnGraficosVentaGeneral.Click += new System.EventHandler(this.BtnGraficosVentaGeneral_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.AutoSize = true;
            this.btnEmpleados.Location = new System.Drawing.Point(252, 27);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(75, 42);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // btnSuc
            // 
            this.btnSuc.Location = new System.Drawing.Point(30, 27);
            this.btnSuc.Name = "btnSuc";
            this.btnSuc.Size = new System.Drawing.Size(75, 42);
            this.btnSuc.TabIndex = 0;
            this.btnSuc.Text = "Sucursales";
            this.btnSuc.UseVisualStyleBackColor = true;
            this.btnSuc.Click += new System.EventHandler(this.BtnSuc_Click);
            // 
            // gbProductos
            // 
            this.gbProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.gbProductos.Controls.Add(this.btnMerma);
            this.gbProductos.Controls.Add(this.btnDepositos);
            this.gbProductos.Controls.Add(this.btnBebidas);
            this.gbProductos.Location = new System.Drawing.Point(232, 44);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(342, 97);
            this.gbProductos.TabIndex = 1;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos";
            // 
            // btnMerma
            // 
            this.btnMerma.Location = new System.Drawing.Point(237, 27);
            this.btnMerma.Name = "btnMerma";
            this.btnMerma.Size = new System.Drawing.Size(75, 42);
            this.btnMerma.TabIndex = 2;
            this.btnMerma.Text = "Merma";
            this.btnMerma.UseVisualStyleBackColor = true;
            this.btnMerma.Click += new System.EventHandler(this.btnMerma_Click);
            // 
            // btnDepositos
            // 
            this.btnDepositos.Location = new System.Drawing.Point(31, 27);
            this.btnDepositos.Name = "btnDepositos";
            this.btnDepositos.Size = new System.Drawing.Size(75, 42);
            this.btnDepositos.TabIndex = 0;
            this.btnDepositos.Text = "Depositos";
            this.btnDepositos.UseVisualStyleBackColor = true;
            this.btnDepositos.Click += new System.EventHandler(this.BtnIngredientes_Click);
            // 
            // btnBebidas
            // 
            this.btnBebidas.Location = new System.Drawing.Point(131, 27);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(75, 42);
            this.btnBebidas.TabIndex = 1;
            this.btnBebidas.Text = "Productos";
            this.btnBebidas.UseVisualStyleBackColor = true;
            this.btnBebidas.Click += new System.EventHandler(this.BtnBebidas_Click);
            // 
            // gbPlatos
            // 
            this.gbPlatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPlatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.gbPlatos.Controls.Add(this.btnEditPlato);
            this.gbPlatos.Controls.Add(this.btnPlato);
            this.gbPlatos.Location = new System.Drawing.Point(464, 44);
            this.gbPlatos.Name = "gbPlatos";
            this.gbPlatos.Size = new System.Drawing.Size(308, 97);
            this.gbPlatos.TabIndex = 2;
            this.gbPlatos.TabStop = false;
            this.gbPlatos.Text = "Platos";
            // 
            // btnEditPlato
            // 
            this.btnEditPlato.Location = new System.Drawing.Point(174, 27);
            this.btnEditPlato.Name = "btnEditPlato";
            this.btnEditPlato.Size = new System.Drawing.Size(75, 42);
            this.btnEditPlato.TabIndex = 1;
            this.btnEditPlato.Text = "Ver Platos";
            this.btnEditPlato.UseVisualStyleBackColor = true;
            this.btnEditPlato.Click += new System.EventHandler(this.BtnEditPlato_Click);
            // 
            // btnPlato
            // 
            this.btnPlato.Location = new System.Drawing.Point(60, 27);
            this.btnPlato.Name = "btnPlato";
            this.btnPlato.Size = new System.Drawing.Size(75, 42);
            this.btnPlato.TabIndex = 0;
            this.btnPlato.Text = "Agregar Platos";
            this.btnPlato.UseVisualStyleBackColor = true;
            this.btnPlato.Click += new System.EventHandler(this.BtnPlato_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.btnGraficosPorEmp);
            this.pnlAdmin.Controls.Add(this.btnCUIT);
            this.pnlAdmin.Controls.Add(this.lblSucursalInfo);
            this.pnlAdmin.Controls.Add(this.gbPlatos);
            this.pnlAdmin.Controls.Add(this.gbProductos);
            this.pnlAdmin.Controls.Add(this.gbSucursal);
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(784, 144);
            this.pnlAdmin.TabIndex = 0;
            // 
            // btnGraficosPorEmp
            // 
            this.btnGraficosPorEmp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGraficosPorEmp.Location = new System.Drawing.Point(511, 3);
            this.btnGraficosPorEmp.Name = "btnGraficosPorEmp";
            this.btnGraficosPorEmp.Size = new System.Drawing.Size(75, 42);
            this.btnGraficosPorEmp.TabIndex = 5;
            this.btnGraficosPorEmp.Text = "Graficos Empleados";
            this.btnGraficosPorEmp.UseVisualStyleBackColor = true;
            this.btnGraficosPorEmp.Click += new System.EventHandler(this.btnGraficosPorEmp_Click);
            // 
            // btnCUIT
            // 
            this.btnCUIT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCUIT.Location = new System.Drawing.Point(348, 12);
            this.btnCUIT.Name = "btnCUIT";
            this.btnCUIT.Size = new System.Drawing.Size(75, 23);
            this.btnCUIT.TabIndex = 4;
            this.btnCUIT.Text = "CUIT";
            this.btnCUIT.UseVisualStyleBackColor = true;
            this.btnCUIT.Click += new System.EventHandler(this.btnCUIT_Click);
            // 
            // lblSucursalInfo
            // 
            this.lblSucursalInfo.AutoSize = true;
            this.lblSucursalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursalInfo.Location = new System.Drawing.Point(13, 13);
            this.lblSucursalInfo.Name = "lblSucursalInfo";
            this.lblSucursalInfo.Size = new System.Drawing.Size(15, 24);
            this.lblSucursalInfo.TabIndex = 3;
            this.lblSucursalInfo.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlVendedor);
            this.Controls.Add(this.pnlAdmin);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.pnlVendedor.ResumeLayout(false);
            this.pnlVendedor.PerformLayout();
            this.pnlCritico.ResumeLayout(false);
            this.pnlCritico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCritico)).EndInit();
            this.gbVentas.ResumeLayout(false);
            this.gbDeposito.ResumeLayout(false);
            this.gbSucursal.ResumeLayout(false);
            this.gbSucursal.PerformLayout();
            this.gbProductos.ResumeLayout(false);
            this.gbPlatos.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
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
        private System.Windows.Forms.Panel pnlCritico;
        private Componentes.GrillaFormatead dgvCritico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMerma;
        private System.Windows.Forms.Label lblSucursalInfo;
        private System.Windows.Forms.Button btnCUIT;
        private System.Windows.Forms.Button btnGraficosPorEmp;
    }
}

