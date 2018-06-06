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
            this.btnBebidas = new System.Windows.Forms.Button();
            this.btnSuc = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnDepositos = new System.Windows.Forms.Button();
            this.btnSolicitudes = new System.Windows.Forms.Button();
            this.btnPlato = new System.Windows.Forms.Button();
            this.btnNewSolicitud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBebidas
            // 
            this.btnBebidas.Location = new System.Drawing.Point(224, 51);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(75, 23);
            this.btnBebidas.TabIndex = 0;
            this.btnBebidas.Text = "Productos";
            this.btnBebidas.UseVisualStyleBackColor = true;
            this.btnBebidas.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // btnSuc
            // 
            this.btnSuc.Location = new System.Drawing.Point(67, 51);
            this.btnSuc.Name = "btnSuc";
            this.btnSuc.Size = new System.Drawing.Size(75, 23);
            this.btnSuc.TabIndex = 1;
            this.btnSuc.Text = "Sucursales";
            this.btnSuc.UseVisualStyleBackColor = true;
            this.btnSuc.Click += new System.EventHandler(this.btnSuc_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(538, 51);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(75, 23);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnDepositos
            // 
            this.btnDepositos.Location = new System.Drawing.Point(381, 51);
            this.btnDepositos.Name = "btnDepositos";
            this.btnDepositos.Size = new System.Drawing.Size(75, 23);
            this.btnDepositos.TabIndex = 3;
            this.btnDepositos.Text = "Depositos";
            this.btnDepositos.UseVisualStyleBackColor = true;
            this.btnDepositos.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.Location = new System.Drawing.Point(67, 181);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(75, 54);
            this.btnSolicitudes.TabIndex = 4;
            this.btnSolicitudes.Text = "Administrar Solicitudes";
            this.btnSolicitudes.UseVisualStyleBackColor = true;
            this.btnSolicitudes.Click += new System.EventHandler(this.btnSolicitudes_Click);
            // 
            // btnPlato
            // 
            this.btnPlato.Location = new System.Drawing.Point(695, 51);
            this.btnPlato.Name = "btnPlato";
            this.btnPlato.Size = new System.Drawing.Size(75, 23);
            this.btnPlato.TabIndex = 5;
            this.btnPlato.Text = "Platos";
            this.btnPlato.UseVisualStyleBackColor = true;
            this.btnPlato.Click += new System.EventHandler(this.btnPlato_Click);
            // 
            // btnNewSolicitud
            // 
            this.btnNewSolicitud.Location = new System.Drawing.Point(224, 181);
            this.btnNewSolicitud.Name = "btnNewSolicitud";
            this.btnNewSolicitud.Size = new System.Drawing.Size(75, 54);
            this.btnNewSolicitud.TabIndex = 6;
            this.btnNewSolicitud.Text = "Nueva Solicitud";
            this.btnNewSolicitud.UseVisualStyleBackColor = true;
            this.btnNewSolicitud.Click += new System.EventHandler(this.btnNewSolicitud_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 414);
            this.Controls.Add(this.btnNewSolicitud);
            this.Controls.Add(this.btnPlato);
            this.Controls.Add(this.btnSolicitudes);
            this.Controls.Add(this.btnDepositos);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnSuc);
            this.Controls.Add(this.btnBebidas);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBebidas;
        private System.Windows.Forms.Button btnSuc;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnDepositos;
        private System.Windows.Forms.Button btnSolicitudes;
        private System.Windows.Forms.Button btnPlatos;
        private System.Windows.Forms.Button btnPlato;
        private System.Windows.Forms.Button btnNewSolicitud;
    }
}

