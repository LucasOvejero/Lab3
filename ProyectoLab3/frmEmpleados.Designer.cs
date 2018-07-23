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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCargar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.pnlNuevo = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.dgvSucursales = new Componentes.GrillaFormatead();
            this.tbFiltroSucursal = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.dgvEmpleados = new Componentes.GrillaFormatead();
            this.tbFiltroEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTodasSucursales = new System.Windows.Forms.CheckBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoEdit = new System.Windows.Forms.ComboBox();
            this.tbTelefonoEdit = new System.Windows.Forms.TextBox();
            this.tbDNIEdit = new System.Windows.Forms.TextBox();
            this.tbApellidoEdit = new System.Windows.Forms.TextBox();
            this.tbNombreEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMotivo = new System.Windows.Forms.TextBox();
            this.btnTransferencias = new System.Windows.Forms.Button();
            this.pnlNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(191, 469);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(99, 37);
            this.btnCargar.TabIndex = 9;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(7, 325);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(121, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(149, 309);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 309);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(7, 356);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefono";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Sin Asignar",
            "Admin",
            "Manager",
            "Vendedor",
            "Limpieza",
            "Cocina",
            "Seguridad",
            "Otros"});
            this.cbTipo.Location = new System.Drawing.Point(11, 478);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(141, 21);
            this.cbTipo.TabIndex = 8;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(11, 462);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(81, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Empleado Tipo:";
            // 
            // pnlNuevo
            // 
            this.pnlNuevo.Controls.Add(this.label11);
            this.pnlNuevo.Controls.Add(this.label2);
            this.pnlNuevo.Controls.Add(this.label1);
            this.pnlNuevo.Controls.Add(this.tbPass);
            this.pnlNuevo.Controls.Add(this.tbUser);
            this.pnlNuevo.Controls.Add(this.dgvSucursales);
            this.pnlNuevo.Controls.Add(this.tbFiltroSucursal);
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
            this.pnlNuevo.Size = new System.Drawing.Size(342, 523);
            this.pnlNuevo.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(73, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Nuevo Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "User";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(150, 420);
            this.tbPass.MaxLength = 10;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(141, 20);
            this.tbPass.TabIndex = 7;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(8, 420);
            this.tbUser.MaxLength = 10;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(121, 20);
            this.tbUser.TabIndex = 6;
            // 
            // dgvSucursales
            // 
            this.dgvSucursales.AllowUserToAddRows = false;
            this.dgvSucursales.AllowUserToResizeColumns = false;
            this.dgvSucursales.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSucursales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucursales.Location = new System.Drawing.Point(0, 66);
            this.dgvSucursales.MultiSelect = false;
            this.dgvSucursales.Name = "dgvSucursales";
            this.dgvSucursales.ReadOnly = true;
            this.dgvSucursales.RowHeadersVisible = false;
            this.dgvSucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSucursales.Size = new System.Drawing.Size(318, 192);
            this.dgvSucursales.TabIndex = 1;
            this.dgvSucursales.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSucursales_RowEnter);
            // 
            // tbFiltroSucursal
            // 
            this.tbFiltroSucursal.Location = new System.Drawing.Point(149, 40);
            this.tbFiltroSucursal.Name = "tbFiltroSucursal";
            this.tbFiltroSucursal.Size = new System.Drawing.Size(141, 20);
            this.tbFiltroSucursal.TabIndex = 0;
            this.tbFiltroSucursal.TextChanged += new System.EventHandler(this.tbFiltroSucursal_TextChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(177, 24);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(76, 13);
            this.lblBusqueda.TabIndex = 7;
            this.lblBusqueda.Text = "Filtrar Sucursal";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(3, 9);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(66, 18);
            this.lblSucursal.TabIndex = 6;
            this.lblSucursal.Text = "Sucursal";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(149, 374);
            this.tbTelefono.MaxLength = 10;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(141, 20);
            this.tbTelefono.TabIndex = 5;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(7, 371);
            this.tbDni.MaxLength = 8;
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(122, 20);
            this.tbDni.TabIndex = 4;
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(149, 325);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(141, 20);
            this.tbApellido.TabIndex = 3;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToResizeColumns = false;
            this.dgvEmpleados.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(360, 78);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(412, 289);
            this.dgvEmpleados.TabIndex = 3;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            this.dgvEmpleados.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_RowEnter);
            // 
            // tbFiltroEmpleado
            // 
            this.tbFiltroEmpleado.Location = new System.Drawing.Point(470, 52);
            this.tbFiltroEmpleado.Name = "tbFiltroEmpleado";
            this.tbFiltroEmpleado.Size = new System.Drawing.Size(141, 20);
            this.tbFiltroEmpleado.TabIndex = 1;
            this.tbFiltroEmpleado.TextChanged += new System.EventHandler(this.tbFiltroEmpleado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Filtrar Empleados";
            // 
            // cbTodasSucursales
            // 
            this.cbTodasSucursales.AutoSize = true;
            this.cbTodasSucursales.Checked = true;
            this.cbTodasSucursales.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTodasSucursales.Location = new System.Drawing.Point(630, 52);
            this.cbTodasSucursales.Name = "cbTodasSucursales";
            this.cbTodasSucursales.Size = new System.Drawing.Size(125, 17);
            this.cbTodasSucursales.TabIndex = 2;
            this.cbTodasSucursales.Text = "Todas las sucursales";
            this.cbTodasSucursales.UseVisualStyleBackColor = true;
            this.cbTodasSucursales.CheckedChanged += new System.EventHandler(this.cbTodasSucursales_CheckedChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(650, 433);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 21);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Empleado Tipo:";
            // 
            // cbTipoEdit
            // 
            this.cbTipoEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoEdit.FormattingEnabled = true;
            this.cbTipoEdit.Items.AddRange(new object[] {
            "Sin Asignar",
            "Admin",
            "Vendedor",
            "Limpieza",
            "Cocina",
            "Seguridad",
            "Otros"});
            this.cbTipoEdit.Location = new System.Drawing.Point(503, 433);
            this.cbTipoEdit.Name = "cbTipoEdit";
            this.cbTipoEdit.Size = new System.Drawing.Size(141, 21);
            this.cbTipoEdit.TabIndex = 8;
            this.cbTipoEdit.SelectedIndexChanged += new System.EventHandler(this.cbTipoEdit_SelectedIndexChanged);
            // 
            // tbTelefonoEdit
            // 
            this.tbTelefonoEdit.Location = new System.Drawing.Point(376, 434);
            this.tbTelefonoEdit.MaxLength = 10;
            this.tbTelefonoEdit.Name = "tbTelefonoEdit";
            this.tbTelefonoEdit.Size = new System.Drawing.Size(121, 20);
            this.tbTelefonoEdit.TabIndex = 7;
            // 
            // tbDNIEdit
            // 
            this.tbDNIEdit.Location = new System.Drawing.Point(650, 387);
            this.tbDNIEdit.MaxLength = 8;
            this.tbDNIEdit.Name = "tbDNIEdit";
            this.tbDNIEdit.Size = new System.Drawing.Size(122, 20);
            this.tbDNIEdit.TabIndex = 6;
            // 
            // tbApellidoEdit
            // 
            this.tbApellidoEdit.Location = new System.Drawing.Point(503, 387);
            this.tbApellidoEdit.Name = "tbApellidoEdit";
            this.tbApellidoEdit.Size = new System.Drawing.Size(141, 20);
            this.tbApellidoEdit.TabIndex = 5;
            // 
            // tbNombreEdit
            // 
            this.tbNombreEdit.Location = new System.Drawing.Point(376, 387);
            this.tbNombreEdit.Name = "tbNombreEdit";
            this.tbNombreEdit.Size = new System.Drawing.Size(121, 20);
            this.tbNombreEdit.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(650, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "DNI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nombre";
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(277, 16);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(107, 34);
            this.btnTransferir.TabIndex = 1;
            this.btnTransferir.Text = "Transferir a...";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tbMotivo);
            this.panel1.Controls.Add(this.btnTransferir);
            this.panel1.Location = new System.Drawing.Point(374, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 58);
            this.panel1.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Ingrese un Motivo";
            // 
            // tbMotivo
            // 
            this.tbMotivo.Location = new System.Drawing.Point(28, 16);
            this.tbMotivo.MaxLength = 255;
            this.tbMotivo.Multiline = true;
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.Size = new System.Drawing.Size(240, 34);
            this.tbMotivo.TabIndex = 0;
            // 
            // btnTransferencias
            // 
            this.btnTransferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferencias.Location = new System.Drawing.Point(442, 524);
            this.btnTransferencias.Name = "btnTransferencias";
            this.btnTransferencias.Size = new System.Drawing.Size(262, 26);
            this.btnTransferencias.TabIndex = 10;
            this.btnTransferencias.Text = "Historial de Transferencias";
            this.btnTransferencias.UseVisualStyleBackColor = true;
            this.btnTransferencias.Click += new System.EventHandler(this.btnTransferencias_Click);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnTransferencias);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTipoEdit);
            this.Controls.Add(this.tbTelefonoEdit);
            this.Controls.Add(this.tbDNIEdit);
            this.Controls.Add(this.tbApellidoEdit);
            this.Controls.Add(this.tbNombreEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbTodasSucursales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFiltroEmpleado);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.pnlNuevo);
            this.Name = "frmEmpleados";
            this.Text = "Empleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.pnlNuevo.ResumeLayout(false);
            this.pnlNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox tbFiltroSucursal;
        private Componentes.GrillaFormatead dgvEmpleados;
        private Componentes.GrillaFormatead dgvSucursales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFiltroEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbTodasSucursales;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipoEdit;
        private System.Windows.Forms.TextBox tbTelefonoEdit;
        private System.Windows.Forms.TextBox tbDNIEdit;
        private System.Windows.Forms.TextBox tbApellidoEdit;
        private System.Windows.Forms.TextBox tbNombreEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMotivo;
        private System.Windows.Forms.Button btnTransferencias;
        private System.Windows.Forms.Label label11;
    }
}