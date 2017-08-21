namespace ProyectoLab3
{
    partial class frmSucursales
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProvincia = new System.Windows.Forms.TextBox();
            this.btnAddProv = new System.Windows.Forms.Button();
            this.gpProv = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddLocalidad = new System.Windows.Forms.Button();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.dgvSucursal = new Clases.GrillaFormateada();
            this.dgvLocalidad = new Clases.GrillaFormateada();
            this.dgvProvincia = new Clases.GrillaFormateada();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddSucursal = new System.Windows.Forms.Button();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbDir = new System.Windows.Forms.RichTextBox();
            this.gpProv.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincia)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Provincias";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Localidades";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sucursales";
            // 
            // tbProvincia
            // 
            this.tbProvincia.Location = new System.Drawing.Point(6, 19);
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.Size = new System.Drawing.Size(100, 20);
            this.tbProvincia.TabIndex = 8;
            // 
            // btnAddProv
            // 
            this.btnAddProv.Location = new System.Drawing.Point(112, 19);
            this.btnAddProv.Name = "btnAddProv";
            this.btnAddProv.Size = new System.Drawing.Size(75, 23);
            this.btnAddProv.TabIndex = 9;
            this.btnAddProv.Text = "Agregar";
            this.btnAddProv.UseVisualStyleBackColor = true;
            this.btnAddProv.Click += new System.EventHandler(this.btnAddProv_Click);
            // 
            // gpProv
            // 
            this.gpProv.Controls.Add(this.btnAddProv);
            this.gpProv.Controls.Add(this.tbProvincia);
            this.gpProv.Location = new System.Drawing.Point(774, 102);
            this.gpProv.Name = "gpProv";
            this.gpProv.Size = new System.Drawing.Size(206, 53);
            this.gpProv.TabIndex = 10;
            this.gpProv.TabStop = false;
            this.gpProv.Text = "Provincia";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddLocalidad);
            this.groupBox1.Controls.Add(this.tbLocalidad);
            this.groupBox1.Location = new System.Drawing.Point(774, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 66);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localidad";
            // 
            // btnAddLocalidad
            // 
            this.btnAddLocalidad.Location = new System.Drawing.Point(112, 27);
            this.btnAddLocalidad.Name = "btnAddLocalidad";
            this.btnAddLocalidad.Size = new System.Drawing.Size(75, 23);
            this.btnAddLocalidad.TabIndex = 1;
            this.btnAddLocalidad.Text = "Agregar";
            this.btnAddLocalidad.UseVisualStyleBackColor = true;
            this.btnAddLocalidad.Click += new System.EventHandler(this.btnAddLocalidad_Click);
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(6, 27);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(100, 20);
            this.tbLocalidad.TabIndex = 0;
            // 
            // dgvSucursal
            // 
            this.dgvSucursal.AllowUserToAddRows = false;
            this.dgvSucursal.AllowUserToResizeColumns = false;
            this.dgvSucursal.AllowUserToResizeRows = false;
            this.dgvSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSucursal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucursal.Location = new System.Drawing.Point(378, 102);
            this.dgvSucursal.MultiSelect = false;
            this.dgvSucursal.Name = "dgvSucursal";
            this.dgvSucursal.ReadOnly = true;
            this.dgvSucursal.RowHeadersVisible = false;
            this.dgvSucursal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSucursal.Size = new System.Drawing.Size(359, 368);
            this.dgvSucursal.TabIndex = 2;
            // 
            // dgvLocalidad
            // 
            this.dgvLocalidad.AllowUserToAddRows = false;
            this.dgvLocalidad.AllowUserToResizeColumns = false;
            this.dgvLocalidad.AllowUserToResizeRows = false;
            this.dgvLocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalidad.Location = new System.Drawing.Point(221, 102);
            this.dgvLocalidad.MultiSelect = false;
            this.dgvLocalidad.Name = "dgvLocalidad";
            this.dgvLocalidad.ReadOnly = true;
            this.dgvLocalidad.RowHeadersVisible = false;
            this.dgvLocalidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalidad.Size = new System.Drawing.Size(124, 368);
            this.dgvLocalidad.TabIndex = 1;
            // 
            // dgvProvincia
            // 
            this.dgvProvincia.AllowUserToAddRows = false;
            this.dgvProvincia.AllowUserToResizeColumns = false;
            this.dgvProvincia.AllowUserToResizeRows = false;
            this.dgvProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProvincia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProvincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvincia.Location = new System.Drawing.Point(27, 102);
            this.dgvProvincia.MultiSelect = false;
            this.dgvProvincia.Name = "dgvProvincia";
            this.dgvProvincia.ReadOnly = true;
            this.dgvProvincia.RowHeadersVisible = false;
            this.dgvProvincia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvincia.Size = new System.Drawing.Size(120, 368);
            this.dgvProvincia.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbDir);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbTelefono);
            this.groupBox2.Controls.Add(this.btnAddSucursal);
            this.groupBox2.Location = new System.Drawing.Point(780, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 154);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sucursal";
            // 
            // btnAddSucursal
            // 
            this.btnAddSucursal.Location = new System.Drawing.Point(106, 124);
            this.btnAddSucursal.Name = "btnAddSucursal";
            this.btnAddSucursal.Size = new System.Drawing.Size(75, 23);
            this.btnAddSucursal.TabIndex = 0;
            this.btnAddSucursal.Text = "Agregar";
            this.btnAddSucursal.UseVisualStyleBackColor = true;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(81, 98);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono.TabIndex = 1;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dirección";
            // 
            // rtbDir
            // 
            this.rtbDir.Location = new System.Drawing.Point(19, 32);
            this.rtbDir.Name = "rtbDir";
            this.rtbDir.Size = new System.Drawing.Size(162, 60);
            this.rtbDir.TabIndex = 4;
            this.rtbDir.Text = "";
            // 
            // frmSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 482);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpProv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSucursal);
            this.Controls.Add(this.dgvLocalidad);
            this.Controls.Add(this.dgvProvincia);
            this.Name = "frmSucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucursales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSucursales_Load);
            this.gpProv.ResumeLayout(false);
            this.gpProv.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.GrillaFormateada dgvProvincia;
        private Clases.GrillaFormateada dgvLocalidad;
        private Clases.GrillaFormateada dgvSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProvincia;
        private System.Windows.Forms.Button btnAddProv;
        private System.Windows.Forms.GroupBox gpProv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddLocalidad;
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddSucursal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.RichTextBox rtbDir;
        private System.Windows.Forms.Label label5;
    }
}