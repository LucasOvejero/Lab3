namespace ProyectoLab3
{
    partial class frmBebidas
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
            this.dgvBebidas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.nudCosto = new System.Windows.Forms.NumericUpDown();
            this.nudLitros = new System.Windows.Forms.NumericUpDown();
            this.cbAlcohol = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLitros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBebidas
            // 
            this.dgvBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBebidas.Location = new System.Drawing.Point(28, 148);
            this.dgvBebidas.Name = "dgvBebidas";
            this.dgvBebidas.Size = new System.Drawing.Size(773, 319);
            this.dgvBebidas.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(700, 36);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(66, 39);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(205, 39);
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(74, 20);
            this.nudPrecio.TabIndex = 3;
            // 
            // nudCosto
            // 
            this.nudCosto.Location = new System.Drawing.Point(322, 40);
            this.nudCosto.Name = "nudCosto";
            this.nudCosto.Size = new System.Drawing.Size(61, 20);
            this.nudCosto.TabIndex = 4;
            // 
            // nudLitros
            // 
            this.nudLitros.Location = new System.Drawing.Point(442, 39);
            this.nudLitros.Name = "nudLitros";
            this.nudLitros.Size = new System.Drawing.Size(61, 20);
            this.nudLitros.TabIndex = 5;
            // 
            // cbAlcohol
            // 
            this.cbAlcohol.AutoSize = true;
            this.cbAlcohol.Location = new System.Drawing.Point(565, 42);
            this.cbAlcohol.Name = "cbAlcohol";
            this.cbAlcohol.Size = new System.Drawing.Size(61, 17);
            this.cbAlcohol.TabIndex = 6;
            this.cbAlcohol.Text = "Alcohol";
            this.cbAlcohol.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Litros";
            // 
            // frmBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 479);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAlcohol);
            this.Controls.Add(this.nudLitros);
            this.Controls.Add(this.nudCosto);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvBebidas);
            this.Name = "frmBebidas";
            this.Text = "Bebidas";
            this.Load += new System.EventHandler(this.frmBebidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLitros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBebidas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.NumericUpDown nudCosto;
        private System.Windows.Forms.NumericUpDown nudLitros;
        private System.Windows.Forms.CheckBox cbAlcohol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}