﻿namespace ProyectoLab3
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
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
            this.DgvSolicitudes.Size = new System.Drawing.Size(406, 360);
            this.DgvSolicitudes.TabIndex = 0;
            this.DgvSolicitudes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSolicitudes_CellContentClick);
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
            this.dgvDetalle.Size = new System.Drawing.Size(301, 360);
            this.dgvDetalle.TabIndex = 1;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(589, 11);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(66, 22);
            this.lblDetalles.TabIndex = 7;
            this.lblDetalles.Text = "Detalle";
            // 
            // lblSolicitudes
            // 
            this.lblSolicitudes.AutoSize = true;
            this.lblSolicitudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitudes.Location = new System.Drawing.Point(98, 11);
            this.lblSolicitudes.Name = "lblSolicitudes";
            this.lblSolicitudes.Size = new System.Drawing.Size(190, 22);
            this.lblSolicitudes.TabIndex = 6;
            this.lblSolicitudes.Text = "Solicitudes En Camino";
            // 
            // btnRecibir
            // 
            this.btnRecibir.Location = new System.Drawing.Point(138, 451);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(106, 67);
            this.btnRecibir.TabIndex = 2;
            this.btnRecibir.Text = "Recibido";
            this.btnRecibir.UseVisualStyleBackColor = true;
            this.btnRecibir.Click += new System.EventHandler(this.btnRecibir_Click);
            // 
            // btnInconveniente
            // 
            this.btnInconveniente.Enabled = false;
            this.btnInconveniente.Location = new System.Drawing.Point(458, 451);
            this.btnInconveniente.Name = "btnInconveniente";
            this.btnInconveniente.Size = new System.Drawing.Size(93, 67);
            this.btnInconveniente.TabIndex = 4;
            this.btnInconveniente.Text = "Reportar Inconveniente";
            this.btnInconveniente.UseVisualStyleBackColor = true;
            this.btnInconveniente.Click += new System.EventHandler(this.btnInconveniente_Click);
            // 
            // tbInconveniente
            // 
            this.tbInconveniente.Location = new System.Drawing.Point(557, 451);
            this.tbInconveniente.Multiline = true;
            this.tbInconveniente.Name = "tbInconveniente";
            this.tbInconveniente.Size = new System.Drawing.Size(215, 67);
            this.tbInconveniente.TabIndex = 3;
            this.tbInconveniente.TextChanged += new System.EventHandler(this.tbInconveniente_TextChanged);
            // 
            // frmEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tbInconveniente);
            this.Controls.Add(this.btnInconveniente);
            this.Controls.Add(this.btnRecibir);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.lblSolicitudes);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.DgvSolicitudes);
            this.Name = "frmEnvios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibos";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmEnvios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
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
    }
}