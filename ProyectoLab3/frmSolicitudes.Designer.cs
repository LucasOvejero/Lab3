namespace ProyectoLab3
{
    partial class FrmSolicitudes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSolicitudes = new Componentes.GrillaFormatead();
            this.dgvPeticiones = new Componentes.GrillaFormatead();
            this.lblPeticiones = new System.Windows.Forms.Label();
            this.lblSolicitudes = new System.Windows.Forms.Label();
            this.grillaFormatead1 = new Componentes.GrillaFormatead();
            this.dgvDetalle = new Componentes.GrillaFormatead();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlAceptarRechazar = new System.Windows.Forms.Panel();
            this.btnEnvios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeticiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaFormatead1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.pnlAceptarRechazar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToResizeColumns = false;
            this.dgvSolicitudes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitudes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Location = new System.Drawing.Point(12, 42);
            this.dgvSolicitudes.MultiSelect = false;
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            this.dgvSolicitudes.RowHeadersVisible = false;
            this.dgvSolicitudes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitudes.Size = new System.Drawing.Size(397, 233);
            this.dgvSolicitudes.TabIndex = 0;
            this.dgvSolicitudes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSolicitudes_CellContentClick);
            this.dgvSolicitudes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSolicitudes_RowEnter);
            // 
            // dgvPeticiones
            // 
            this.dgvPeticiones.AllowUserToAddRows = false;
            this.dgvPeticiones.AllowUserToResizeColumns = false;
            this.dgvPeticiones.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeticiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPeticiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeticiones.Location = new System.Drawing.Point(12, 312);
            this.dgvPeticiones.MultiSelect = false;
            this.dgvPeticiones.Name = "dgvPeticiones";
            this.dgvPeticiones.ReadOnly = true;
            this.dgvPeticiones.RowHeadersVisible = false;
            this.dgvPeticiones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPeticiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeticiones.Size = new System.Drawing.Size(397, 158);
            this.dgvPeticiones.TabIndex = 1;
            this.dgvPeticiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeticiones_CellContentClick);
            this.dgvPeticiones.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPeticiones_RowEnter);
            // 
            // lblPeticiones
            // 
            this.lblPeticiones.AutoSize = true;
            this.lblPeticiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeticiones.Location = new System.Drawing.Point(39, 287);
            this.lblPeticiones.Name = "lblPeticiones";
            this.lblPeticiones.Size = new System.Drawing.Size(313, 22);
            this.lblPeticiones.TabIndex = 2;
            this.lblPeticiones.Text = "Mis Solicitudes Envidadas Pendientes";
            // 
            // lblSolicitudes
            // 
            this.lblSolicitudes.AutoSize = true;
            this.lblSolicitudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitudes.Location = new System.Drawing.Point(84, 17);
            this.lblSolicitudes.Name = "lblSolicitudes";
            this.lblSolicitudes.Size = new System.Drawing.Size(213, 22);
            this.lblSolicitudes.TabIndex = 3;
            this.lblSolicitudes.Text = "Mis Solicitudes Recibidas";
            // 
            // grillaFormatead1
            // 
            this.grillaFormatead1.AllowUserToAddRows = false;
            this.grillaFormatead1.AllowUserToResizeColumns = false;
            this.grillaFormatead1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaFormatead1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grillaFormatead1.Location = new System.Drawing.Point(0, 0);
            this.grillaFormatead1.MultiSelect = false;
            this.grillaFormatead1.Name = "grillaFormatead1";
            this.grillaFormatead1.ReadOnly = true;
            this.grillaFormatead1.RowHeadersVisible = false;
            this.grillaFormatead1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaFormatead1.Size = new System.Drawing.Size(240, 150);
            this.grillaFormatead1.TabIndex = 0;
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
            this.dgvDetalle.Location = new System.Drawing.Point(488, 42);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(287, 428);
            this.dgvDetalle.TabIndex = 4;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(599, 17);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(75, 22);
            this.lblDetalles.TabIndex = 5;
            this.lblDetalles.Text = "Detalles";
            // 
            // btnAccept
            // 
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccept.Location = new System.Drawing.Point(27, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(90, 48);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "ENVIAR";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Location = new System.Drawing.Point(177, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 48);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "RECHAZAR";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // pnlAceptarRechazar
            // 
            this.pnlAceptarRechazar.Controls.Add(this.btnAccept);
            this.pnlAceptarRechazar.Controls.Add(this.btnCancel);
            this.pnlAceptarRechazar.Location = new System.Drawing.Point(488, 492);
            this.pnlAceptarRechazar.Name = "pnlAceptarRechazar";
            this.pnlAceptarRechazar.Size = new System.Drawing.Size(287, 72);
            this.pnlAceptarRechazar.TabIndex = 8;
            // 
            // btnEnvios
            // 
            this.btnEnvios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnvios.Location = new System.Drawing.Point(125, 492);
            this.btnEnvios.Name = "btnEnvios";
            this.btnEnvios.Size = new System.Drawing.Size(118, 48);
            this.btnEnvios.TabIndex = 6;
            this.btnEnvios.Text = "Reportar Solicitud";
            this.btnEnvios.UseVisualStyleBackColor = true;
            this.btnEnvios.Click += new System.EventHandler(this.btnEnvios_Click);
            // 
            // FrmSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 602);
            this.Controls.Add(this.btnEnvios);
            this.Controls.Add(this.pnlAceptarRechazar);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.lblSolicitudes);
            this.Controls.Add(this.lblPeticiones);
            this.Controls.Add(this.dgvPeticiones);
            this.Controls.Add(this.dgvSolicitudes);
            this.Name = "FrmSolicitudes";
            this.Text = "Solicitudes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSolicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeticiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaFormatead1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.pnlAceptarRechazar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.GrillaFormatead dgvSolicitudes;
        private Componentes.GrillaFormatead dgvPeticiones;
        private System.Windows.Forms.Label lblPeticiones;
        private System.Windows.Forms.Label lblSolicitudes;

        private Componentes.GrillaFormatead grillaFormatead1;

        private Componentes.GrillaFormatead dgvDetalle;

        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlAceptarRechazar;
        private System.Windows.Forms.Button btnEnvios;
    }
}