﻿namespace ProyectoLab3
{
    partial class frmProductos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.nudLitros = new System.Windows.Forms.NumericUpDown();
            this.cbAlcohol = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCosto = new System.Windows.Forms.NumericUpDown();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.gpEdicion = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cboEditCatBebida = new System.Windows.Forms.ComboBox();
            this.nudEditPrecio = new System.Windows.Forms.NumericUpDown();
            this.nudEditCosto = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEditAlcohol = new System.Windows.Forms.CheckBox();
            this.nudEditLitros = new System.Windows.Forms.NumericUpDown();
            this.tbEditName = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cboCatAddBebida = new System.Windows.Forms.ComboBox();
            this.dgvBebidas = new Componentes.GrillaFormatead();
            this.label9 = new System.Windows.Forms.Label();
            this.nudCostoPorKilo = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNombreIngrediente = new System.Windows.Forms.TextBox();
            this.btnAddIngrediente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbCatBeb = new System.Windows.Forms.TextBox();
            this.btnAgregarCatBebida = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbNombreCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboEditCateg = new System.Windows.Forms.ComboBox();
            this.nudEditCostoIngrediente = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEditNombreIngrediente = new System.Windows.Forms.TextBox();
            this.btnActualizarIngrediente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.dgvIngredientes = new Componentes.GrillaFormatead();
            this.tbStockCritico = new System.Windows.Forms.TextBox();
            this.errpNBebida = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudLitros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.gpEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditLitros)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoPorKilo)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditCostoIngrediente)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpNBebida)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(595, 74);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(35, 30);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // nudLitros
            // 
            this.nudLitros.DecimalPlaces = 1;
            this.nudLitros.Location = new System.Drawing.Point(380, 30);
            this.nudLitros.Name = "nudLitros";
            this.nudLitros.Size = new System.Drawing.Size(61, 20);
            this.nudLitros.TabIndex = 3;
            // 
            // cbAlcohol
            // 
            this.cbAlcohol.AutoSize = true;
            this.cbAlcohol.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbAlcohol.Location = new System.Drawing.Point(476, 30);
            this.cbAlcohol.Name = "cbAlcohol";
            this.cbAlcohol.Size = new System.Drawing.Size(61, 17);
            this.cbAlcohol.TabIndex = 4;
            this.cbAlcohol.Text = "Alcohol";
            this.cbAlcohol.UseVisualStyleBackColor = true;
            this.cbAlcohol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAlcohol_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Litros";
            // 
            // nudCosto
            // 
            this.nudCosto.DecimalPlaces = 2;
            this.nudCosto.Location = new System.Drawing.Point(287, 30);
            this.nudCosto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCosto.Name = "nudCosto";
            this.nudCosto.Size = new System.Drawing.Size(70, 20);
            this.nudCosto.TabIndex = 2;
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(168, 30);
            this.nudPrecio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(66, 20);
            this.nudPrecio.TabIndex = 1;
            // 
            // gpEdicion
            // 
            this.gpEdicion.Controls.Add(this.label18);
            this.gpEdicion.Controls.Add(this.cboEditCatBebida);
            this.gpEdicion.Controls.Add(this.nudEditPrecio);
            this.gpEdicion.Controls.Add(this.nudEditCosto);
            this.gpEdicion.Controls.Add(this.label5);
            this.gpEdicion.Controls.Add(this.label6);
            this.gpEdicion.Controls.Add(this.label7);
            this.gpEdicion.Controls.Add(this.label8);
            this.gpEdicion.Controls.Add(this.cbEditAlcohol);
            this.gpEdicion.Controls.Add(this.nudEditLitros);
            this.gpEdicion.Controls.Add(this.tbEditName);
            this.gpEdicion.Controls.Add(this.btnBorrar);
            this.gpEdicion.Controls.Add(this.btnEditar);
            this.gpEdicion.Location = new System.Drawing.Point(24, 456);
            this.gpEdicion.Name = "gpEdicion";
            this.gpEdicion.Size = new System.Drawing.Size(723, 98);
            this.gpEdicion.TabIndex = 2;
            this.gpEdicion.TabStop = false;
            this.gpEdicion.Text = "Edicion";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(592, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Categorias";
            // 
            // cboEditCatBebida
            // 
            this.cboEditCatBebida.FormattingEnabled = true;
            this.cboEditCatBebida.Location = new System.Drawing.Point(564, 38);
            this.cboEditCatBebida.Name = "cboEditCatBebida";
            this.cboEditCatBebida.Size = new System.Drawing.Size(121, 21);
            this.cboEditCatBebida.TabIndex = 12;
            // 
            // nudEditPrecio
            // 
            this.nudEditPrecio.DecimalPlaces = 2;
            this.nudEditPrecio.Location = new System.Drawing.Point(168, 42);
            this.nudEditPrecio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEditPrecio.Name = "nudEditPrecio";
            this.nudEditPrecio.Size = new System.Drawing.Size(66, 20);
            this.nudEditPrecio.TabIndex = 8;
            // 
            // nudEditCosto
            // 
            this.nudEditCosto.DecimalPlaces = 2;
            this.nudEditCosto.Location = new System.Drawing.Point(287, 42);
            this.nudEditCosto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEditCosto.Name = "nudEditCosto";
            this.nudEditCosto.Size = new System.Drawing.Size(70, 20);
            this.nudEditCosto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Litros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Costo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nombre";
            // 
            // cbEditAlcohol
            // 
            this.cbEditAlcohol.AutoSize = true;
            this.cbEditAlcohol.Location = new System.Drawing.Point(476, 42);
            this.cbEditAlcohol.Name = "cbEditAlcohol";
            this.cbEditAlcohol.Size = new System.Drawing.Size(61, 17);
            this.cbEditAlcohol.TabIndex = 11;
            this.cbEditAlcohol.Text = "Alcohol";
            this.cbEditAlcohol.UseVisualStyleBackColor = true;
            // 
            // nudEditLitros
            // 
            this.nudEditLitros.DecimalPlaces = 1;
            this.nudEditLitros.Location = new System.Drawing.Point(380, 42);
            this.nudEditLitros.Name = "nudEditLitros";
            this.nudEditLitros.Size = new System.Drawing.Size(61, 20);
            this.nudEditLitros.TabIndex = 10;
            // 
            // tbEditName
            // 
            this.tbEditName.Location = new System.Drawing.Point(35, 42);
            this.tbEditName.Name = "tbEditName";
            this.tbEditName.Size = new System.Drawing.Size(100, 20);
            this.tbEditName.TabIndex = 7;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(616, 69);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(101, 23);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(497, 71);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Aceptar edicion";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cboCatAddBebida);
            this.groupBox1.Controls.Add(this.nudPrecio);
            this.groupBox1.Controls.Add(this.nudCosto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvBebidas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbAlcohol);
            this.groupBox1.Controls.Add(this.nudLitros);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(24, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Bebida";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(592, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Categorias";
            // 
            // cboCatAddBebida
            // 
            this.cboCatAddBebida.FormattingEnabled = true;
            this.cboCatAddBebida.Location = new System.Drawing.Point(564, 30);
            this.cboCatAddBebida.Name = "cboCatAddBebida";
            this.cboCatAddBebida.Size = new System.Drawing.Size(121, 21);
            this.cboCatAddBebida.TabIndex = 5;
            // 
            // dgvBebidas
            // 
            this.dgvBebidas.AllowUserToAddRows = false;
            this.dgvBebidas.AllowUserToResizeColumns = false;
            this.dgvBebidas.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBebidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBebidas.Location = new System.Drawing.Point(6, 105);
            this.dgvBebidas.MultiSelect = false;
            this.dgvBebidas.Name = "dgvBebidas";
            this.dgvBebidas.ReadOnly = true;
            this.dgvBebidas.RowHeadersVisible = false;
            this.dgvBebidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBebidas.Size = new System.Drawing.Size(711, 297);
            this.dgvBebidas.StandardTab = true;
            this.dgvBebidas.TabIndex = 6;
            this.dgvBebidas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBebidas_RowEnter);
            this.dgvBebidas.SelectionChanged += new System.EventHandler(this.dgvBebidas_SelectionChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Costo por Kilo";
            // 
            // nudCostoPorKilo
            // 
            this.nudCostoPorKilo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCostoPorKilo.DecimalPlaces = 2;
            this.nudCostoPorKilo.Location = new System.Drawing.Point(121, 30);
            this.nudCostoPorKilo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCostoPorKilo.Name = "nudCostoPorKilo";
            this.nudCostoPorKilo.Size = new System.Drawing.Size(75, 20);
            this.nudCostoPorKilo.TabIndex = 17;
            this.nudCostoPorKilo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Nombre";
            // 
            // tbNombreIngrediente
            // 
            this.tbNombreIngrediente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombreIngrediente.Location = new System.Drawing.Point(6, 30);
            this.tbNombreIngrediente.Name = "tbNombreIngrediente";
            this.tbNombreIngrediente.Size = new System.Drawing.Size(100, 20);
            this.tbNombreIngrediente.TabIndex = 16;
            // 
            // btnAddIngrediente
            // 
            this.btnAddIngrediente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddIngrediente.Location = new System.Drawing.Point(443, 27);
            this.btnAddIngrediente.Name = "btnAddIngrediente";
            this.btnAddIngrediente.Size = new System.Drawing.Size(75, 23);
            this.btnAddIngrediente.TabIndex = 19;
            this.btnAddIngrediente.Text = "Agregar";
            this.btnAddIngrediente.UseVisualStyleBackColor = true;
            this.btnAddIngrediente.Click += new System.EventHandler(this.btnAddIngrediente_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gpEdicion);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 811);
            this.panel1.TabIndex = 20;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.tbCatBeb);
            this.groupBox5.Controls.Add(this.btnAgregarCatBebida);
            this.groupBox5.Location = new System.Drawing.Point(142, 582);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(392, 86);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Agregar Categoria";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(88, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Nombre";
            // 
            // tbCatBeb
            // 
            this.tbCatBeb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCatBeb.Location = new System.Drawing.Point(63, 35);
            this.tbCatBeb.Name = "tbCatBeb";
            this.tbCatBeb.Size = new System.Drawing.Size(100, 20);
            this.tbCatBeb.TabIndex = 14;
            // 
            // btnAgregarCatBebida
            // 
            this.btnAgregarCatBebida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCatBebida.Location = new System.Drawing.Point(237, 32);
            this.btnAgregarCatBebida.Name = "btnAgregarCatBebida";
            this.btnAgregarCatBebida.Size = new System.Drawing.Size(108, 23);
            this.btnAgregarCatBebida.TabIndex = 15;
            this.btnAgregarCatBebida.Text = "Agregar categoria";
            this.btnAgregarCatBebida.UseVisualStyleBackColor = true;
            this.btnAgregarCatBebida.Click += new System.EventHandler(this.btnAgregarCatBebida_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(753, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 792);
            this.panel2.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.tbNombreCategoria);
            this.groupBox4.Controls.Add(this.btnAgregarCategoria);
            this.groupBox4.Location = new System.Drawing.Point(58, 582);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(404, 86);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agregar Categoria";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(100, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Nombre";
            // 
            // tbNombreCategoria
            // 
            this.tbNombreCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombreCategoria.Location = new System.Drawing.Point(75, 35);
            this.tbNombreCategoria.Name = "tbNombreCategoria";
            this.tbNombreCategoria.Size = new System.Drawing.Size(100, 20);
            this.tbNombreCategoria.TabIndex = 24;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCategoria.Location = new System.Drawing.Point(249, 32);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(108, 23);
            this.btnAgregarCategoria.TabIndex = 25;
            this.btnAgregarCategoria.Text = "Agregar categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cboEditCateg);
            this.groupBox3.Controls.Add(this.nudEditCostoIngrediente);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbEditNombreIngrediente);
            this.groupBox3.Controls.Add(this.btnActualizarIngrediente);
            this.groupBox3.Location = new System.Drawing.Point(18, 468);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 86);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modificar Ingrediente";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(284, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Categorias";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(143, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Costo por Kilo";
            // 
            // cboEditCateg
            // 
            this.cboEditCateg.FormattingEnabled = true;
            this.cboEditCateg.Location = new System.Drawing.Point(248, 32);
            this.cboEditCateg.Name = "cboEditCateg";
            this.cboEditCateg.Size = new System.Drawing.Size(121, 21);
            this.cboEditCateg.TabIndex = 22;
            // 
            // nudEditCostoIngrediente
            // 
            this.nudEditCostoIngrediente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudEditCostoIngrediente.DecimalPlaces = 2;
            this.nudEditCostoIngrediente.Location = new System.Drawing.Point(137, 32);
            this.nudEditCostoIngrediente.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEditCostoIngrediente.Name = "nudEditCostoIngrediente";
            this.nudEditCostoIngrediente.Size = new System.Drawing.Size(94, 20);
            this.nudEditCostoIngrediente.TabIndex = 21;
            this.nudEditCostoIngrediente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Nombre";
            // 
            // tbEditNombreIngrediente
            // 
            this.tbEditNombreIngrediente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEditNombreIngrediente.Location = new System.Drawing.Point(20, 32);
            this.tbEditNombreIngrediente.Name = "tbEditNombreIngrediente";
            this.tbEditNombreIngrediente.Size = new System.Drawing.Size(100, 20);
            this.tbEditNombreIngrediente.TabIndex = 20;
            // 
            // btnActualizarIngrediente
            // 
            this.btnActualizarIngrediente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarIngrediente.Location = new System.Drawing.Point(386, 29);
            this.btnActualizarIngrediente.Name = "btnActualizarIngrediente";
            this.btnActualizarIngrediente.Size = new System.Drawing.Size(108, 23);
            this.btnActualizarIngrediente.TabIndex = 23;
            this.btnActualizarIngrediente.Text = "Aceptar edición";
            this.btnActualizarIngrediente.UseVisualStyleBackColor = true;
            this.btnActualizarIngrediente.Click += new System.EventHandler(this.btnActualizarIngrediente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cboCategorias);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dgvIngredientes);
            this.groupBox2.Controls.Add(this.nudCostoPorKilo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbStockCritico);
            this.groupBox2.Controls.Add(this.tbNombreIngrediente);
            this.groupBox2.Controls.Add(this.btnAddIngrediente);
            this.groupBox2.Location = new System.Drawing.Point(18, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 400);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Ingrediente";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(227, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "Stock Critico";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(340, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Categorias";
            // 
            // cboCategorias
            // 
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Location = new System.Drawing.Point(316, 30);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(121, 21);
            this.cboCategorias.TabIndex = 18;
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.AllowUserToAddRows = false;
            this.dgvIngredientes.AllowUserToResizeColumns = false;
            this.dgvIngredientes.AllowUserToResizeRows = false;
            this.dgvIngredientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngredientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Location = new System.Drawing.Point(75, 56);
            this.dgvIngredientes.MultiSelect = false;
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.ReadOnly = true;
            this.dgvIngredientes.RowHeadersVisible = false;
            this.dgvIngredientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngredientes.Size = new System.Drawing.Size(378, 311);
            this.dgvIngredientes.StandardTab = true;
            this.dgvIngredientes.TabIndex = 20;
            this.dgvIngredientes.SelectionChanged += new System.EventHandler(this.dgvIngredientes_SelectionChanged);
            // 
            // tbStockCritico
            // 
            this.tbStockCritico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStockCritico.Location = new System.Drawing.Point(214, 30);
            this.tbStockCritico.Name = "tbStockCritico";
            this.tbStockCritico.Size = new System.Drawing.Size(96, 20);
            this.tbStockCritico.TabIndex = 16;
            // 
            // errpNBebida
            // 
            this.errpNBebida.ContainerControl = this;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBebidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLitros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.gpEdicion.ResumeLayout(false);
            this.gpEdicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditLitros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoPorKilo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditCostoIngrediente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpNBebida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.NumericUpDown nudLitros;
        private System.Windows.Forms.CheckBox cbAlcohol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Componentes.GrillaFormatead dgvBebidas;
        private System.Windows.Forms.NumericUpDown nudCosto;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.GroupBox gpEdicion;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudEditPrecio;
        private System.Windows.Forms.NumericUpDown nudEditCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbEditAlcohol;
        private System.Windows.Forms.NumericUpDown nudEditLitros;
        private System.Windows.Forms.TextBox tbEditName;
        private Componentes.GrillaFormatead dgvIngredientes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudCostoPorKilo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNombreIngrediente;
        private System.Windows.Forms.Button btnAddIngrediente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudEditCostoIngrediente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbEditNombreIngrediente;
        private System.Windows.Forms.Button btnActualizarIngrediente;
        private System.Windows.Forms.ComboBox cboCategorias;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbNombreCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboEditCateg;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbCatBeb;
        private System.Windows.Forms.Button btnAgregarCatBebida;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboCatAddBebida;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboEditCatBebida;
        private System.Windows.Forms.ErrorProvider errpNBebida;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbStockCritico;
    }
}