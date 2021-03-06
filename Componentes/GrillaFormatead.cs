﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Componentes
{
    public partial class GrillaFormatead : DataGridView
    {
        public GrillaFormatead()
        {
            InitializeComponent();
            base.DataSourceChanged += new EventHandler(GrillaFormateada_DataSourceChanged);
            darFormato();
            
        }

        private void darFormato() {
           base.AllowUserToAddRows = false;
           base.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           base.AllowUserToResizeColumns = false;
           base.AllowUserToResizeRows = false;
           base.RowHeadersVisible = false;
           base.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           base.ReadOnly = true;
           base.MultiSelect = false;
        
        }

        void GrillaFormateada_DataSourceChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn x in this.Columns)
            {
                if (x.Name.StartsWith("Id"))
                    x.Visible = false;
            }
        }
        
    }
}
