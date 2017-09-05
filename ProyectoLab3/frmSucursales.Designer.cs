namespace ProyectoLab3
{
    partial class frmSucursales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbProvincia = new System.Windows.Forms.TextBox();
            this.btnAddProv = new System.Windows.Forms.Button();
            this.gpProv = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddLocalidad = new System.Windows.Forms.Button();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbDir = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.btnAddSucursal = new System.Windows.Forms.Button();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.lblManager = new System.Windows.Forms.Label();
            this.lbManagers = new System.Windows.Forms.ListBox();
            this.tbBusquedaManager = new System.Windows.Forms.TextBox();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbDir = new System.Windows.Forms.TextBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.dgvSucursal = new Clases.GrillaFormateada();
            this.dgvLocalidad = new Clases.GrillaFormateada();
            this.dgvProvincia = new Clases.GrillaFormateada();
            this.gpProv.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincia)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProvincia
            // 
            this.tbProvincia.Location = new System.Drawing.Point(17, 17);
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.Size = new System.Drawing.Size(100, 20);
            this.tbProvincia.TabIndex = 8;
            // 
            // btnAddProv
            // 
            this.btnAddProv.Location = new System.Drawing.Point(30, 46);
            this.btnAddProv.Name = "btnAddProv";
            this.btnAddProv.Size = new System.Drawing.Size(75, 23);
            this.btnAddProv.TabIndex = 9;
            this.btnAddProv.Text = "Agregar";
            this.btnAddProv.UseVisualStyleBackColor = true;
            this.btnAddProv.Click += new System.EventHandler(this.btnAddProv_Click);
            // 
            // gpProv
            // 
            this.gpProv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gpProv.Controls.Add(this.btnAddProv);
            this.gpProv.Controls.Add(this.tbProvincia);
            this.gpProv.Controls.Add(this.dgvProvincia);
            this.gpProv.Location = new System.Drawing.Point(12, 9);
            this.gpProv.Name = "gpProv";
            this.gpProv.Size = new System.Drawing.Size(134, 461);
            this.gpProv.TabIndex = 10;
            this.gpProv.TabStop = false;
            this.gpProv.Text = "Provincias";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnAddLocalidad);
            this.groupBox1.Controls.Add(this.tbLocalidad);
            this.groupBox1.Controls.Add(this.dgvLocalidad);
            this.groupBox1.Location = new System.Drawing.Point(177, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 461);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localidades";
            // 
            // btnAddLocalidad
            // 
            this.btnAddLocalidad.Location = new System.Drawing.Point(32, 46);
            this.btnAddLocalidad.Name = "btnAddLocalidad";
            this.btnAddLocalidad.Size = new System.Drawing.Size(75, 23);
            this.btnAddLocalidad.TabIndex = 1;
            this.btnAddLocalidad.Text = "Agregar";
            this.btnAddLocalidad.UseVisualStyleBackColor = true;
            this.btnAddLocalidad.Click += new System.EventHandler(this.btnAddLocalidad_Click);
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(20, 17);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(100, 20);
            this.tbLocalidad.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.rtbDir);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgvSucursal);
            this.groupBox2.Controls.Add(this.tbTelefono);
            this.groupBox2.Controls.Add(this.btnAddSucursal);
            this.groupBox2.Location = new System.Drawing.Point(343, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 458);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sucursal";
            // 
            // rtbDir
            // 
            this.rtbDir.Location = new System.Drawing.Point(64, 14);
            this.rtbDir.Name = "rtbDir";
            this.rtbDir.Size = new System.Drawing.Size(162, 60);
            this.rtbDir.TabIndex = 4;
            this.rtbDir.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefono";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(287, 14);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono.TabIndex = 1;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // btnAddSucursal
            // 
            this.btnAddSucursal.Location = new System.Drawing.Point(407, 51);
            this.btnAddSucursal.Name = "btnAddSucursal";
            this.btnAddSucursal.Size = new System.Drawing.Size(75, 23);
            this.btnAddSucursal.TabIndex = 0;
            this.btnAddSucursal.Text = "Agregar";
            this.btnAddSucursal.UseVisualStyleBackColor = true;
            this.btnAddSucursal.Click += new System.EventHandler(this.btnAddSucursal_Click);
            // 
            // pnlConfig
            // 
            this.pnlConfig.Controls.Add(this.lblTel);
            this.pnlConfig.Controls.Add(this.lblDir);
            this.pnlConfig.Controls.Add(this.tbDir);
            this.pnlConfig.Controls.Add(this.tbTel);
            this.pnlConfig.Controls.Add(this.btnGuardar);
            this.pnlConfig.Controls.Add(this.btnEstado);
            this.pnlConfig.Controls.Add(this.tbBusquedaManager);
            this.pnlConfig.Controls.Add(this.lbManagers);
            this.pnlConfig.Controls.Add(this.lblManager);
            this.pnlConfig.Location = new System.Drawing.Point(837, 12);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(143, 452);
            this.pnlConfig.TabIndex = 13;
            this.pnlConfig.Visible = false;
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(47, 43);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(49, 13);
            this.lblManager.TabIndex = 1;
            this.lblManager.Text = "Manager";
            // 
            // lbManagers
            // 
            this.lbManagers.FormattingEnabled = true;
            this.lbManagers.Location = new System.Drawing.Point(11, 88);
            this.lbManagers.Name = "lbManagers";
            this.lbManagers.Size = new System.Drawing.Size(120, 95);
            this.lbManagers.TabIndex = 2;
            // 
            // tbBusquedaManager
            // 
            this.tbBusquedaManager.Location = new System.Drawing.Point(11, 62);
            this.tbBusquedaManager.Name = "tbBusquedaManager";
            this.tbBusquedaManager.Size = new System.Drawing.Size(120, 20);
            this.tbBusquedaManager.TabIndex = 3;
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(35, 402);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(75, 23);
            this.btnEstado.TabIndex = 4;
            this.btnEstado.Text = "????";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(35, 291);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 37);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(11, 256);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(120, 20);
            this.tbTel.TabIndex = 6;
            // 
            // tbDir
            // 
            this.tbDir.Location = new System.Drawing.Point(11, 207);
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(120, 20);
            this.tbDir.TabIndex = 7;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(47, 191);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(52, 13);
            this.lblDir.TabIndex = 8;
            this.lblDir.Text = "Direccion";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(47, 240);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 9;
            this.lblTel.Text = "Telefono";
            // 
            // dgvSucursal
            // 
            this.dgvSucursal.AllowUserToAddRows = false;
            this.dgvSucursal.AllowUserToResizeColumns = false;
            this.dgvSucursal.AllowUserToResizeRows = false;
            this.dgvSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSucursal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucursal.Location = new System.Drawing.Point(10, 84);
            this.dgvSucursal.MultiSelect = false;
            this.dgvSucursal.Name = "dgvSucursal";
            this.dgvSucursal.ReadOnly = true;
            this.dgvSucursal.RowHeadersVisible = false;
            this.dgvSucursal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSucursal.Size = new System.Drawing.Size(472, 368);
            this.dgvSucursal.TabIndex = 2;
            this.dgvSucursal.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSucursal_RowEnter);
            this.dgvSucursal.SelectionChanged += new System.EventHandler(this.dgvSucursal_SelectionChanged);
            // 
            // dgvLocalidad
            // 
            this.dgvLocalidad.AllowUserToAddRows = false;
            this.dgvLocalidad.AllowUserToResizeColumns = false;
            this.dgvLocalidad.AllowUserToResizeRows = false;
            this.dgvLocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalidad.Location = new System.Drawing.Point(8, 87);
            this.dgvLocalidad.MultiSelect = false;
            this.dgvLocalidad.Name = "dgvLocalidad";
            this.dgvLocalidad.ReadOnly = true;
            this.dgvLocalidad.RowHeadersVisible = false;
            this.dgvLocalidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalidad.Size = new System.Drawing.Size(124, 368);
            this.dgvLocalidad.TabIndex = 1;
            this.dgvLocalidad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocalidad_CellContentClick);
            // 
            // dgvProvincia
            // 
            this.dgvProvincia.AllowUserToAddRows = false;
            this.dgvProvincia.AllowUserToResizeColumns = false;
            this.dgvProvincia.AllowUserToResizeRows = false;
            this.dgvProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProvincia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProvincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvincia.Location = new System.Drawing.Point(8, 87);
            this.dgvProvincia.MultiSelect = false;
            this.dgvProvincia.Name = "dgvProvincia";
            this.dgvProvincia.ReadOnly = true;
            this.dgvProvincia.RowHeadersVisible = false;
            this.dgvProvincia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvincia.Size = new System.Drawing.Size(120, 368);
            this.dgvProvincia.TabIndex = 0;
            // 
            // frmSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 482);
            this.Controls.Add(this.pnlConfig);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpProv);
            this.Name = "frmSucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucursales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSucursales_Load);
            this.gpProv.ResumeLayout(false);
            this.gpProv.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Clases.GrillaFormateada dgvProvincia;
        private Clases.GrillaFormateada dgvLocalidad;
        private Clases.GrillaFormateada dgvSucursal;
        private System.Windows.Forms.TextBox tbProvincia;
        private System.Windows.Forms.Button btnAddProv;
        private System.Windows.Forms.GroupBox gpProv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddLocalidad;
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddSucursal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.RichTextBox rtbDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.TextBox tbBusquedaManager;
        private System.Windows.Forms.ListBox lbManagers;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Button btnGuardar;
    }
}