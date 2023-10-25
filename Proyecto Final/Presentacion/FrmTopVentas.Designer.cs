
namespace Presentacion
{
    partial class FrmTopVentas
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
            this.chartProdCat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.btnDia = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnAnio = new System.Windows.Forms.Button();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPreferidos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdCat)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProdCat
            // 
            this.chartProdCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.chartProdCat.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chartProdCat.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Area3DStyle.Inclination = 20;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartProdCat.ChartAreas.Add(chartArea1);
            this.chartProdCat.Cursor = System.Windows.Forms.Cursors.Default;
            this.chartProdCat.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            legend1.Name = "Legend1";
            this.chartProdCat.Legends.Add(legend1);
            this.chartProdCat.Location = new System.Drawing.Point(0, 0);
            this.chartProdCat.Name = "chartProdCat";
            this.chartProdCat.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Color = System.Drawing.Color.Transparent;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chartProdCat.Series.Add(series1);
            this.chartProdCat.Size = new System.Drawing.Size(1080, 287);
            this.chartProdCat.TabIndex = 1;
            this.chartProdCat.Text = "chart2";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpInicio.Location = new System.Drawing.Point(97, 503);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 2;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // btnDia
            // 
            this.btnDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(127)))), ((int)(((byte)(48)))));
            this.btnDia.FlatAppearance.BorderSize = 0;
            this.btnDia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDia.ForeColor = System.Drawing.Color.White;
            this.btnDia.Location = new System.Drawing.Point(730, 562);
            this.btnDia.Margin = new System.Windows.Forms.Padding(4);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(107, 37);
            this.btnDia.TabIndex = 11;
            this.btnDia.Text = "Día";
            this.btnDia.UseVisualStyleBackColor = false;
            this.btnDia.Click += new System.EventHandler(this.btnDia_Click);
            // 
            // btnMes
            // 
            this.btnMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(127)))), ((int)(((byte)(48)))));
            this.btnMes.FlatAppearance.BorderSize = 0;
            this.btnMes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMes.ForeColor = System.Drawing.Color.White;
            this.btnMes.Location = new System.Drawing.Point(845, 562);
            this.btnMes.Margin = new System.Windows.Forms.Padding(4);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(107, 37);
            this.btnMes.TabIndex = 12;
            this.btnMes.Text = "Mes";
            this.btnMes.UseVisualStyleBackColor = false;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // btnAnio
            // 
            this.btnAnio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(127)))), ((int)(((byte)(48)))));
            this.btnAnio.FlatAppearance.BorderSize = 0;
            this.btnAnio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAnio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnio.ForeColor = System.Drawing.Color.White;
            this.btnAnio.Location = new System.Drawing.Point(960, 562);
            this.btnAnio.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnio.Name = "btnAnio";
            this.btnAnio.Size = new System.Drawing.Size(107, 37);
            this.btnAnio.TabIndex = 13;
            this.btnAnio.Text = "Año";
            this.btnAnio.UseVisualStyleBackColor = false;
            this.btnAnio.Click += new System.EventHandler(this.btnAnio_Click);
            // 
            // dtpFinal
            // 
            this.dtpFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFinal.Location = new System.Drawing.Point(98, 529);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFinal.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(127)))), ((int)(((byte)(48)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(13, 562);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 37);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label2.Location = new System.Drawing.Point(13, 509);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "FECHA INICIO";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label3.Location = new System.Drawing.Point(13, 535);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "FECHA FINAL";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label4.Location = new System.Drawing.Point(13, 476);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "BUSCAR POR RANGO DE FECHAS:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label5.Location = new System.Drawing.Point(727, 535);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "BUSCAR POR ÚLTIMO:";
            // 
            // lblPreferidos
            // 
            this.lblPreferidos.AutoSize = true;
            this.lblPreferidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreferidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.lblPreferidos.Location = new System.Drawing.Point(13, 290);
            this.lblPreferidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreferidos.Name = "lblPreferidos";
            this.lblPreferidos.Size = new System.Drawing.Size(171, 13);
            this.lblPreferidos.TabIndex = 24;
            this.lblPreferidos.Text = "PRODUCTOS PREFERIDOS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "VENTAS";
            // 
            // FrmTopVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPreferidos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.btnAnio);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.btnDia);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.chartProdCat);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTopVentas";
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProdCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdCat;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Button btnDia;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btnAnio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPreferidos;
        private System.Windows.Forms.Label label1;
    }
}