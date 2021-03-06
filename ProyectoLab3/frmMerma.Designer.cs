﻿namespace ProyectoLab3
{
    partial class frmMerma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbIngrediente = new System.Windows.Forms.RadioButton();
            this.rbBebida = new System.Windows.Forms.RadioButton();
            this.lbIngBeb = new System.Windows.Forms.ListBox();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.nupCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblMerma = new System.Windows.Forms.Label();
            this.tbFiltroNombre = new System.Windows.Forms.TextBox();
            this.lbEmpleado = new System.Windows.Forms.ListBox();
            this.tbMotivo = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.dgvMermas = new Componentes.GrillaFormatead();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFiltroMerma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlSol = new System.Windows.Forms.Panel();
            this.dgvSol = new Componentes.GrillaFormatead();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMermas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.pnlSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSol)).BeginInit();
            this.SuspendLayout();
            // 
            // rbIngrediente
            // 
            this.rbIngrediente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbIngrediente.AutoSize = true;
            this.rbIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIngrediente.Location = new System.Drawing.Point(91, 56);
            this.rbIngrediente.Name = "rbIngrediente";
            this.rbIngrediente.Size = new System.Drawing.Size(108, 24);
            this.rbIngrediente.TabIndex = 0;
            this.rbIngrediente.TabStop = true;
            this.rbIngrediente.Text = "Ingrediente";
            this.rbIngrediente.UseVisualStyleBackColor = true;
            this.rbIngrediente.CheckedChanged += new System.EventHandler(this.rbIngrediente_CheckedChanged);
            // 
            // rbBebida
            // 
            this.rbBebida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbBebida.AutoSize = true;
            this.rbBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBebida.Location = new System.Drawing.Point(91, 79);
            this.rbBebida.Name = "rbBebida";
            this.rbBebida.Size = new System.Drawing.Size(77, 24);
            this.rbBebida.TabIndex = 1;
            this.rbBebida.TabStop = true;
            this.rbBebida.Text = "Bebida";
            this.rbBebida.UseVisualStyleBackColor = true;
            // 
            // lbIngBeb
            // 
            this.lbIngBeb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbIngBeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngBeb.FormattingEnabled = true;
            this.lbIngBeb.ItemHeight = 20;
            this.lbIngBeb.Location = new System.Drawing.Point(248, 58);
            this.lbIngBeb.Name = "lbIngBeb";
            this.lbIngBeb.Size = new System.Drawing.Size(120, 84);
            this.lbIngBeb.TabIndex = 3;
            this.lbIngBeb.SelectedIndexChanged += new System.EventHandler(this.lbIngBeb_SelectedIndexChanged);
            // 
            // tbFiltro
            // 
            this.tbFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.Location = new System.Drawing.Point(259, 28);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(100, 26);
            this.tbFiltro.TabIndex = 2;
            this.tbFiltro.TextChanged += new System.EventHandler(this.tbFiltro_TextChanged);
            // 
            // nupCantidad
            // 
            this.nupCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nupCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCantidad.Location = new System.Drawing.Point(384, 58);
            this.nupCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupCantidad.Name = "nupCantidad";
            this.nupCantidad.Size = new System.Drawing.Size(79, 26);
            this.nupCantidad.TabIndex = 4;
            this.nupCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupCantidad.ValueChanged += new System.EventHandler(this.nupCantidad_ValueChanged);
            // 
            // lblMerma
            // 
            this.lblMerma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMerma.AutoSize = true;
            this.lblMerma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerma.Location = new System.Drawing.Point(382, 34);
            this.lblMerma.Name = "lblMerma";
            this.lblMerma.Size = new System.Drawing.Size(80, 20);
            this.lblMerma.TabIndex = 5;
            this.lblMerma.Text = "Merma en";
            // 
            // tbFiltroNombre
            // 
            this.tbFiltroNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltroNombre.Location = new System.Drawing.Point(494, 26);
            this.tbFiltroNombre.Name = "tbFiltroNombre";
            this.tbFiltroNombre.Size = new System.Drawing.Size(100, 26);
            this.tbFiltroNombre.TabIndex = 5;
            this.tbFiltroNombre.TextChanged += new System.EventHandler(this.tbFiltroNombre_TextChanged);
            // 
            // lbEmpleado
            // 
            this.lbEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpleado.FormattingEnabled = true;
            this.lbEmpleado.ItemHeight = 20;
            this.lbEmpleado.Location = new System.Drawing.Point(483, 58);
            this.lbEmpleado.Name = "lbEmpleado";
            this.lbEmpleado.Size = new System.Drawing.Size(120, 84);
            this.lbEmpleado.TabIndex = 6;
            this.lbEmpleado.SelectedIndexChanged += new System.EventHandler(this.lbEmpleado_SelectedIndexChanged);
            // 
            // tbMotivo
            // 
            this.tbMotivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMotivo.Location = new System.Drawing.Point(187, 177);
            this.tbMotivo.Multiline = true;
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.Size = new System.Drawing.Size(288, 44);
            this.tbMotivo.TabIndex = 7;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresar.AutoSize = true;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(504, 175);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(122, 46);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // dgvMermas
            // 
            this.dgvMermas.AllowUserToAddRows = false;
            this.dgvMermas.AllowUserToResizeColumns = false;
            this.dgvMermas.AllowUserToResizeRows = false;
            this.dgvMermas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMermas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMermas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMermas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMermas.Location = new System.Drawing.Point(277, 285);
            this.dgvMermas.MultiSelect = false;
            this.dgvMermas.Name = "dgvMermas";
            this.dgvMermas.ReadOnly = true;
            this.dgvMermas.RowHeadersVisible = false;
            this.dgvMermas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMermas.Size = new System.Drawing.Size(493, 240);
            this.dgvMermas.TabIndex = 10;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Responsable";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tipo de Producto";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Motivo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(323, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mermas Cargadas";
            // 
            // tbFiltroMerma
            // 
            this.tbFiltroMerma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFiltroMerma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltroMerma.Location = new System.Drawing.Point(468, 255);
            this.tbFiltroMerma.Name = "tbFiltroMerma";
            this.tbFiltroMerma.Size = new System.Drawing.Size(200, 26);
            this.tbFiltroMerma.TabIndex = 9;
            this.tbFiltroMerma.TextChanged += new System.EventHandler(this.tbFiltroMerma_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Filtro";
            // 
            // pnlSol
            // 
            this.pnlSol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSol.Controls.Add(this.dgvSol);
            this.pnlSol.Controls.Add(this.label7);
            this.pnlSol.Location = new System.Drawing.Point(12, 285);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(259, 240);
            this.pnlSol.TabIndex = 19;
            // 
            // dgvSol
            // 
            this.dgvSol.AllowUserToAddRows = false;
            this.dgvSol.AllowUserToResizeColumns = false;
            this.dgvSol.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSol.Location = new System.Drawing.Point(21, 21);
            this.dgvSol.MultiSelect = false;
            this.dgvSol.Name = "dgvSol";
            this.dgvSol.ReadOnly = true;
            this.dgvSol.RowHeadersVisible = false;
            this.dgvSol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSol.Size = new System.Drawing.Size(214, 216);
            this.dgvSol.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Detalle de la Solicitud";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(87, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Merma De Solicitud";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 26);
            this.label9.TabIndex = 20;
            this.label9.Text = "La merma no pertenece\r\na ninguna solicitud realizada.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMerma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlSol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbFiltroMerma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMermas);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.tbMotivo);
            this.Controls.Add(this.lbEmpleado);
            this.Controls.Add(this.tbFiltroNombre);
            this.Controls.Add(this.lblMerma);
            this.Controls.Add(this.nupCantidad);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.lbIngBeb);
            this.Controls.Add(this.rbBebida);
            this.Controls.Add(this.rbIngrediente);
            this.Controls.Add(this.label9);
            this.Name = "frmMerma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mermas";
            this.Load += new System.EventHandler(this.frmMerma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMermas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.pnlSol.ResumeLayout(false);
            this.pnlSol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbIngrediente;
        private System.Windows.Forms.RadioButton rbBebida;
        private System.Windows.Forms.ListBox lbIngBeb;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.NumericUpDown nupCantidad;
        private System.Windows.Forms.Label lblMerma;
        private System.Windows.Forms.TextBox tbFiltroNombre;
        private System.Windows.Forms.ListBox lbEmpleado;
        private System.Windows.Forms.TextBox tbMotivo;
        private System.Windows.Forms.Button btnIngresar;
        private Componentes.GrillaFormatead dgvMermas;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFiltroMerma;
        private System.Windows.Forms.Panel pnlSol;
        private System.Windows.Forms.Label label7;
        private Componentes.GrillaFormatead dgvSol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}