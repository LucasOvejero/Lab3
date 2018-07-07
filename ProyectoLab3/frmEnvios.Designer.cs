namespace ProyectoLab3
{
    partial class frmEnvios
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
            this.DgvSolicitudes = new Componentes.GrillaFormatead();
            this.dgvDetalle = new Componentes.GrillaFormatead();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.lblSolicitudes = new System.Windows.Forms.Label();
            this.btnRecibir = new System.Windows.Forms.Button();
            this.btnInconveniente = new System.Windows.Forms.Button();
            this.tbInconveniente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbDEscartar = new System.Windows.Forms.RadioButton();
            this.rbAceptar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvSolicitudes
            // 
            this.DgvSolicitudes.AllowUserToAddRows = false;
            this.DgvSolicitudes.AllowUserToResizeColumns = false;
            this.DgvSolicitudes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSolicitudes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSolicitudes.Location = new System.Drawing.Point(12, 45);
            this.DgvSolicitudes.MultiSelect = false;
            this.DgvSolicitudes.Name = "DgvSolicitudes";
            this.DgvSolicitudes.ReadOnly = true;
            this.DgvSolicitudes.RowHeadersVisible = false;
            this.DgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSolicitudes.Size = new System.Drawing.Size(343, 360);
            this.DgvSolicitudes.TabIndex = 1;
            this.DgvSolicitudes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSolicitudes_RowEnter);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToResizeColumns = false;
            this.dgvDetalle.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(458, 45);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(273, 360);
            this.dgvDetalle.TabIndex = 5;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(563, 11);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(66, 22);
            this.lblDetalles.TabIndex = 7;
            this.lblDetalles.Text = "Detalle";
            // 
            // lblSolicitudes
            // 
            this.lblSolicitudes.AutoSize = true;
            this.lblSolicitudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitudes.Location = new System.Drawing.Point(71, 11);
            this.lblSolicitudes.Name = "lblSolicitudes";
            this.lblSolicitudes.Size = new System.Drawing.Size(190, 22);
            this.lblSolicitudes.TabIndex = 6;
            this.lblSolicitudes.Text = "Solicitudes En Camino";
            // 
            // btnRecibir
            // 
            this.btnRecibir.Location = new System.Drawing.Point(102, 451);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(106, 67);
            this.btnRecibir.TabIndex = 8;
            this.btnRecibir.Text = "Recibido";
            this.btnRecibir.UseVisualStyleBackColor = true;
            this.btnRecibir.Click += new System.EventHandler(this.btnRecibir_Click);
            // 
            // btnInconveniente
            // 
            this.btnInconveniente.Location = new System.Drawing.Point(458, 427);
            this.btnInconveniente.Name = "btnInconveniente";
            this.btnInconveniente.Size = new System.Drawing.Size(93, 67);
            this.btnInconveniente.TabIndex = 8;
            this.btnInconveniente.Text = "Reportar Inconveniente";
            this.btnInconveniente.UseVisualStyleBackColor = true;
            this.btnInconveniente.Click += new System.EventHandler(this.btnInconveniente_Click);
            // 
            // tbInconveniente
            // 
            this.tbInconveniente.Location = new System.Drawing.Point(554, 427);
            this.tbInconveniente.Multiline = true;
            this.tbInconveniente.Name = "tbInconveniente";
            this.tbInconveniente.Size = new System.Drawing.Size(177, 67);
            this.tbInconveniente.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbAceptar);
            this.panel1.Controls.Add(this.rbDEscartar);
            this.panel1.Location = new System.Drawing.Point(458, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 36);
            this.panel1.TabIndex = 10;
            // 
            // rbDEscartar
            // 
            this.rbDEscartar.AutoSize = true;
            this.rbDEscartar.Location = new System.Drawing.Point(163, 10);
            this.rbDEscartar.Name = "rbDEscartar";
            this.rbDEscartar.Size = new System.Drawing.Size(99, 17);
            this.rbDEscartar.TabIndex = 0;
            this.rbDEscartar.TabStop = true;
            this.rbDEscartar.Text = "Descartar Todo";
            this.rbDEscartar.UseVisualStyleBackColor = true;
            // 
            // rbAceptar
            // 
            this.rbAceptar.AutoSize = true;
            this.rbAceptar.Location = new System.Drawing.Point(10, 10);
            this.rbAceptar.Name = "rbAceptar";
            this.rbAceptar.Size = new System.Drawing.Size(90, 17);
            this.rbAceptar.TabIndex = 0;
            this.rbAceptar.TabStop = true;
            this.rbAceptar.Text = "Aceptar Todo";
            this.rbAceptar.UseVisualStyleBackColor = true;
            // 
            // frmEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbInconveniente);
            this.Controls.Add(this.btnInconveniente);
            this.Controls.Add(this.btnRecibir);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.lblSolicitudes);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.DgvSolicitudes);
            this.Name = "frmEnvios";
            this.Text = "frmEnvios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEnvios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.GrillaFormatead DgvSolicitudes;
        private Componentes.GrillaFormatead dgvDetalle;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Label lblSolicitudes;
        private System.Windows.Forms.Button btnRecibir;
        private System.Windows.Forms.Button btnInconveniente;
        private System.Windows.Forms.TextBox tbInconveniente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbAceptar;
        private System.Windows.Forms.RadioButton rbDEscartar;
    }
}