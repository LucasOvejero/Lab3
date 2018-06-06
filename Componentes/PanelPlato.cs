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
        public NumericUpDown NudGramos { get { return nudGramos; } }
        
        public PanelPlato()
        {
            InitializeComponent();
        }

        public PanelPlato(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public PanelPlato(string NombreIngrediente)
        {
            InitializeComponent();
            Label lblIng = new Label();
            lblIng.Text = NombreIngrediente;
            lblIng.Location = new System.Drawing.Point(5, 5);
            lblIng.Size = new System.Drawing.Size(150, 25);
            this.Controls.Add(lblIng);
            Label lblTag = new Label();
            lblTag.Text = "Cantidad(en gramos):";
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
    }
}
