namespace ProyectoLab3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnSuc = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnDepositos = new System.Windows.Forms.Button();
            this.btnSolicitudes = new System.Windows.Forms.Button();
            this.lblUserSession = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(187, 148);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(75, 23);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // btnSuc
            // 
            this.btnSuc.Location = new System.Drawing.Point(70, 77);
            this.btnSuc.Name = "btnSuc";
            this.btnSuc.Size = new System.Drawing.Size(75, 23);
            this.btnSuc.TabIndex = 1;
            this.btnSuc.Text = "Sucursales";
            this.btnSuc.UseVisualStyleBackColor = true;
            this.btnSuc.Click += new System.EventHandler(this.btnSuc_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(298, 148);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(75, 23);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnDepositos
            // 
            this.btnDepositos.Location = new System.Drawing.Point(187, 77);
            this.btnDepositos.Name = "btnDepositos";
            this.btnDepositos.Size = new System.Drawing.Size(75, 23);
            this.btnDepositos.TabIndex = 3;
            this.btnDepositos.Text = "Depositos";
            this.btnDepositos.UseVisualStyleBackColor = true;
            this.btnDepositos.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.Location = new System.Drawing.Point(70, 148);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(75, 23);
            this.btnSolicitudes.TabIndex = 4;
            this.btnSolicitudes.Text = "Solicitudes";
            this.btnSolicitudes.UseVisualStyleBackColor = true;
            this.btnSolicitudes.Click += new System.EventHandler(this.btnSolicitudes_Click);
            // 
            // lblUserSession
            // 
            this.lblUserSession.AutoSize = true;
            this.lblUserSession.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserSession.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblUserSession.Location = new System.Drawing.Point(12, 9);
            this.lblUserSession.Name = "lblUserSession";
            this.lblUserSession.Size = new System.Drawing.Size(165, 30);
            this.lblUserSession.TabIndex = 5;
            this.lblUserSession.Text = "Ingrese su Usuario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 414);
            this.Controls.Add(this.lblUserSession);
            this.Controls.Add(this.btnSolicitudes);
            this.Controls.Add(this.btnDepositos);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnSuc);
            this.Controls.Add(this.btnProductos);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnSuc;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnDepositos;
        private System.Windows.Forms.Button btnSolicitudes;
        private System.Windows.Forms.Button btnPlatos;
        private System.Windows.Forms.Label lblUserSession;
    }
}

