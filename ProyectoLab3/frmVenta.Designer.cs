﻿namespace ProyectoLab3
{
    partial class frmVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarPlato = new System.Windows.Forms.Button();
            this.pnlDescripcion = new System.Windows.Forms.Panel();
            this.btnAgregarBebida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombrePlato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTACC = new System.Windows.Forms.CheckBox();
            this.cboCategoriaPlato = new System.Windows.Forms.ComboBox();
            this.dgvPlatos = new Componentes.GrillaFormatead();
            this.dgvBebidas = new Componentes.GrillaFormatead();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombreBebida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCategoriaBebida = new System.Windows.Forms.ComboBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudPago = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCierre = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).BeginInit();
            this.pnlTotal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPago)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 269F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.tableLayoutPanel1.Controls.Add(this.btnAgregarPlato, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.pnlDescripcion, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnAgregarBebida, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbNombrePlato, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbTACC, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cboCategoriaPlato, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvPlatos, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.dgvBebidas, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbNombreBebida, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboCategoriaBebida, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnVender, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.pnlTotal, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblInfo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCierre, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.56962F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.43038F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 374F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(915, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAgregarPlato
            // 
            this.btnAgregarPlato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarPlato.Location = new System.Drawing.Point(273, 257);
            this.btnAgregarPlato.Name = "btnAgregarPlato";
            this.btnAgregarPlato.Size = new System.Drawing.Size(34, 45);
            this.btnAgregarPlato.TabIndex = 5;
            this.btnAgregarPlato.Text = "--->";
            this.btnAgregarPlato.UseVisualStyleBackColor = true;
            this.btnAgregarPlato.Click += new System.EventHandler(this.btnAgregarPlato_Click);
            // 
            // pnlDescripcion
            // 
            this.pnlDescripcion.AutoScroll = true;
            this.pnlDescripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDescripcion.Location = new System.Drawing.Point(314, 96);
            this.pnlDescripcion.Name = "pnlDescripcion";
            this.pnlDescripcion.Size = new System.Drawing.Size(254, 333);
            this.pnlDescripcion.TabIndex = 6;
            // 
            // btnAgregarBebida
            // 
            this.btnAgregarBebida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarBebida.Location = new System.Drawing.Point(576, 257);
            this.btnAgregarBebida.Name = "btnAgregarBebida";
            this.btnAgregarBebida.Size = new System.Drawing.Size(39, 45);
            this.btnAgregarBebida.TabIndex = 5;
            this.btnAgregarBebida.Text = "<---";
            this.btnAgregarBebida.UseVisualStyleBackColor = true;
            this.btnAgregarBebida.Click += new System.EventHandler(this.btnAgregarBebida_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción de venta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNombrePlato
            // 
            this.tbNombrePlato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombrePlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombrePlato.Location = new System.Drawing.Point(62, 4);
            this.tbNombrePlato.Name = "tbNombrePlato";
            this.tbNombrePlato.Size = new System.Drawing.Size(145, 22);
            this.tbNombrePlato.TabIndex = 0;
            this.tbNombrePlato.TextChanged += new System.EventHandler(this.tbNombreBebida_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 1);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre plato";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Categoria plato";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTACC
            // 
            this.cbTACC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTACC.AutoSize = true;
            this.cbTACC.Location = new System.Drawing.Point(107, 82);
            this.cbTACC.Name = "cbTACC";
            this.cbTACC.Size = new System.Drawing.Size(54, 1);
            this.cbTACC.TabIndex = 3;
            this.cbTACC.Text = "TACC";
            this.cbTACC.UseVisualStyleBackColor = true;
            this.cbTACC.CheckedChanged += new System.EventHandler(this.tbNombreBebida_TextChanged);
            // 
            // cboCategoriaPlato
            // 
            this.cboCategoriaPlato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCategoriaPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoriaPlato.FormattingEnabled = true;
            this.cboCategoriaPlato.Location = new System.Drawing.Point(63, 49);
            this.cboCategoriaPlato.Name = "cboCategoriaPlato";
            this.cboCategoriaPlato.Size = new System.Drawing.Size(142, 24);
            this.cboCategoriaPlato.TabIndex = 1;
            this.cboCategoriaPlato.SelectedIndexChanged += new System.EventHandler(this.tbNombreBebida_TextChanged);
            // 
            // dgvPlatos
            // 
            this.dgvPlatos.AllowUserToAddRows = false;
            this.dgvPlatos.AllowUserToResizeColumns = false;
            this.dgvPlatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlatos.Location = new System.Drawing.Point(3, 96);
            this.dgvPlatos.MultiSelect = false;
            this.dgvPlatos.Name = "dgvPlatos";
            this.dgvPlatos.ReadOnly = true;
            this.dgvPlatos.RowHeadersVisible = false;
            this.dgvPlatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlatos.Size = new System.Drawing.Size(263, 368);
            this.dgvPlatos.TabIndex = 4;
            this.dgvPlatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPlatos_CellFormatting);
            this.dgvPlatos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlatos_RowEnter);
            // 
            // dgvBebidas
            // 
            this.dgvBebidas.AllowUserToAddRows = false;
            this.dgvBebidas.AllowUserToResizeColumns = false;
            this.dgvBebidas.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBebidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBebidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBebidas.Location = new System.Drawing.Point(624, 96);
            this.dgvBebidas.MultiSelect = false;
            this.dgvBebidas.Name = "dgvBebidas";
            this.dgvBebidas.ReadOnly = true;
            this.dgvBebidas.RowHeadersVisible = false;
            this.dgvBebidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBebidas.Size = new System.Drawing.Size(288, 368);
            this.dgvBebidas.TabIndex = 10;
            this.dgvBebidas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBebidas_CellFormatting);
            this.dgvBebidas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBebidas_RowEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(624, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 1);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nombre bebida";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNombreBebida
            // 
            this.tbNombreBebida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombreBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreBebida.Location = new System.Drawing.Point(718, 4);
            this.tbNombreBebida.Name = "tbNombreBebida";
            this.tbNombreBebida.Size = new System.Drawing.Size(100, 22);
            this.tbNombreBebida.TabIndex = 7;
            this.tbNombreBebida.TextChanged += new System.EventHandler(this.tbNombreBebida_TextChanged_1);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(711, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Categoria bebida";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCategoriaBebida
            // 
            this.cboCategoriaBebida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCategoriaBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoriaBebida.FormattingEnabled = true;
            this.cboCategoriaBebida.Location = new System.Drawing.Point(707, 49);
            this.cboCategoriaBebida.Name = "cboCategoriaBebida";
            this.cboCategoriaBebida.Size = new System.Drawing.Size(121, 24);
            this.cboCategoriaBebida.TabIndex = 8;
            this.cboCategoriaBebida.SelectedIndexChanged += new System.EventHandler(this.tbNombreBebida_TextChanged_1);
            // 
            // btnVender
            // 
            this.btnVender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Location = new System.Drawing.Point(314, 536);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(254, 22);
            this.btnVender.TabIndex = 12;
            this.btnVender.Text = "Realizar Venta";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Controls.Add(this.label6);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotal.Location = new System.Drawing.Point(314, 470);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(254, 30);
            this.pnlTotal.TabIndex = 21;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Green;
            this.lblTotal.Location = new System.Drawing.Point(83, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(135, 30);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudPago);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(314, 506);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 24);
            this.panel1.TabIndex = 22;
            // 
            // nudPago
            // 
            this.nudPago.DecimalPlaces = 2;
            this.nudPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPago.Location = new System.Drawing.Point(86, 3);
            this.nudPago.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPago.Name = "nudPago";
            this.nudPago.Size = new System.Drawing.Size(87, 22);
            this.nudPago.TabIndex = 11;
            this.nudPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pago";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(314, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 1);
            this.lblInfo.TabIndex = 23;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCierre
            // 
            this.btnCierre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierre.Location = new System.Drawing.Point(372, 47);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(137, 29);
            this.btnCierre.TabIndex = 24;
            this.btnCierre.Text = "Terminar Turno";
            this.btnCierre.UseVisualStyleBackColor = true;
            this.btnCierre.Click += new System.EventHandler(this.btnCierre_Click);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmVenta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDescripcion;
        private System.Windows.Forms.Button btnAgregarPlato;
        private System.Windows.Forms.Button btnAgregarBebida;
        private Componentes.GrillaFormatead dgvPlatos;
        private System.Windows.Forms.TextBox tbNombrePlato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbTACC;
        private System.Windows.Forms.ComboBox cboCategoriaPlato;
        private Componentes.GrillaFormatead dgvBebidas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombreBebida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCategoriaBebida;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnCierre;
    }
}