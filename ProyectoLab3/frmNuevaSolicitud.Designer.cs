﻿
namespace ProyectoLab3
{
    partial class frmNuevaSolicitud
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSucursales = new Componentes.GrillaFormatead();
            this.tbBusquedaSucursal = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.dgvIngredientes = new Componentes.GrillaFormatead();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBusquedaIngrediente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvSeleccion = new Componentes.GrillaFormatead();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSucursales
            // 
            this.dgvSucursales.AllowUserToAddRows = false;
            this.dgvSucursales.AllowUserToResizeColumns = false;
            this.dgvSucursales.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSucursales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucursales.Location = new System.Drawing.Point(12, 69);
            this.dgvSucursales.MultiSelect = false;
            this.dgvSucursales.Name = "dgvSucursales";
            this.dgvSucursales.ReadOnly = true;
            this.dgvSucursales.RowHeadersVisible = false;
            this.dgvSucursales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSucursales.Size = new System.Drawing.Size(200, 318);
            this.dgvSucursales.TabIndex = 2;
            this.dgvSucursales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSucursales_CellContentClick);
            // 
            // tbBusquedaSucursal
            // 
            this.tbBusquedaSucursal.Location = new System.Drawing.Point(40, 43);
            this.tbBusquedaSucursal.Name = "tbBusquedaSucursal";
            this.tbBusquedaSucursal.Size = new System.Drawing.Size(141, 20);
            this.tbBusquedaSucursal.TabIndex = 0;
            this.tbBusquedaSucursal.TextChanged += new System.EventHandler(this.tbBusquedaSucursal_TextChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(69, 27);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(84, 13);
            this.lblBusqueda.TabIndex = 11;
            this.lblBusqueda.Text = "Buscar Sucursal";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(79, 9);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(66, 18);
            this.lblSucursal.TabIndex = 9;
            this.lblSucursal.Text = "Sucursal";
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.AllowUserToAddRows = false;
            this.dgvIngredientes.AllowUserToResizeColumns = false;
            this.dgvIngredientes.AllowUserToResizeRows = false;
            this.dgvIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngredientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Location = new System.Drawing.Point(218, 69);
            this.dgvIngredientes.MultiSelect = false;
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.ReadOnly = true;
            this.dgvIngredientes.RowHeadersVisible = false;
            this.dgvIngredientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvIngredientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngredientes.Size = new System.Drawing.Size(161, 318);
            this.dgvIngredientes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ingredientes";
            // 
            // tbBusquedaIngrediente
            // 
            this.tbBusquedaIngrediente.Location = new System.Drawing.Point(218, 43);
            this.tbBusquedaIngrediente.Name = "tbBusquedaIngrediente";
            this.tbBusquedaIngrediente.Size = new System.Drawing.Size(141, 20);
            this.tbBusquedaIngrediente.TabIndex = 1;
            this.tbBusquedaIngrediente.TextChanged += new System.EventHandler(this.tbBusquedaIngrediente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Buscar Ingrediente";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(411, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 34);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvSeleccion
            // 
            this.dgvSeleccion.AllowUserToAddRows = false;
            this.dgvSeleccion.AllowUserToResizeColumns = false;
            this.dgvSeleccion.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeleccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSeleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccion.Location = new System.Drawing.Point(489, 69);
            this.dgvSeleccion.MultiSelect = false;
            this.dgvSeleccion.Name = "dgvSeleccion";
            this.dgvSeleccion.ReadOnly = true;
            this.dgvSeleccion.RowHeadersVisible = false;
            this.dgvSeleccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSeleccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeleccion.Size = new System.Drawing.Size(271, 318);
            this.dgvSeleccion.TabIndex = 7;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(411, 223);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(35, 35);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(394, 128);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(76, 26);
            this.lblCantidad.TabIndex = 18;
            this.lblCantidad.Text = "Cantidad \r\n(gr/ml/Unidad)";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(383, 157);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 20);
            this.tbCantidad.TabIndex = 4;
            this.tbCantidad.TextChanged += new System.EventHandler(this.tbCantidad_TextChanged);
            this.tbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidad_KeyPress);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(577, 393);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(115, 47);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar Solicitud";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmNuevaSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbBusquedaIngrediente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSeleccion);
            this.Controls.Add(this.dgvIngredientes);
            this.Controls.Add(this.dgvSucursales);
            this.Controls.Add(this.tbBusquedaSucursal);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblSucursal);
            this.Name = "frmNuevaSolicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNuevaSolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.GrillaFormatead dgvSucursales;
        private System.Windows.Forms.TextBox tbBusquedaSucursal;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblSucursal;
        private Componentes.GrillaFormatead dgvIngredientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBusquedaIngrediente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private Componentes.GrillaFormatead dgvSeleccion;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Button btnEnviar;
    }
}