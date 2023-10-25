
namespace Presentacion
{
    partial class FrmCliente
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
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbNumeroDom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbCalle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbMunicipio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbNumeroTelf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbApellidoM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbApellidoP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnClientesEstrella = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(409, 362);
            this.txbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txbBuscar.MaxLength = 100;
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(212, 22);
            this.txbBuscar.TabIndex = 120;
            this.txbBuscar.Text = "Todos";
            this.txbBuscar.TextChanged += new System.EventHandler(this.txbBuscar_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label11.Location = new System.Drawing.Point(333, 366);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 126;
            this.label11.Text = "BUSCAR";
            // 
            // cbEliminar
            // 
            this.cbEliminar.AutoSize = true;
            this.cbEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.cbEliminar.Location = new System.Drawing.Point(16, 365);
            this.cbEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(89, 20);
            this.cbEliminar.TabIndex = 125;
            this.cbEliminar.Text = "ELIMINAR";
            this.cbEliminar.UseVisualStyleBackColor = true;
            this.cbEliminar.CheckedChanged += new System.EventHandler(this.cbEliminar_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(127)))), ((int)(((byte)(48)))));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(940, 352);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 37);
            this.btnEliminar.TabIndex = 122;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(127)))), ((int)(((byte)(48)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(629, 352);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 37);
            this.btnBuscar.TabIndex = 121;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txbNumeroDom
            // 
            this.txbNumeroDom.Location = new System.Drawing.Point(659, 123);
            this.txbNumeroDom.Margin = new System.Windows.Forms.Padding(4);
            this.txbNumeroDom.MaxLength = 10;
            this.txbNumeroDom.Name = "txbNumeroDom";
            this.txbNumeroDom.Size = new System.Drawing.Size(237, 22);
            this.txbNumeroDom.TabIndex = 136;
            this.txbNumeroDom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumeroDom_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label10.Location = new System.Drawing.Point(486, 127);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 16);
            this.label10.TabIndex = 147;
            this.label10.Text = "NUMERO DE DOMICILIO";
            // 
            // txbCalle
            // 
            this.txbCalle.Location = new System.Drawing.Point(659, 91);
            this.txbCalle.Margin = new System.Windows.Forms.Padding(4);
            this.txbCalle.MaxLength = 100;
            this.txbCalle.Name = "txbCalle";
            this.txbCalle.Size = new System.Drawing.Size(237, 22);
            this.txbCalle.TabIndex = 135;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label9.Location = new System.Drawing.Point(486, 95);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 146;
            this.label9.Text = "CALLE";
            // 
            // txbMunicipio
            // 
            this.txbMunicipio.Location = new System.Drawing.Point(659, 59);
            this.txbMunicipio.Margin = new System.Windows.Forms.Padding(4);
            this.txbMunicipio.MaxLength = 50;
            this.txbMunicipio.Name = "txbMunicipio";
            this.txbMunicipio.Size = new System.Drawing.Size(237, 22);
            this.txbMunicipio.TabIndex = 134;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label8.Location = new System.Drawing.Point(486, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 145;
            this.label8.Text = "MUNICIPIO";
            // 
            // txbNumeroTelf
            // 
            this.txbNumeroTelf.Location = new System.Drawing.Point(659, 27);
            this.txbNumeroTelf.Margin = new System.Windows.Forms.Padding(4);
            this.txbNumeroTelf.MaxLength = 20;
            this.txbNumeroTelf.Name = "txbNumeroTelf";
            this.txbNumeroTelf.Size = new System.Drawing.Size(237, 22);
            this.txbNumeroTelf.TabIndex = 131;
            this.txbNumeroTelf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumeroTelf_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label5.Location = new System.Drawing.Point(486, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 16);
            this.label5.TabIndex = 142;
            this.label5.Text = "NUMERO DE TELEFONO";
            // 
            // txbApellidoM
            // 
            this.txbApellidoM.Location = new System.Drawing.Point(193, 123);
            this.txbApellidoM.Margin = new System.Windows.Forms.Padding(4);
            this.txbApellidoM.MaxLength = 50;
            this.txbApellidoM.Name = "txbApellidoM";
            this.txbApellidoM.Size = new System.Drawing.Size(237, 22);
            this.txbApellidoM.TabIndex = 130;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label4.Location = new System.Drawing.Point(44, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 141;
            this.label4.Text = "APELLIDO MATERNO";
            // 
            // txbApellidoP
            // 
            this.txbApellidoP.Location = new System.Drawing.Point(193, 91);
            this.txbApellidoP.Margin = new System.Windows.Forms.Padding(4);
            this.txbApellidoP.MaxLength = 50;
            this.txbApellidoP.Name = "txbApellidoP";
            this.txbApellidoP.Size = new System.Drawing.Size(237, 22);
            this.txbApellidoP.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label3.Location = new System.Drawing.Point(44, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 140;
            this.label3.Text = "APELLIDO PATERNO";
            // 
            // txbCodigo
            // 
            this.txbCodigo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbCodigo.Enabled = false;
            this.txbCodigo.Location = new System.Drawing.Point(193, 27);
            this.txbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(132, 22);
            this.txbCodigo.TabIndex = 138;
            this.txbCodigo.Text = "Autonumerico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label2.Location = new System.Drawing.Point(44, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 139;
            this.label2.Text = "CODIGO";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(127)))), ((int)(((byte)(48)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(193, 190);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 37);
            this.btnGuardar.TabIndex = 137;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(193, 59);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txbNombre.MaxLength = 50;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(237, 22);
            this.txbNombre.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(44, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 127;
            this.label1.Text = "NOMBRE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label12.Location = new System.Drawing.Point(44, 157);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 148;
            this.label12.Text = "GENERO";
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.rbFemenino.Location = new System.Drawing.Point(193, 153);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(4);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(96, 20);
            this.rbFemenino.TabIndex = 149;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "FEMENINO";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.rbMasculino.Location = new System.Drawing.Point(326, 153);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(104, 20);
            this.rbMasculino.TabIndex = 149;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "MASCULINO";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToOrderColumns = true;
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.dgvCliente.Location = new System.Drawing.Point(12, 400);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.Size = new System.Drawing.Size(1036, 185);
            this.dgvCliente.TabIndex = 150;
            // 
            // Eliminar
            // 
            this.Eliminar.Frozen = true;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Visible = false;
            // 
            // btnClientesEstrella
            // 
            this.btnClientesEstrella.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(127)))), ((int)(((byte)(48)))));
            this.btnClientesEstrella.FlatAppearance.BorderSize = 0;
            this.btnClientesEstrella.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnClientesEstrella.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientesEstrella.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientesEstrella.Location = new System.Drawing.Point(391, 273);
            this.btnClientesEstrella.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientesEstrella.Name = "btnClientesEstrella";
            this.btnClientesEstrella.Size = new System.Drawing.Size(279, 37);
            this.btnClientesEstrella.TabIndex = 151;
            this.btnClientesEstrella.Text = "Top Clientes";
            this.btnClientesEstrella.UseVisualStyleBackColor = false;
            this.btnClientesEstrella.Click += new System.EventHandler(this.btnClientesEstrella_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(127)))), ((int)(((byte)(48)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(323, 190);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 37);
            this.btnLimpiar.TabIndex = 152;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1060, 597);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnClientesEstrella);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.rbFemenino);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txbNumeroDom);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbCalle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbMunicipio);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCliente";
            this.Text = "Registro de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbNumeroDom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbCalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbMunicipio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbNumeroTelf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbApellidoM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbApellidoP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button btnClientesEstrella;
        private System.Windows.Forms.Button btnLimpiar;
    }
}