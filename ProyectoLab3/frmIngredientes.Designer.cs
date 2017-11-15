namespace ProyectoLab3
{
    partial class frmIngredientes
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
            this.btnAddIngrediente = new System.Windows.Forms.Button();
            this.tbNombreIngrediente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCostoPorKilo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSucursales = new System.Windows.Forms.ListBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.dgvIngredientes = new Clases.GrillaFormatead();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoPorKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddIngrediente
            // 
            this.btnAddIngrediente.Location = new System.Drawing.Point(138, 62);
            this.btnAddIngrediente.Name = "btnAddIngrediente";
            this.btnAddIngrediente.Size = new System.Drawing.Size(75, 23);
            this.btnAddIngrediente.TabIndex = 0;
            this.btnAddIngrediente.Text = "Agregar";
            this.btnAddIngrediente.UseVisualStyleBackColor = true;
            this.btnAddIngrediente.Click += new System.EventHandler(this.btnAddIngrediente_Click);
            // 
            // tbNombreIngrediente
            // 
            this.tbNombreIngrediente.Location = new System.Drawing.Point(47, 36);
            this.tbNombreIngrediente.Name = "tbNombreIngrediente";
            this.tbNombreIngrediente.Size = new System.Drawing.Size(100, 20);
            this.tbNombreIngrediente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // nudCostoPorKilo
            // 
            this.nudCostoPorKilo.DecimalPlaces = 2;
            this.nudCostoPorKilo.Location = new System.Drawing.Point(203, 36);
            this.nudCostoPorKilo.Name = "nudCostoPorKilo";
            this.nudCostoPorKilo.Size = new System.Drawing.Size(94, 20);
            this.nudCostoPorKilo.TabIndex = 3;
            this.nudCostoPorKilo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Costo por Kilo";
            // 
            // lbSucursales
            // 
            this.lbSucursales.FormattingEnabled = true;
            this.lbSucursales.Location = new System.Drawing.Point(442, 91);
            this.lbSucursales.Name = "lbSucursales";
            this.lbSucursales.Size = new System.Drawing.Size(120, 95);
            this.lbSucursales.TabIndex = 6;
            // 
            // cboProvincia
            // 
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(442, 62);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(121, 21);
            this.cboProvincia.TabIndex = 7;
            this.cboProvincia.SelectedIndexChanged += new System.EventHandler(this.cboProvincia_SelectedIndexChanged);
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.AllowUserToAddRows = false;
            this.dgvIngredientes.AllowUserToResizeColumns = false;
            this.dgvIngredientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngredientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Location = new System.Drawing.Point(36, 91);
            this.dgvIngredientes.MultiSelect = false;
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.ReadOnly = true;
            this.dgvIngredientes.RowHeadersVisible = false;
            this.dgvIngredientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngredientes.Size = new System.Drawing.Size(287, 228);
            this.dgvIngredientes.TabIndex = 5;
            // 
            // frmIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 526);
            this.Controls.Add(this.cboProvincia);
            this.Controls.Add(this.lbSucursales);
            this.Controls.Add(this.dgvIngredientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudCostoPorKilo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombreIngrediente);
            this.Controls.Add(this.btnAddIngrediente);
            this.Name = "frmIngredientes";
            this.Text = "Ingredientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmIngredientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoPorKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddIngrediente;
        private System.Windows.Forms.TextBox tbNombreIngrediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCostoPorKilo;
        private System.Windows.Forms.Label label2;
        private Clases.GrillaFormatead dgvIngredientes;
        private System.Windows.Forms.ListBox lbSucursales;
        private System.Windows.Forms.ComboBox cboProvincia;
        
    }
}