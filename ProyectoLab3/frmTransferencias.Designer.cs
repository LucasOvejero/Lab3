namespace ProyectoLab3
{
    partial class frmTransferencias
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
            this.dgvTransferencia = new Componentes.GrillaFormatead();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFiltroTransferencia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransferencia
            // 
            this.dgvTransferencia.AllowUserToAddRows = false;
            this.dgvTransferencia.AllowUserToResizeColumns = false;
            this.dgvTransferencia.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransferencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransferencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferencia.Location = new System.Drawing.Point(0, 97);
            this.dgvTransferencia.MultiSelect = false;
            this.dgvTransferencia.Name = "dgvTransferencia";
            this.dgvTransferencia.ReadOnly = true;
            this.dgvTransferencia.RowHeadersVisible = false;
            this.dgvTransferencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransferencia.Size = new System.Drawing.Size(700, 464);
            this.dgvTransferencia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar";
            // 
            // tbFiltroTransferencia
            // 
            this.tbFiltroTransferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFiltroTransferencia.Location = new System.Drawing.Point(275, 71);
            this.tbFiltroTransferencia.Name = "tbFiltroTransferencia";
            this.tbFiltroTransferencia.Size = new System.Drawing.Size(141, 20);
            this.tbFiltroTransferencia.TabIndex = 2;
            this.tbFiltroTransferencia.TextChanged += new System.EventHandler(this.tbFiltroTransferencia_TextChanged);
            // 
            // frmTransferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 528);
            this.Controls.Add(this.tbFiltroTransferencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTransferencia);
            this.Name = "frmTransferencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferencias";
            this.Load += new System.EventHandler(this.frmTransferencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.GrillaFormatead dgvTransferencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFiltroTransferencia;
    }
}