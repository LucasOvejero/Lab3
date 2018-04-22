using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Componentes
{
    public partial class nudP : NumericUpDown
    {
        public nudP()
        {
            InitializeComponent();
            base.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        }

        protected override void UpdateEditText()
        {

            ChangingText = true;
            Regex decimalRegex = new Regex(@"(\d+([,]\d{1,2})?)");
            Match m = decimalRegex.Match(this.Text);
            if (m.Success)
            {
                Text = m.Value;

            }
            ChangingText = false;
            base.UpdateEditText();
            ChangingText = true;

            Text = this.Value.ToString("C", CultureInfo.CurrentCulture);

        }
    }
}
