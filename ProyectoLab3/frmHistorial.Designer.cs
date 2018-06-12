namespace ProyectoLab3
{
    partial class frmHistorial
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
            this.dgvDetalle = new Componentes.GrillaFormatead();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.dgvHistorial = new Componentes.GrillaFormatead();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbAmbas = new System.Windows.Forms.RadioButton();
            this.rbEnviadas = new System.Windows.Forms.RadioButton();
            this.rbRecibidas = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbTodoEstado = new System.Windows.Forms.RadioButton();
            this.rbRechazadas = new System.Windows.Forms.RadioButton();
            this.rbAceptadas = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToResizeColumns = false;
            this.dgvDetalle.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(494, 49);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(303, 534);
            this.dgvDetalle.TabIndex = 0;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaFormatead1_CellContentClick);
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.Location = new System.Drawing.Point(225, 9);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(99, 25);
            this.lblHistorial.TabIndex = 1;
            this.lblHistorial.Text = "Historial";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToResizeColumns = false;
            this.dgvHistorial.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(140, 49);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(302, 534);
            this.dgvHistorial.TabIndex = 0;
            this.dgvHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaFormatead1_CellContentClick);
            this.dgvHistorial.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHistorial_RowEnter);
            this.dgvHistorial.Sorted += new System.EventHandler(this.DgvHistorial_Sorted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(592, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalles";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbAmbas);
            this.panel1.Controls.Add(this.rbEnviadas);
            this.panel1.Controls.Add(this.rbRecibidas);
            this.panel1.Location = new System.Drawing.Point(12, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 94);
            this.panel1.TabIndex = 2;
            // 
            // rbAmbas
            // 
            this.rbAmbas.AutoSize = true;
            this.rbAmbas.Location = new System.Drawing.Point(3, 61);
            this.rbAmbas.Name = "rbAmbas";
            this.rbAmbas.Size = new System.Drawing.Size(57, 17);
            this.rbAmbas.TabIndex = 2;
            this.rbAmbas.TabStop = true;
            this.rbAmbas.Text = "Ambas";
            this.rbAmbas.UseVisualStyleBackColor = true;
            this.rbAmbas.CheckedChanged += new System.EventHandler(this.RbAmbas_CheckedChanged);
            // 
            // rbEnviadas
            // 
            this.rbEnviadas.AutoSize = true;
            this.rbEnviadas.Location = new System.Drawing.Point(3, 38);
            this.rbEnviadas.Name = "rbEnviadas";
            this.rbEnviadas.Size = new System.Drawing.Size(69, 17);
            this.rbEnviadas.TabIndex = 1;
            this.rbEnviadas.TabStop = true;
            this.rbEnviadas.Text = "Enviadas";
            this.rbEnviadas.UseVisualStyleBackColor = true;
            this.rbEnviadas.CheckedChanged += new System.EventHandler(this.RbEnviadas_CheckedChanged);
            // 
            // rbRecibidas
            // 
            this.rbRecibidas.AutoSize = true;
            this.rbRecibidas.Location = new System.Drawing.Point(3, 15);
            this.rbRecibidas.Name = "rbRecibidas";
            this.rbRecibidas.Size = new System.Drawing.Size(72, 17);
            this.rbRecibidas.TabIndex = 0;
            this.rbRecibidas.TabStop = true;
            this.rbRecibidas.Text = "Recibidas";
            this.rbRecibidas.UseVisualStyleBackColor = true;
            this.rbRecibidas.CheckedChanged += new System.EventHandler(this.RbRecibidas_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filtros";
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(12, 94);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(119, 20);
            this.tbFiltro.TabIndex = 3;
            this.tbFiltro.Visible = false;
            this.tbFiltro.TextChanged += new System.EventHandler(this.TbFiltro_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.rbTodoEstado);
            this.panel2.Controls.Add(this.rbRechazadas);
            this.panel2.Controls.Add(this.rbAceptadas);
            this.panel2.Location = new System.Drawing.Point(12, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 94);
            this.panel2.TabIndex = 2;
            // 
            // rbTodoEstado
            // 
            this.rbTodoEstado.AutoSize = true;
            this.rbTodoEstado.Location = new System.Drawing.Point(3, 61);
            this.rbTodoEstado.Name = "rbTodoEstado";
            this.rbTodoEstado.Size = new System.Drawing.Size(57, 17);
            this.rbTodoEstado.TabIndex = 2;
            this.rbTodoEstado.TabStop = true;
            this.rbTodoEstado.Text = "Ambas";
            this.rbTodoEstado.UseVisualStyleBackColor = true;
            this.rbTodoEstado.CheckedChanged += new System.EventHandler(this.RbTodoEstado_CheckedChanged);
            // 
            // rbRechazadas
            // 
            this.rbRechazadas.AutoSize = true;
            this.rbRechazadas.Location = new System.Drawing.Point(3, 38);
            this.rbRechazadas.Name = "rbRechazadas";
            this.rbRechazadas.Size = new System.Drawing.Size(85, 17);
            this.rbRechazadas.TabIndex = 1;
            this.rbRechazadas.TabStop = true;
            this.rbRechazadas.Text = "Rechazadas";
            this.rbRechazadas.UseVisualStyleBackColor = true;
            this.rbRechazadas.CheckedChanged += new System.EventHandler(this.RbRechazadas_CheckedChanged);
            // 
            // rbAceptadas
            // 
            this.rbAceptadas.AutoSize = true;
            this.rbAceptadas.Location = new System.Drawing.Point(3, 15);
            this.rbAceptadas.Name = "rbAceptadas";
            this.rbAceptadas.Size = new System.Drawing.Size(76, 17);
            this.rbAceptadas.TabIndex = 0;
            this.rbAceptadas.TabStop = true;
            this.rbAceptadas.Text = "Aceptadas";
            this.rbAceptadas.UseVisualStyleBackColor = true;
            this.rbAceptadas.CheckedChanged += new System.EventHandler(this.RbAceptadas_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Procedencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Estado";
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 588);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.dgvDetalle);
            this.Name = "frmHistorial";
            this.Text = "frmHistorial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.GrillaFormatead dgvDetalle;
        private System.Windows.Forms.Label lblHistorial;
        private Componentes.GrillaFormatead dgvHistorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbAmbas;
        private System.Windows.Forms.RadioButton rbEnviadas;
        private System.Windows.Forms.RadioButton rbRecibidas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbTodoEstado;
        private System.Windows.Forms.RadioButton rbRechazadas;
        private System.Windows.Forms.RadioButton rbAceptadas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}