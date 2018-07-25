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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartVntas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCantidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSucursal = new System.Windows.Forms.ListBox();
            this.tbDirSuc = new System.Windows.Forms.TextBox();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.btnGraficosPorEmp = new System.Windows.Forms.Button();
            this.cBMV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cPMV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnInforme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartVntas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCantidad)).BeginInit();
            this.pnlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBMV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPMV)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartVntas
            // 
            chartArea5.Name = "ChartArea1";
            this.chartVntas.ChartAreas.Add(chartArea5);
            this.chartVntas.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chartVntas.Legends.Add(legend5);
            this.chartVntas.Location = new System.Drawing.Point(3, 3);
            this.chartVntas.Name = "chartVntas";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartVntas.Series.Add(series5);
            this.chartVntas.Size = new System.Drawing.Size(755, 427);
            this.chartVntas.TabIndex = 1;
            this.chartVntas.Text = "chart1";
            // 
            // chartCantidad
            // 
            chartArea6.Name = "ChartArea1";
            this.chartCantidad.ChartAreas.Add(chartArea6);
            this.chartCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chartCantidad.Legends.Add(legend6);
            this.chartCantidad.Location = new System.Drawing.Point(3, 3);
            this.chartCantidad.Name = "chartCantidad";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartCantidad.Series.Add(series6);
            this.chartCantidad.Size = new System.Drawing.Size(755, 427);
            this.chartCantidad.TabIndex = 2;
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
            this.lbSucursal.Location = new System.Drawing.Point(50, 47);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(239, 43);
            this.lbSucursal.TabIndex = 4;
            this.lbSucursal.SelectedIndexChanged += new System.EventHandler(this.lbSucursal_SelectedIndexChanged_1);
            // 
            // tbDirSuc
            // 
            this.tbDirSuc.Location = new System.Drawing.Point(90, 21);
            this.tbDirSuc.Name = "tbDirSuc";
            this.tbDirSuc.Size = new System.Drawing.Size(172, 20);
            this.tbDirSuc.TabIndex = 0;
            this.tbDirSuc.TextChanged += new System.EventHandler(this.tbDirSuc_TextChanged);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.tbDirSuc);
            this.pnlAdmin.Controls.Add(this.lbSucursal);
            this.pnlAdmin.Controls.Add(this.label3);
            this.pnlAdmin.Location = new System.Drawing.Point(25, 4);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(334, 94);
            this.pnlAdmin.TabIndex = 10;
            // 
            // btnGraficosPorEmp
            // 
            this.btnGraficosPorEmp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGraficosPorEmp.Location = new System.Drawing.Point(697, 31);
            this.btnGraficosPorEmp.Name = "btnGraficosPorEmp";
            this.btnGraficosPorEmp.Size = new System.Drawing.Size(75, 42);
            this.btnGraficosPorEmp.TabIndex = 0;
            this.btnGraficosPorEmp.Text = "Ventas por Empleados";
            this.btnGraficosPorEmp.UseVisualStyleBackColor = true;
            this.btnGraficosPorEmp.Click += new System.EventHandler(this.btnGraficosPorEmp_Click);
            // 
            // cBMV
            // 
            chartArea7.Name = "ChartArea1";
            this.cBMV.ChartAreas.Add(chartArea7);
            this.cBMV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Name = "Legend1";
            this.cBMV.Legends.Add(legend7);
            this.cBMV.Location = new System.Drawing.Point(3, 3);
            this.cBMV.Name = "cBMV";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.cBMV.Series.Add(series7);
            this.cBMV.Size = new System.Drawing.Size(755, 427);
            this.cBMV.TabIndex = 3;
            this.cBMV.Text = "chart1";
            // 
            // cPMV
            // 
            chartArea8.Name = "ChartArea1";
            this.cPMV.ChartAreas.Add(chartArea8);
            this.cPMV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Name = "Legend1";
            this.cPMV.Legends.Add(legend8);
            this.cPMV.Location = new System.Drawing.Point(3, 3);
            this.cPMV.Name = "cPMV";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.cPMV.Series.Add(series8);
            this.cPMV.Size = new System.Drawing.Size(755, 427);
            this.cPMV.TabIndex = 4;
            this.cPMV.Text = "chart2";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(365, 40);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(79, 20);
            this.dtpDesde.TabIndex = 11;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(492, 40);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(79, 20);
            this.dtpHasta.TabIndex = 12;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hasta";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 104);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 459);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartVntas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Recaudado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartCantidad);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cantidad de ventas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cBMV);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(761, 433);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bebida + vendida";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cPMV);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(761, 433);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Plato + vendido";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnInforme
            // 
            this.btnInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInforme.Location = new System.Drawing.Point(365, 66);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(206, 32);
            this.btnInforme.TabIndex = 16;
            this.btnInforme.Text = "Informe de Sucursales";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // frmGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.btnGraficosPorEmp);
            this.Controls.Add(this.pnlAdmin);
            this.Name = "frmGraficos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficos de ventas";
            this.Load += new System.EventHandler(this.frmGraficosVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartVntas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCantidad)).EndInit();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBMV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPMV)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartVntas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbSucursal;
        private System.Windows.Forms.TextBox tbDirSuc;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.DataVisualization.Charting.Chart cBMV;
        private System.Windows.Forms.DataVisualization.Charting.Chart cPMV;
        private System.Windows.Forms.Button btnGraficosPorEmp;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnInforme;
    }
}