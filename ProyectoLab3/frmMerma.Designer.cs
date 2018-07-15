namespace ProyectoLab3
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
            this.label7 = new System.Windows.Forms.Label();
            this.dgvSol = new Componentes.GrillaFormatead();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMermas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.pnlSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSol)).BeginInit();
            this.SuspendLayout();
            // 
            // rbIngrediente
            // 
            this.rbIngrediente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbIngrediente.AutoSize = true;
            this.rbIngrediente.Location = new System.Drawing.Point(27, 48);
            this.rbIngrediente.Name = "rbIngrediente";
            this.rbIngrediente.Size = new System.Drawing.Size(78, 17);
            this.rbIngrediente.TabIndex = 0;
            this.rbIngrediente.TabStop = true;
            this.rbIngrediente.Text = "Ingrediente";
            this.rbIngrediente.UseVisualStyleBackColor = true;
            this.rbIngrediente.CheckedChanged += new System.EventHandler(this.rbIngrediente_CheckedChanged);
            // 
            // rbBebida
            // 
            this.rbBebida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbBebida.AutoSize = true;
            this.rbBebida.Location = new System.Drawing.Point(27, 71);
            this.rbBebida.Name = "rbBebida";
            this.rbBebida.Size = new System.Drawing.Size(58, 17);
            this.rbBebida.TabIndex = 1;
            this.rbBebida.TabStop = true;
            this.rbBebida.Text = "Bebida";
            this.rbBebida.UseVisualStyleBackColor = true;
            // 
            // lbIngBeb
            // 
            this.lbIngBeb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbIngBeb.FormattingEnabled = true;
            this.lbIngBeb.Location = new System.Drawing.Point(125, 72);
            this.lbIngBeb.Name = "lbIngBeb";
            this.lbIngBeb.Size = new System.Drawing.Size(120, 95);
            this.lbIngBeb.TabIndex = 2;
            this.lbIngBeb.SelectedIndexChanged += new System.EventHandler(this.lbIngBeb_SelectedIndexChanged);
            // 
            // tbFiltro
            // 
            this.tbFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbFiltro.Location = new System.Drawing.Point(136, 42);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(100, 20);
            this.tbFiltro.TabIndex = 3;
            this.tbFiltro.TextChanged += new System.EventHandler(this.tbFiltro_TextChanged);
            // 
            // nupCantidad
            // 
            this.nupCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nupCantidad.Location = new System.Drawing.Point(261, 69);
            this.nupCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupCantidad.Name = "nupCantidad";
            this.nupCantidad.Size = new System.Drawing.Size(79, 20);
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
            this.lblMerma.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMerma.AutoSize = true;
            this.lblMerma.Location = new System.Drawing.Point(272, 48);
            this.lblMerma.Name = "lblMerma";
            this.lblMerma.Size = new System.Drawing.Size(54, 13);
            this.lblMerma.TabIndex = 5;
            this.lblMerma.Text = "Merma en";
            // 
            // tbFiltroNombre
            // 
            this.tbFiltroNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbFiltroNombre.Location = new System.Drawing.Point(357, 45);
            this.tbFiltroNombre.Name = "tbFiltroNombre";
            this.tbFiltroNombre.Size = new System.Drawing.Size(100, 20);
            this.tbFiltroNombre.TabIndex = 6;
            this.tbFiltroNombre.TextChanged += new System.EventHandler(this.tbFiltroNombre_TextChanged);
            // 
            // lbEmpleado
            // 
            this.lbEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEmpleado.FormattingEnabled = true;
            this.lbEmpleado.Location = new System.Drawing.Point(346, 72);
            this.lbEmpleado.Name = "lbEmpleado";
            this.lbEmpleado.Size = new System.Drawing.Size(120, 95);
            this.lbEmpleado.TabIndex = 7;
            this.lbEmpleado.SelectedIndexChanged += new System.EventHandler(this.lbEmpleado_SelectedIndexChanged);
            // 
            // tbMotivo
            // 
            this.tbMotivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMotivo.Location = new System.Drawing.Point(482, 72);
            this.tbMotivo.Multiline = true;
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.Size = new System.Drawing.Size(317, 95);
            this.tbMotivo.TabIndex = 8;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIngresar.AutoSize = true;
            this.btnIngresar.Location = new System.Drawing.Point(824, 87);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 68);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // dgvMermas
            // 
            this.dgvMermas.AllowUserToAddRows = false;
            this.dgvMermas.AllowUserToResizeColumns = false;
            this.dgvMermas.AllowUserToResizeRows = false;
            this.dgvMermas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.dgvMermas.Location = new System.Drawing.Point(27, 296);
            this.dgvMermas.MultiSelect = false;
            this.dgvMermas.Name = "dgvMermas";
            this.dgvMermas.ReadOnly = true;
            this.dgvMermas.RowHeadersVisible = false;
            this.dgvMermas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMermas.Size = new System.Drawing.Size(872, 244);
            this.dgvMermas.TabIndex = 10;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Responsable";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tipo de Producto";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Motivo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mermas Cargadas";
            // 
            // tbFiltroMerma
            // 
            this.tbFiltroMerma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFiltroMerma.Location = new System.Drawing.Point(275, 186);
            this.tbFiltroMerma.Name = "tbFiltroMerma";
            this.tbFiltroMerma.Size = new System.Drawing.Size(200, 20);
            this.tbFiltroMerma.TabIndex = 16;
            this.tbFiltroMerma.TextChanged += new System.EventHandler(this.tbFiltroMerma_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Filtro";
            // 
            // pnlSol
            // 
            this.pnlSol.Controls.Add(this.dgvSol);
            this.pnlSol.Controls.Add(this.label7);
            this.pnlSol.Location = new System.Drawing.Point(512, 170);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(287, 120);
            this.pnlSol.TabIndex = 19;
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
            this.dgvSol.Size = new System.Drawing.Size(249, 91);
            this.dgvSol.TabIndex = 20;
            // 
            // frmMerma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 565);
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
            this.Name = "frmMerma";
            this.Text = "Mermas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}