using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
namespace ProyectoLab3
{
    public partial class frmTicketVenta : Form
    {
        public frmTicketVenta(ReportDocument rptDocument)
        {
            InitializeComponent();
            crTicket.ReportSource = rptDocument;
        }

        private void frmTicketVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
