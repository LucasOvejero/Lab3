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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.btnGraficosPorEmp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHoy = new System.Windows.Forms.CheckBox();
            this.cBMV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cPMV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartVntas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCantidad)).BeginInit();
            this.pnlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBMV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPMV)).BeginInit();
            this.SuspendLayout();
            // 
            // chartVntas
            // 
            this.chartVntas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartVntas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVntas.Legends.Add(legend1);
            this.chartVntas.Location = new System.Drawing.Point(57, 104);
            this.chartVntas.Name = "chartVntas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartVntas.Series.Add(series1);
            this.chartVntas.Size = new System.Drawing.Size(291, 229);
            this.chartVntas.TabIndex = 5;
            this.chartVntas.Text = "chart1";
            // 
            // cboMeses
            // 
            this.cboMeses.FormattingEnabled = true;
            this.cboMeses.Location = new System.Drawing.Point(118, 58);
            this.cboMeses.Name = "cboMeses";
            this.cboMeses.Size = new System.Drawing.Size(121, 21);
            this.cboMeses.TabIndex = 4;
            this.cboMeses.SelectedIndexChanged += new System.EventHandler(this.cboMeses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Meses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Año";
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(7, 59);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(60, 20);
            this.nudAnio.TabIndex = 3;
            // 
            // chartCantidad
            // 
            this.chartCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartCantidad.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCantidad.Legends.Add(legend2);
            this.chartCantidad.Location = new System.Drawing.Point(395, 104);
            this.chartCantidad.Name = "chartCantidad";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartCantidad.Series.Add(series2);
            this.chartCantidad.Size = new System.Drawing.Size(321, 229);
            this.chartCantidad.TabIndex = 6;
            this.chartCantidad.Text = "449, 265";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sucursal";
            // 
            // lbSucursal
            // 
            this.lbSucursal.FormattingEnabled = true;
            this.lbSucursal.Location = new System.Drawing.Point(370, 21);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(239, 69);
            this.lbSucursal.TabIndex = 2;
            // 
            // tbDirSuc
            // 
            this.tbDirSuc.Location = new System.Drawing.Point(90, 21);
            this.tbDirSuc.Name = "tbDirSuc";
            this.tbDirSuc.Size = new System.Drawing.Size(172, 20);
            this.tbDirSuc.TabIndex = 1;
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.label4);
            this.pnlAdmin.Controls.Add(this.tbDirSuc);
            this.pnlAdmin.Controls.Add(this.lbSucursal);
            this.pnlAdmin.Controls.Add(this.cbHoy);
            this.pnlAdmin.Controls.Add(this.label3);
            this.pnlAdmin.Controls.Add(this.cboMeses);
            this.pnlAdmin.Controls.Add(this.nudAnio);
            this.pnlAdmin.Controls.Add(this.label1);
            this.pnlAdmin.Controls.Add(this.label2);
            this.pnlAdmin.Location = new System.Drawing.Point(25, 4);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(638, 94);
            this.pnlAdmin.TabIndex = 10;
            // 
            // btnGraficosPorEmp
            // 
            this.btnGraficosPorEmp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGraficosPorEmp.Location = new System.Drawing.Point(697, 31);
            this.btnGraficosPorEmp.Name = "btnGraficosPorEmp";
            this.btnGraficosPorEmp.Size = new System.Drawing.Size(75, 42);
            this.btnGraficosPorEmp.TabIndex = 14;
            this.btnGraficosPorEmp.Text = "Ventas por Empleados";
            this.btnGraficosPorEmp.UseVisualStyleBackColor = true;
            this.btnGraficosPorEmp.Click += new System.EventHandler(this.btnGraficosPorEmp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sucursal Actual";
            // 
            // cbHoy
            // 
            this.cbHoy.AutoSize = true;
            this.cbHoy.Location = new System.Drawing.Point(264, 60);
            this.cbHoy.Name = "cbHoy";
            this.cbHoy.Size = new System.Drawing.Size(67, 17);
            this.cbHoy.TabIndex = 11;
            this.cbHoy.Text = "Sólo hoy";
            this.cbHoy.UseVisualStyleBackColor = true;
            this.cbHoy.CheckedChanged += new System.EventHandler(this.cboHoy_CheckedChanged);
            // 
            // cBMV
            // 
            this.cBMV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.cBMV.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cBMV.Legends.Add(legend3);
            this.cBMV.Location = new System.Drawing.Point(57, 339);
            this.cBMV.Name = "cBMV";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.cBMV.Series.Add(series3);
            this.cBMV.Size = new System.Drawing.Size(291, 229);
            this.cBMV.TabIndex = 12;
            this.cBMV.Text = "chart1";
            // 
            // cPMV
            // 
            this.cPMV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.cPMV.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.cPMV.Legends.Add(legend4);
            this.cPMV.Location = new System.Drawing.Point(395, 339);
            this.cPMV.Name = "cPMV";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.cPMV.Series.Add(series4);
            this.cPMV.Size = new System.Drawing.Size(321, 229);
            this.cPMV.TabIndex = 13;
            this.cPMV.Text = "chart2";
            // 
            // frmGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnGraficosPorEmp);
            this.Controls.Add(this.cPMV);
            this.Controls.Add(this.cBMV);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.chartCantidad);
            this.Controls.Add(this.chartVntas);
            this.Name = "frmGraficos";
            this.Text = "Graficos de ventas";
            this.Load += new System.EventHandler(this.frmGraficosVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartVntas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCantidad)).EndInit();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBMV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPMV)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.CheckBox cbHoy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart cBMV;
        private System.Windows.Forms.DataVisualization.Charting.Chart cPMV;
        private System.Windows.Forms.Button btnGraficosPorEmp;
    }
}