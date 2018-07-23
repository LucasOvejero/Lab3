namespace ProyectoLab3
{
    partial class frmCrearPlatoSeleccionIng
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbIngredientes = new System.Windows.Forms.ListBox();
            this.btnAgregarIngredientes = new System.Windows.Forms.Button();
            this.btnQuitarIngredientes = new System.Windows.Forms.Button();
            this.lbIngredientesDelPlato = new System.Windows.Forms.ListBox();
            this.pnlIngredientes = new System.Windows.Forms.Panel();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccioné los ingredientes";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(12, 44);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 0;
            this.cboCategoria.SelectedValueChanged += new System.EventHandler(this.cboCategoria_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria";
            // 
            // lbIngredientes
            // 
            this.lbIngredientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbIngredientes.FormattingEnabled = true;
            this.lbIngredientes.Location = new System.Drawing.Point(12, 116);
            this.lbIngredientes.Name = "lbIngredientes";
            this.lbIngredientes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbIngredientes.Size = new System.Drawing.Size(120, 212);
            this.lbIngredientes.TabIndex = 1;
            // 
            // btnAgregarIngredientes
            // 
            this.btnAgregarIngredientes.Location = new System.Drawing.Point(142, 148);
            this.btnAgregarIngredientes.Name = "btnAgregarIngredientes";
            this.btnAgregarIngredientes.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarIngredientes.TabIndex = 2;
            this.btnAgregarIngredientes.Text = ">>>";
            this.btnAgregarIngredientes.UseVisualStyleBackColor = true;
            this.btnAgregarIngredientes.Click += new System.EventHandler(this.btnAgregarIngredientes_Click);
            // 
            // btnQuitarIngredientes
            // 
            this.btnQuitarIngredientes.Location = new System.Drawing.Point(142, 204);
            this.btnQuitarIngredientes.Name = "btnQuitarIngredientes";
            this.btnQuitarIngredientes.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarIngredientes.TabIndex = 3;
            this.btnQuitarIngredientes.Text = "<<<";
            this.btnQuitarIngredientes.UseVisualStyleBackColor = true;
            this.btnQuitarIngredientes.Click += new System.EventHandler(this.btnQuitarIngredientes_Click);
            // 
            // lbIngredientesDelPlato
            // 
            this.lbIngredientesDelPlato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbIngredientesDelPlato.FormattingEnabled = true;
            this.lbIngredientesDelPlato.Location = new System.Drawing.Point(239, 116);
            this.lbIngredientesDelPlato.Name = "lbIngredientesDelPlato";
            this.lbIngredientesDelPlato.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbIngredientesDelPlato.Size = new System.Drawing.Size(120, 212);
            this.lbIngredientesDelPlato.TabIndex = 4;
            // 
            // pnlIngredientes
            // 
            this.pnlIngredientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlIngredientes.AutoScroll = true;
            this.pnlIngredientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlIngredientes.Location = new System.Drawing.Point(381, 28);
            this.pnlIngredientes.Name = "pnlIngredientes";
            this.pnlIngredientes.Size = new System.Drawing.Size(391, 297);
            this.pnlIngredientes.TabIndex = 5;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(526, 331);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(109, 56);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ingredientes";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 42);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ingredientes del plato";
            // 
            // frmCrearPlatoSeleccionIng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.pnlIngredientes);
            this.Controls.Add(this.lbIngredientesDelPlato);
            this.Controls.Add(this.btnQuitarIngredientes);
            this.Controls.Add(this.btnAgregarIngredientes);
            this.Controls.Add(this.lbIngredientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.label1);
            this.Name = "frmCrearPlatoSeleccionIng";
            this.Text = "Plato";
            this.Load += new System.EventHandler(this.frmCrearPlatoSeleccionIng_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbIngredientes;
        private System.Windows.Forms.Button btnAgregarIngredientes;
        private System.Windows.Forms.Button btnQuitarIngredientes;
        private System.Windows.Forms.ListBox lbIngredientesDelPlato;
        private System.Windows.Forms.Panel pnlIngredientes;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}