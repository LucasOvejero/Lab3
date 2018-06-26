namespace ProyectoLab3
{
    partial class frmEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCargar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.pnlNuevo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.dgvSucursales = new Componentes.GrillaFormatead();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.dgvEmpleados = new Componentes.GrillaFormatead();
            this.pnlNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(113, 357);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(21, 37);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(121, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(59, 68);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(59, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(68, 123);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefono";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Sin Asignar",
            "Administrador",
            "Manager",
            "Vendedor"});
            this.cbTipo.Location = new System.Drawing.Point(21, 257);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 4;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(41, 233);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(81, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Empleado Tipo:";
            // 
            // pnlNuevo
            // 
            this.pnlNuevo.Controls.Add(this.label2);
            this.pnlNuevo.Controls.Add(this.label1);
            this.pnlNuevo.Controls.Add(this.tbPass);
            this.pnlNuevo.Controls.Add(this.tbUser);
            this.pnlNuevo.Controls.Add(this.dgvSucursales);
            this.pnlNuevo.Controls.Add(this.tbBusqueda);
            this.pnlNuevo.Controls.Add(this.lblBusqueda);
            this.pnlNuevo.Controls.Add(this.lblSucursal);
            this.pnlNuevo.Controls.Add(this.btnCargar);
            this.pnlNuevo.Controls.Add(this.lblTipo);
            this.pnlNuevo.Controls.Add(this.cbTipo);
            this.pnlNuevo.Controls.Add(this.tbTelefono);
            this.pnlNuevo.Controls.Add(this.tbDni);
            this.pnlNuevo.Controls.Add(this.tbApellido);
            this.pnlNuevo.Controls.Add(this.tbNombre);
            this.pnlNuevo.Controls.Add(this.label4);
            this.pnlNuevo.Controls.Add(this.lblApellido);
            this.pnlNuevo.Controls.Add(this.lblDni);
            this.pnlNuevo.Controls.Add(this.lblNombre);
            this.pnlNuevo.Location = new System.Drawing.Point(12, 12);
            this.pnlNuevo.Name = "pnlNuevo";
            this.pnlNuevo.Size = new System.Drawing.Size(311, 383);
            this.pnlNuevo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(149, 318);
            this.tbPass.MaxLength = 10;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(141, 20);
            this.tbPass.TabIndex = 6;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(21, 318);
            this.tbUser.MaxLength = 10;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(121, 20);
            this.tbUser.TabIndex = 5;
            // 
            // dgvSucursales
            // 
            this.dgvSucursales.AllowUserToAddRows = false;
            this.dgvSucursales.AllowUserToResizeColumns = false;
            this.dgvSucursales.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSucursales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucursales.Location = new System.Drawing.Point(149, 87);
            this.dgvSucursales.MultiSelect = false;
            this.dgvSucursales.Name = "dgvSucursales";
            this.dgvSucursales.ReadOnly = true;
            this.dgvSucursales.RowHeadersVisible = false;
            this.dgvSucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSucursales.Size = new System.Drawing.Size(141, 191);
            this.dgvSucursales.TabIndex = 9;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(149, 60);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(141, 20);
            this.tbBusqueda.TabIndex = 8;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(173, 37);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(91, 13);
            this.lblBusqueda.TabIndex = 7;
            this.lblBusqueda.Text = "Buscar Direccion:";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(184, 13);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(66, 18);
            this.lblSucursal.TabIndex = 6;
            this.lblSucursal.Text = "Sucursal";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(21, 202);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(121, 20);
            this.tbTelefono.TabIndex = 3;
            this.tbTelefono.TextChanged += new System.EventHandler(this.tbTelefono_TextChanged);
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(20, 147);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(122, 20);
            this.tbDni.TabIndex = 2;
            this.tbDni.TextChanged += new System.EventHandler(this.tbDni_TextChanged);
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(21, 92);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(121, 20);
            this.tbApellido.TabIndex = 1;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToResizeColumns = false;
            this.dgvEmpleados.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(329, 12);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(628, 383);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 461);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.pnlNuevo);
            this.Name = "frmEmpleados";
            this.Text = "Empleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.pnlNuevo.ResumeLayout(false);
            this.pnlNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Panel pnlNuevo;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.TextBox tbBusqueda;
        private Componentes.GrillaFormatead dgvEmpleados;
        private Componentes.GrillaFormatead dgvSucursales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label2;
    }
}