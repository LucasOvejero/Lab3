using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Componentes
{
    public partial class PanelPlato : Panel
    {
        private NumericUpDown nudGramos;
        Button cerrar;
        public Button Cerrar {get{return cerrar;} }
        public NumericUpDown NudGramos { get { return nudGramos; } }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public bool EsBebida { get; set; }
        public int Id { get; set; }
        Label lblIng;
        public string Nombre { get { return lblIng.Text; } }
        public PanelPlato()
        {
            InitializeComponent();
        }

        public PanelPlato(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public PanelPlato(string NombreIngrediente,string unidad)
        {
            InitializeComponent();
            Label lblIng = new Label();
            lblIng.Text = NombreIngrediente;
            lblIng.Location = new System.Drawing.Point(5, 5);
            lblIng.Size = new System.Drawing.Size(150, 25);
            this.Controls.Add(lblIng);
            Label lblTag = new Label();
            lblTag.Text = string.Format("Cantidad(en {0}):",unidad);
            lblTag.Location = new System.Drawing.Point(5, 35);
            lblTag.Size = new System.Drawing.Size(150,25);
            this.Controls.Add(lblTag);
            nudGramos = new NumericUpDown();
            nudGramos.Location = new System.Drawing.Point(165, 35);
            nudGramos.Minimum = 1;
            nudGramos.Maximum = 10000;
            nudGramos.TextAlign = HorizontalAlignment.Right;
            nudGramos.Size = new System.Drawing.Size(50, 25);
            this.Controls.Add(nudGramos);
            this.Size = new System.Drawing.Size(230, 70);
            this.BorderStyle = BorderStyle.FixedSingle;

        }

        //Constructor para hacer que el panel guarde información de la venta
        public PanelPlato(string NombreIngrediente,bool esBebida,int Id)
        {
            InitializeComponent();
            
            this.EsBebida = esBebida;
            this.Id = Id;
            lblIng = new Label();
            lblIng.Text = NombreIngrediente;
            lblIng.Location = new System.Drawing.Point(5, 5);
            lblIng.Size = new System.Drawing.Size(150, 25);
            this.Controls.Add(lblIng);
            Label lblTag = new Label();
            
            lblTag.Text = "Cantidad" ;//"Cantidad(en gramos):";
            cerrar = new Button();
            cerrar.Text = "X";
            cerrar.Size = new System.Drawing.Size(25, 25);
            cerrar.Top = 5;
            cerrar.Left = 200;
            cerrar.FlatStyle = FlatStyle.Flat;
            cerrar.BackColor = System.Drawing.Color.Red;
            cerrar.ForeColor = System.Drawing.Color.White;
            this.Controls.Add(cerrar);
            lblTag.Location = new System.Drawing.Point(5, 35);
            lblTag.Size = new System.Drawing.Size(150, 25);
            this.Controls.Add(lblTag);
            nudGramos = new NumericUpDown();
            nudGramos.Location = new System.Drawing.Point(165, 35);
            nudGramos.Minimum = 1;
            nudGramos.Maximum = 10000;
            nudGramos.TextAlign = HorizontalAlignment.Right;
            nudGramos.Size = new System.Drawing.Size(50, 25);
            this.Controls.Add(nudGramos);
            this.Size = new System.Drawing.Size(230, 70);
            this.BorderStyle = BorderStyle.FixedSingle;

        }
    }
}
