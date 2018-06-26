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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSolicitudes = new Componentes.GrillaFormatead();
            this.dgvDetalle = new Componentes.GrillaFormatead();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.lblSolicitudes = new System.Windows.Forms.Label();
            this.btnRecibir = new System.Windows.Forms.Button();
            this.btnInconveniente = new System.Windows.Forms.Button();
            this.tbInconveniente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToResizeColumns = false;
            this.dgvSolicitudes.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitudes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Location = new System.Drawing.Point(12, 45);
            this.dgvSolicitudes.MultiSelect = false;
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            this.dgvSolicitudes.RowHeadersVisible = false;
            this.dgvSolicitudes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitudes.Size = new System.Drawing.Size(281, 312);
            this.dgvSolicitudes.TabIndex = 1;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToResizeColumns = false;
            this.dgvDetalle.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(336, 45);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(273, 312);
            this.dgvDetalle.TabIndex = 5;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(438, 11);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(66, 22);
            this.lblDetalles.TabIndex = 7;
            this.lblDetalles.Text = "Detalle";
            // 
            // lblSolicitudes
            // 
            this.lblSolicitudes.AutoSize = true;
            this.lblSolicitudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitudes.Location = new System.Drawing.Point(58, 11);
            this.lblSolicitudes.Name = "lblSolicitudes";
            this.lblSolicitudes.Size = new System.Drawing.Size(190, 22);
            this.lblSolicitudes.TabIndex = 6;
            this.lblSolicitudes.Text = "Solicitudes En Camino";
            // 
            // btnRecibir
            // 
            this.btnRecibir.Location = new System.Drawing.Point(187, 399);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(106, 67);
            this.btnRecibir.TabIndex = 8;
            this.btnRecibir.Text = "Recibido";
            this.btnRecibir.UseVisualStyleBackColor = true;
            this.btnRecibir.Click += new System.EventHandler(this.btnRecibir_Click);
            // 
            // btnInconveniente
            // 
            this.btnInconveniente.Location = new System.Drawing.Point(319, 399);
            this.btnInconveniente.Name = "btnInconveniente";
            this.btnInconveniente.Size = new System.Drawing.Size(93, 67);
            this.btnInconveniente.TabIndex = 8;
            this.btnInconveniente.Text = "Reportar Inconveniente";
            this.btnInconveniente.UseVisualStyleBackColor = true;
            this.btnInconveniente.Click += new System.EventHandler(this.btnInconveniente_Click);
            // 
            // tbInconveniente
            // 
            this.tbInconveniente.Location = new System.Drawing.Point(432, 399);
            this.tbInconveniente.Multiline = true;
            this.tbInconveniente.Name = "tbInconveniente";
            this.tbInconveniente.Size = new System.Drawing.Size(177, 67);
            this.tbInconveniente.TabIndex = 9;
            // 
            // frmEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 548);
            this.Controls.Add(this.tbInconveniente);
            this.Controls.Add(this.btnInconveniente);
            this.Controls.Add(this.btnRecibir);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.lblSolicitudes);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.dgvSolicitudes);
            this.Name = "frmEnvios";
            this.Text = "frmEnvios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEnvios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.GrillaFormatead dgvSolicitudes;
        private Componentes.GrillaFormatead dgvDetalle;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Label lblSolicitudes;
        private System.Windows.Forms.Button btnRecibir;
        private System.Windows.Forms.Button btnInconveniente;
        private System.Windows.Forms.TextBox tbInconveniente;
    }
}