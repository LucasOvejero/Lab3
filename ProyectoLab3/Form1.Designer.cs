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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSolicitudes = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnNewSolicitudes = new System.Windows.Forms.Button();
            this.pnlVendedor = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlCritico = new System.Windows.Forms.Panel();
            this.dgvCritico = new Componentes.GrillaFormatead();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSucursalInfo = new System.Windows.Forms.Label();
            this.gbVentas = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDeposito = new System.Windows.Forms.GroupBox();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.gbSucursal = new System.Windows.Forms.GroupBox();
            this.btnSuc = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnGraficosVentaGeneral = new System.Windows.Forms.Button();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.btnBebidas = new System.Windows.Forms.Button();
            this.btnDepositos = new System.Windows.Forms.Button();
            this.btnMerma = new System.Windows.Forms.Button();
            this.btnCUIT = new System.Windows.Forms.Button();
            this.gbPlatos = new System.Windows.Forms.GroupBox();
            this.btnPlato = new System.Windows.Forms.Button();
            this.btnEditPlato = new System.Windows.Forms.Button();
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.Administracion = new System.Windows.Forms.TabPage();
            this.Sucursal = new System.Windows.Forms.TabPage();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.pnlVendedor.SuspendLayout();
            this.pnlCritico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCritico)).BeginInit();
            this.gbVentas.SuspendLayout();
            this.gbDeposito.SuspendLayout();
            this.gbSucursal.SuspendLayout();
            this.gbProductos.SuspendLayout();
            this.gbPlatos.SuspendLayout();
            this.tcPrincipal.SuspendLayout();
            this.Administracion.SuspendLayout();
            this.Sucursal.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.Location = new System.Drawing.Point(225, 25);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(117, 55);
            this.btnSolicitudes.TabIndex = 1;
            this.btnSolicitudes.Text = "Administrar \r\nSolicitudes";
            this.btnSolicitudes.UseVisualStyleBackColor = true;
            this.btnSolicitudes.Click += new System.EventHandler(this.BtnSolicitudes_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(72, 25);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(113, 55);
            this.btnDeposito.TabIndex = 0;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.BtnDeposito_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(177, 21);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(155, 53);
            this.btnVenta.TabIndex = 0;
            this.btnVenta.Text = "Vender";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.BtnVenta_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(397, 21);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(159, 53);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Graficos Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // btnNewSolicitudes
            // 
            this.btnNewSolicitudes.Location = new System.Drawing.Point(382, 25);
            this.btnNewSolicitudes.Name = "btnNewSolicitudes";
            this.btnNewSolicitudes.Size = new System.Drawing.Size(119, 55);
            this.btnNewSolicitudes.TabIndex = 2;
            this.btnNewSolicitudes.Text = "Nueva Solicitud";
            this.btnNewSolicitudes.UseVisualStyleBackColor = true;
            this.btnNewSolicitudes.Click += new System.EventHandler(this.BtnNewSolicitudes_Click);
            // 
            // pnlVendedor
            // 
            this.pnlVendedor.BackColor = System.Drawing.SystemColors.Control;
            this.pnlVendedor.Controls.Add(this.btnLogout);
            this.pnlVendedor.Controls.Add(this.pnlCritico);
            this.pnlVendedor.Controls.Add(this.label1);
            this.pnlVendedor.Controls.Add(this.lblSucursalInfo);
            this.pnlVendedor.Controls.Add(this.gbVentas);
            this.pnlVendedor.Controls.Add(this.gbDeposito);
            this.pnlVendedor.Location = new System.Drawing.Point(6, 6);
            this.pnlVendedor.Name = "pnlVendedor";
            this.pnlVendedor.Size = new System.Drawing.Size(762, 561);
            this.pnlVendedor.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLogout.Location = new System.Drawing.Point(650, 19);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(89, 37);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlCritico
            // 
            this.pnlCritico.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlCritico.Controls.Add(this.dgvCritico);
            this.pnlCritico.Controls.Add(this.label2);
            this.pnlCritico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCritico.Location = new System.Drawing.Point(182, 256);
            this.pnlCritico.Name = "pnlCritico";
            this.pnlCritico.Size = new System.Drawing.Size(398, 289);
            this.pnlCritico.TabIndex = 0;
            // 
            // dgvCritico
            // 
            this.dgvCritico.AllowUserToAddRows = false;
            this.dgvCritico.AllowUserToResizeColumns = false;
            this.dgvCritico.AllowUserToResizeRows = false;
            this.dgvCritico.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCritico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCritico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCritico.Location = new System.Drawing.Point(27, 46);
            this.dgvCritico.MultiSelect = false;
            this.dgvCritico.Name = "dgvCritico";
            this.dgvCritico.ReadOnly = true;
            this.dgvCritico.RowHeadersVisible = false;
            this.dgvCritico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCritico.Size = new System.Drawing.Size(333, 229);
            this.dgvCritico.TabIndex = 0;
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
            // lblSucursalInfo
            // 
            this.lblSucursalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursalInfo.Location = new System.Drawing.Point(6, 9);
            this.lblSucursalInfo.Name = "lblSucursalInfo";
            this.lblSucursalInfo.Size = new System.Drawing.Size(613, 61);
            this.lblSucursalInfo.TabIndex = 3;
            this.lblSucursalInfo.Text = " ";
            // 
            // gbVentas
            // 
            this.gbVentas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.gbVentas.Controls.Add(this.btnVentas);
            this.gbVentas.Controls.Add(this.btnVenta);
            this.gbVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVentas.Location = new System.Drawing.Point(6, 170);
            this.gbVentas.Name = "gbVentas";
            this.gbVentas.Size = new System.Drawing.Size(733, 80);
            this.gbVentas.TabIndex = 1;
            this.gbVentas.TabStop = false;
            this.gbVentas.Text = "Ventas";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sin Ningun Stock en cantidad Critica.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbDeposito
            // 
            this.gbDeposito.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            this.gbDeposito.Controls.Add(this.btnDeposito);
            this.gbDeposito.Controls.Add(this.btnHistorial);
            this.gbDeposito.Controls.Add(this.btnNewSolicitudes);
            this.gbDeposito.Controls.Add(this.btnSolicitudes);
            this.gbDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDeposito.Location = new System.Drawing.Point(6, 73);
            this.gbDeposito.Name = "gbDeposito";
            this.gbDeposito.Size = new System.Drawing.Size(733, 88);
            this.gbDeposito.TabIndex = 0;
            this.gbDeposito.TabStop = false;
            this.gbDeposito.Text = "Deposito";
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(541, 25);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(126, 55);
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
            this.gbSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSucursal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbSucursal.Location = new System.Drawing.Point(8, 43);
            this.gbSucursal.Name = "gbSucursal";
            this.gbSucursal.Size = new System.Drawing.Size(760, 111);
            this.gbSucursal.TabIndex = 0;
            this.gbSucursal.TabStop = false;
            this.gbSucursal.Text = "Sucursales";
            // 
            // btnSuc
            // 
            this.btnSuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSuc.Location = new System.Drawing.Point(106, 27);
            this.btnSuc.Name = "btnSuc";
            this.btnSuc.Size = new System.Drawing.Size(96, 54);
            this.btnSuc.TabIndex = 0;
            this.btnSuc.Text = "Sucursales";
            this.btnSuc.UseVisualStyleBackColor = true;
            this.btnSuc.Click += new System.EventHandler(this.BtnSuc_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.AutoSize = true;
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmpleados.Location = new System.Drawing.Point(556, 27);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(99, 54);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // btnGraficosVentaGeneral
            // 
            this.btnGraficosVentaGeneral.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGraficosVentaGeneral.Location = new System.Drawing.Point(331, 27);
            this.btnGraficosVentaGeneral.Name = "btnGraficosVentaGeneral";
            this.btnGraficosVentaGeneral.Size = new System.Drawing.Size(96, 54);
            this.btnGraficosVentaGeneral.TabIndex = 1;
            this.btnGraficosVentaGeneral.Text = "Graficos Ventas";
            this.btnGraficosVentaGeneral.UseVisualStyleBackColor = true;
            this.btnGraficosVentaGeneral.Click += new System.EventHandler(this.BtnGraficosVentaGeneral_Click);
            // 
            // gbProductos
            // 
            this.gbProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.gbProductos.Controls.Add(this.btnMerma);
            this.gbProductos.Controls.Add(this.btnDepositos);
            this.gbProductos.Controls.Add(this.btnBebidas);
            this.gbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductos.Location = new System.Drawing.Point(8, 176);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(760, 97);
            this.gbProductos.TabIndex = 1;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos";
            // 
            // btnBebidas
            // 
            this.btnBebidas.Location = new System.Drawing.Point(331, 27);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(96, 53);
            this.btnBebidas.TabIndex = 1;
            this.btnBebidas.Text = "Productos";
            this.btnBebidas.UseVisualStyleBackColor = true;
            this.btnBebidas.Click += new System.EventHandler(this.BtnBebidas_Click);
            // 
            // btnDepositos
            // 
            this.btnDepositos.Location = new System.Drawing.Point(113, 27);
            this.btnDepositos.Name = "btnDepositos";
            this.btnDepositos.Size = new System.Drawing.Size(96, 53);
            this.btnDepositos.TabIndex = 0;
            this.btnDepositos.Text = "Depositos";
            this.btnDepositos.UseVisualStyleBackColor = true;
            this.btnDepositos.Click += new System.EventHandler(this.BtnIngredientes_Click);
            // 
            // btnMerma
            // 
            this.btnMerma.Location = new System.Drawing.Point(548, 27);
            this.btnMerma.Name = "btnMerma";
            this.btnMerma.Size = new System.Drawing.Size(99, 53);
            this.btnMerma.TabIndex = 2;
            this.btnMerma.Text = "Merma";
            this.btnMerma.UseVisualStyleBackColor = true;
            this.btnMerma.Click += new System.EventHandler(this.btnMerma_Click);
            // 
            // btnCUIT
            // 
            this.btnCUIT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCUIT.Location = new System.Drawing.Point(307, 469);
            this.btnCUIT.Name = "btnCUIT";
            this.btnCUIT.Size = new System.Drawing.Size(142, 45);
            this.btnCUIT.TabIndex = 4;
            this.btnCUIT.Text = "Configuración";
            this.btnCUIT.UseVisualStyleBackColor = true;
            this.btnCUIT.Click += new System.EventHandler(this.btnCUIT_Click);
            // 
            // gbPlatos
            // 
            this.gbPlatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPlatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.gbPlatos.Controls.Add(this.btnEditPlato);
            this.gbPlatos.Controls.Add(this.btnPlato);
            this.gbPlatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlatos.Location = new System.Drawing.Point(17, 295);
            this.gbPlatos.Name = "gbPlatos";
            this.gbPlatos.Size = new System.Drawing.Size(751, 97);
            this.gbPlatos.TabIndex = 2;
            this.gbPlatos.TabStop = false;
            this.gbPlatos.Text = "Platos";
            // 
            // btnPlato
            // 
            this.btnPlato.Location = new System.Drawing.Point(226, 27);
            this.btnPlato.Name = "btnPlato";
            this.btnPlato.Size = new System.Drawing.Size(96, 51);
            this.btnPlato.TabIndex = 0;
            this.btnPlato.Text = "Agregar Platos";
            this.btnPlato.UseVisualStyleBackColor = true;
            this.btnPlato.Click += new System.EventHandler(this.BtnPlato_Click);
            // 
            // btnEditPlato
            // 
            this.btnEditPlato.Location = new System.Drawing.Point(428, 27);
            this.btnEditPlato.Name = "btnEditPlato";
            this.btnEditPlato.Size = new System.Drawing.Size(96, 51);
            this.btnEditPlato.TabIndex = 1;
            this.btnEditPlato.Text = "Ver Platos";
            this.btnEditPlato.UseVisualStyleBackColor = true;
            this.btnEditPlato.Click += new System.EventHandler(this.BtnEditPlato_Click);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.Sucursal);
            this.tcPrincipal.Controls.Add(this.Administracion);
            this.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(784, 561);
            this.tcPrincipal.TabIndex = 5;
            // 
            // Administracion
            // 
            this.Administracion.Controls.Add(this.pnlAdmin);
            this.Administracion.Location = new System.Drawing.Point(4, 22);
            this.Administracion.Name = "Administracion";
            this.Administracion.Padding = new System.Windows.Forms.Padding(3);
            this.Administracion.Size = new System.Drawing.Size(776, 535);
            this.Administracion.TabIndex = 1;
            this.Administracion.Text = "Administracion";
            this.Administracion.UseVisualStyleBackColor = true;
            // 
            // Sucursal
            // 
            this.Sucursal.Controls.Add(this.pnlVendedor);
            this.Sucursal.Location = new System.Drawing.Point(4, 22);
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Padding = new System.Windows.Forms.Padding(3);
            this.Sucursal.Size = new System.Drawing.Size(776, 535);
            this.Sucursal.TabIndex = 0;
            this.Sucursal.Text = "Sucursal";
            this.Sucursal.UseVisualStyleBackColor = true;
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAdmin.Controls.Add(this.gbPlatos);
            this.pnlAdmin.Controls.Add(this.btnCUIT);
            this.pnlAdmin.Controls.Add(this.gbProductos);
            this.pnlAdmin.Controls.Add(this.gbSucursal);
            this.pnlAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(776, 561);
            this.pnlAdmin.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tcPrincipal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
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
            this.tcPrincipal.ResumeLayout(false);
            this.Administracion.ResumeLayout(false);
            this.Sucursal.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Panel pnlCritico;
        private Componentes.GrillaFormatead dgvCritico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblSucursalInfo;
        private System.Windows.Forms.GroupBox gbSucursal;
        private System.Windows.Forms.Button btnGraficosVentaGeneral;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnSuc;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Button btnMerma;
        private System.Windows.Forms.Button btnDepositos;
        private System.Windows.Forms.Button btnBebidas;
        private System.Windows.Forms.Button btnCUIT;
        private System.Windows.Forms.GroupBox gbPlatos;
        private System.Windows.Forms.Button btnEditPlato;
        private System.Windows.Forms.Button btnPlato;
        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage Sucursal;
        private System.Windows.Forms.TabPage Administracion;
        private System.Windows.Forms.Panel pnlAdmin;
    }
}

