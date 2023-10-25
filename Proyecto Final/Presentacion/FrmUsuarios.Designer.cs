
namespace Presentacion
{
    partial class FrmUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbApellidoP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbApellidoM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNumeroTelf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbClave = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbMunicipio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbCalle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbNumeroDom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(51, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(240, 79);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(237, 22);
            this.txbNombre.TabIndex = 1;
            this.txbNombre.TextChanged += new System.EventHandler(this.txbNombre_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(127)))), ((int)(((byte)(48)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(54, 225);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 37);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txbCodigo
            // 
            this.txbCodigo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbCodigo.Enabled = false;
            this.txbCodigo.Location = new System.Drawing.Point(240, 47);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(132, 22);
            this.txbCodigo.TabIndex = 20;
            this.txbCodigo.Text = "Autonumerico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label2.Location = new System.Drawing.Point(50, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 100;
            this.label2.Text = "CODIGO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbApellidoP
            // 
            this.txbApellidoP.Location = new System.Drawing.Point(240, 111);
            this.txbApellidoP.Name = "txbApellidoP";
            this.txbApellidoP.Size = new System.Drawing.Size(237, 22);
            this.txbApellidoP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label3.Location = new System.Drawing.Point(51, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 101;
            this.label3.Text = "APELLIDO PATERNO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbApellidoM
            // 
            this.txbApellidoM.Location = new System.Drawing.Point(240, 143);
            this.txbApellidoM.Name = "txbApellidoM";
            this.txbApellidoM.Size = new System.Drawing.Size(237, 22);
            this.txbApellidoM.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label4.Location = new System.Drawing.Point(51, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 103;
            this.label4.Text = "APELLIDO MATERNO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbNumeroTelf
            // 
            this.txbNumeroTelf.Location = new System.Drawing.Point(240, 175);
            this.txbNumeroTelf.Name = "txbNumeroTelf";
            this.txbNumeroTelf.Size = new System.Drawing.Size(237, 22);
            this.txbNumeroTelf.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label5.Location = new System.Drawing.Point(51, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 16);
            this.label5.TabIndex = 105;
            this.label5.Text = "NUMERO DE TELEFONO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(780, 47);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(237, 22);
            this.txbUsuario.TabIndex = 5;
            this.txbUsuario.TextChanged += new System.EventHandler(this.txbUsuario_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label6.Location = new System.Drawing.Point(591, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 107;
            this.label6.Text = "USUARIO";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txbClave
            // 
            this.txbClave.Location = new System.Drawing.Point(780, 79);
            this.txbClave.Name = "txbClave";
            this.txbClave.Size = new System.Drawing.Size(237, 22);
            this.txbClave.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label7.Location = new System.Drawing.Point(591, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 109;
            this.label7.Text = "CLAVE";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txbMunicipio
            // 
            this.txbMunicipio.Location = new System.Drawing.Point(780, 144);
            this.txbMunicipio.Name = "txbMunicipio";
            this.txbMunicipio.Size = new System.Drawing.Size(237, 22);
            this.txbMunicipio.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label8.Location = new System.Drawing.Point(593, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 111;
            this.label8.Text = "MUNICIPIO";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txbCalle
            // 
            this.txbCalle.Location = new System.Drawing.Point(780, 176);
            this.txbCalle.Name = "txbCalle";
            this.txbCalle.Size = new System.Drawing.Size(237, 22);
            this.txbCalle.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label9.Location = new System.Drawing.Point(593, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 113;
            this.label9.Text = "CALLE";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txbNumeroDom
            // 
            this.txbNumeroDom.Location = new System.Drawing.Point(780, 208);
            this.txbNumeroDom.Name = "txbNumeroDom";
            this.txbNumeroDom.Size = new System.Drawing.Size(237, 22);
            this.txbNumeroDom.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label10.Location = new System.Drawing.Point(593, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 16);
            this.label10.TabIndex = 115;
            this.label10.Text = "NUMERO DE DOMICILIO";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cbEliminar
            // 
            this.cbEliminar.AutoSize = true;
            this.cbEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.cbEliminar.Location = new System.Drawing.Point(16, 365);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(89, 20);
            this.cbEliminar.TabIndex = 118;
            this.cbEliminar.Text = "ELIMINAR";
            this.cbEliminar.UseVisualStyleBackColor = true;
            this.cbEliminar.CheckedChanged += new System.EventHandler(this.cbEliminar_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label11.Location = new System.Drawing.Point(333, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 119;
            this.label11.Text = "BUSCAR";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(409, 362);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(212, 22);
            this.txbBuscar.TabIndex = 10;
            this.txbBuscar.Text = "Todos";
            this.txbBuscar.TextChanged += new System.EventHandler(this.txbBuscar_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(127)))), ((int)(((byte)(48)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(629, 352);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 37);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(127)))), ((int)(((byte)(48)))));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(812, 353);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 37);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(127)))), ((int)(((byte)(48)))));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(941, 353);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(107, 37);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label12.Location = new System.Drawing.Point(591, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 121;
            this.label12.Text = "ROL";
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.cbRol.Location = new System.Drawing.Point(780, 112);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(190, 24);
            this.cbRol.TabIndex = 122;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 400);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(1043, 185);
            this.dgvUsuarios.TabIndex = 151;
            this.dgvUsuarios.DoubleClick += new System.EventHandler(this.dgvUsuarios_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.Frozen = true;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Visible = false;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1067, 597);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbEliminar);
            this.Controls.Add(this.txbNumeroDom);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbCalle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbMunicipio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbClave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbNumeroTelf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbApellidoM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbApellidoP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuarios";
            this.Text = "Registro de usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbApellidoP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbApellidoM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNumeroTelf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbClave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbMunicipio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbCalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbNumeroDom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbEliminar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
    }
}