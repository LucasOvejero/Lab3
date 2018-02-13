
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSucursales = new Clases.GrillaFormatead();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursales)).BeginInit();
            this.SuspendLayout();
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
            this.dgvSucursales.Location = new System.Drawing.Point(233, 96);
            this.dgvSucursales.MultiSelect = false;
            this.dgvSucursales.Name = "dgvSucursales";
            this.dgvSucursales.ReadOnly = true;
            this.dgvSucursales.RowHeadersVisible = false;
            this.dgvSucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSucursales.Size = new System.Drawing.Size(141, 191);
            this.dgvSucursales.TabIndex = 10;
            this.dgvSucursales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSucursales_CellContentClick);
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(233, 69);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(141, 20);
            this.tbBusqueda.TabIndex = 8;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(257, 46);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(91, 13);
            this.lblBusqueda.TabIndex = 11;
            this.lblBusqueda.Text = "Buscar Direccion:";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(268, 22);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(66, 18);
            this.lblSucursal.TabIndex = 9;
            this.lblSucursal.Text = "Sucursal";
            // 
            // frmNuevaSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 506);
            this.Controls.Add(this.dgvSucursales);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblSucursal);
            this.Name = "frmNuevaSolicitud";
            this.Text = "Nueva Solicitud";
            this.Load += new System.EventHandler(this.frmNuevaSolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.GrillaFormatead dgvSucursales;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblSucursal;
    }
}