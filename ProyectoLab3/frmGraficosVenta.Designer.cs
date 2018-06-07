namespace ProyectoLab3
{
    partial class frmGraficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartVntas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboMeses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.chartCantidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSucursal = new System.Windows.Forms.ListBox();
            this.tbDirSuc = new System.Windows.Forms.TextBox();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartVntas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCantidad)).BeginInit();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartVntas
            // 
            this.chartVntas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            chartArea1.Name = "ChartArea1";
            this.chartVntas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVntas.Legends.Add(legend1);
            this.chartVntas.Location = new System.Drawing.Point(23, 159);
            this.chartVntas.Name = "chartVntas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartVntas.Series.Add(series1);
            this.chartVntas.Size = new System.Drawing.Size(634, 463);
            this.chartVntas.TabIndex = 5;
            this.chartVntas.Text = "chart1";
            // 
            // cboMeses
            // 
            this.cboMeses.FormattingEnabled = true;
            this.cboMeses.Location = new System.Drawing.Point(692, 110);
            this.cboMeses.Name = "cboMeses";
            this.cboMeses.Size = new System.Drawing.Size(121, 21);
            this.cboMeses.TabIndex = 4;
            this.cboMeses.SelectedIndexChanged += new System.EventHandler(this.cboMeses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Meses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Año";
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(581, 111);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(60, 20);
            this.nudAnio.TabIndex = 3;
            // 
            // chartCantidad
            // 
            this.chartCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartCantidad.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCantidad.Legends.Add(legend2);
            this.chartCantidad.Location = new System.Drawing.Point(692, 159);
            this.chartCantidad.Name = "chartCantidad";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartCantidad.Series.Add(series2);
            this.chartCantidad.Size = new System.Drawing.Size(645, 463);
            this.chartCantidad.TabIndex = 6;
            this.chartCantidad.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sucursal";
            // 
            // lbSucursal
            // 
            this.lbSucursal.FormattingEnabled = true;
            this.lbSucursal.Location = new System.Drawing.Point(35, 54);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(313, 95);
            this.lbSucursal.TabIndex = 2;
            // 
            // tbDirSuc
            // 
            this.tbDirSuc.Location = new System.Drawing.Point(90, 28);
            this.tbDirSuc.Name = "tbDirSuc";
            this.tbDirSuc.Size = new System.Drawing.Size(172, 20);
            this.tbDirSuc.TabIndex = 1;
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.tbDirSuc);
            this.pnlAdmin.Controls.Add(this.lbSucursal);
            this.pnlAdmin.Controls.Add(this.label3);
            this.pnlAdmin.Location = new System.Drawing.Point(25, 4);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(422, 155);
            this.pnlAdmin.TabIndex = 10;
            // 
            // frmGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 653);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.chartCantidad);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMeses);
            this.Controls.Add(this.chartVntas);
            this.Name = "frmGraficos";
            this.Text = "Graficos de ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGraficosVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartVntas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCantidad)).EndInit();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartVntas;
        private System.Windows.Forms.ComboBox cboMeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbSucursal;
        private System.Windows.Forms.TextBox tbDirSuc;
        private System.Windows.Forms.Panel pnlAdmin;

    }
}