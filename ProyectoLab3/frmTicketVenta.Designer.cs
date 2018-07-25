namespace ProyectoLab3
{
    partial class frmTicketVenta
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
            this.crTicket = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crTicket
            // 
            this.crTicket.ActiveViewIndex = -1;
            this.crTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crTicket.Cursor = System.Windows.Forms.Cursors.Default;
            this.crTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crTicket.Location = new System.Drawing.Point(0, 0);
            this.crTicket.Name = "crTicket";
            this.crTicket.Size = new System.Drawing.Size(784, 561);
            this.crTicket.TabIndex = 0;
            this.crTicket.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmTicketVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.crTicket);
            this.Name = "frmTicketVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.frmTicketVenta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crTicket;
    }
}