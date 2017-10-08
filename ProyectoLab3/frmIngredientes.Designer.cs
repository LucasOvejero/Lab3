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
            this.btnAddIngrediente = new System.Windows.Forms.Button();
            this.tbNombreIngrediente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCostoPorKilo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvIngred = new Clases.GrillaFormateada();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoPorKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngred)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddIngrediente
            // 
            this.btnAddIngrediente.Location = new System.Drawing.Point(409, 33);
            this.btnAddIngrediente.Name = "btnAddIngrediente";
            this.btnAddIngrediente.Size = new System.Drawing.Size(75, 23);
            this.btnAddIngrediente.TabIndex = 0;
            this.btnAddIngrediente.Text = "Agregar";
            this.btnAddIngrediente.UseVisualStyleBackColor = true;
            this.btnAddIngrediente.Click += new System.EventHandler(this.btnAddIngrediente_Click);
            // 
            // tbNombreIngrediente
            // 
            this.tbNombreIngrediente.Location = new System.Drawing.Point(84, 36);
            this.tbNombreIngrediente.Name = "tbNombreIngrediente";
            this.tbNombreIngrediente.Size = new System.Drawing.Size(100, 20);
            this.tbNombreIngrediente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // nudCostoPorKilo
            // 
            this.nudCostoPorKilo.DecimalPlaces = 2;
            this.nudCostoPorKilo.Location = new System.Drawing.Point(240, 36);
            this.nudCostoPorKilo.Name = "nudCostoPorKilo";
            this.nudCostoPorKilo.Size = new System.Drawing.Size(94, 20);
            this.nudCostoPorKilo.TabIndex = 3;
            this.nudCostoPorKilo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Costo por Kilo";
            // 
            // dgvIngred
            // 
            this.dgvIngred.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngred.Location = new System.Drawing.Point(84, 159);
            this.dgvIngred.Name = "dgvIngred";
            this.dgvIngred.Size = new System.Drawing.Size(240, 150);
            this.dgvIngred.TabIndex = 5;
            // 
            // frmIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 526);
            this.Controls.Add(this.dgvIngred);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngred)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddIngrediente;
        private System.Windows.Forms.TextBox tbNombreIngrediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCostoPorKilo;
        private System.Windows.Forms.Label label2;     
        private Clases.GrillaFormateada dgvIngred;
        
    }
}