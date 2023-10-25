
namespace Presentacion
{
    partial class FrmPerfilDeUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfilDeUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbApellidoP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbClave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMunicipio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCalle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbNumeroDomicilio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.lblRol);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 597);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.lblNombre.Location = new System.Drawing.Point(132, 280);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(99, 24);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label2.Location = new System.Drawing.Point(429, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "APELLIDO PATERNO";
            // 
            // txbApellidoP
            // 
            this.txbApellidoP.Location = new System.Drawing.Point(432, 165);
            this.txbApellidoP.Margin = new System.Windows.Forms.Padding(4);
            this.txbApellidoP.Name = "txbApellidoP";
            this.txbApellidoP.Size = new System.Drawing.Size(256, 22);
            this.txbApellidoP.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label3.Location = new System.Drawing.Point(429, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "APELIDO MATERNO";
            // 
            // txbApellidoMaterno
            // 
            this.txbApellidoMaterno.Location = new System.Drawing.Point(432, 226);
            this.txbApellidoMaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txbApellidoMaterno.Name = "txbApellidoMaterno";
            this.txbApellidoMaterno.Size = new System.Drawing.Size(256, 22);
            this.txbApellidoMaterno.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label4.Location = new System.Drawing.Point(746, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "USUARIO";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(749, 165);
            this.txbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(256, 22);
            this.txbUsuario.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label5.Location = new System.Drawing.Point(746, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "CONTRASEÑA";
            // 
            // txbClave
            // 
            this.txbClave.Location = new System.Drawing.Point(749, 228);
            this.txbClave.Margin = new System.Windows.Forms.Padding(4);
            this.txbClave.Name = "txbClave";
            this.txbClave.Size = new System.Drawing.Size(256, 22);
            this.txbClave.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label6.Location = new System.Drawing.Point(429, 358);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "MUNICIPIO";
            // 
            // txbMunicipio
            // 
            this.txbMunicipio.Location = new System.Drawing.Point(432, 378);
            this.txbMunicipio.Margin = new System.Windows.Forms.Padding(4);
            this.txbMunicipio.Name = "txbMunicipio";
            this.txbMunicipio.Size = new System.Drawing.Size(256, 22);
            this.txbMunicipio.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label7.Location = new System.Drawing.Point(429, 416);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "CALLE";
            // 
            // txbCalle
            // 
            this.txbCalle.Location = new System.Drawing.Point(432, 436);
            this.txbCalle.Margin = new System.Windows.Forms.Padding(4);
            this.txbCalle.Name = "txbCalle";
            this.txbCalle.Size = new System.Drawing.Size(256, 22);
            this.txbCalle.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label8.Location = new System.Drawing.Point(429, 477);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "NUMERO DE DOMICILIO";
            // 
            // txbNumeroDomicilio
            // 
            this.txbNumeroDomicilio.Location = new System.Drawing.Point(432, 497);
            this.txbNumeroDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txbNumeroDomicilio.Name = "txbNumeroDomicilio";
            this.txbNumeroDomicilio.Size = new System.Drawing.Size(256, 22);
            this.txbNumeroDomicilio.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label9.Location = new System.Drawing.Point(426, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 31);
            this.label9.TabIndex = 23;
            this.label9.Text = "UBICACIÓN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label10.Location = new System.Drawing.Point(426, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 31);
            this.label10.TabIndex = 24;
            this.label10.Text = "CREDENCIALES:";
            // 
            // lblRol
            // 
            this.lblRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRol.AutoSize = true;
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.lblRol.Location = new System.Drawing.Point(158, 316);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(45, 16);
            this.lblRol.TabIndex = 11;
            this.lblRol.Text = "Cargo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(127)))), ((int)(((byte)(48)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(898, 482);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 37);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(432, 109);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(256, 22);
            this.txbNombre.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(429, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "NOMBRE";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(749, 109);
            this.txbTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(256, 22);
            this.txbTelefono.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(52)))), ((int)(((byte)(20)))));
            this.label11.Location = new System.Drawing.Point(746, 89);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "TELEFONO";
            // 
            // FrmPerfilDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1067, 597);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbNumeroDomicilio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbCalle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbMunicipio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbClave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbApellidoMaterno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbApellidoP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPerfilDeUsuario";
            this.Text = "Perfil de Usuario";
            this.Load += new System.EventHandler(this.FrmPerfilDeUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbApellidoP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbApellidoMaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbClave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbMunicipio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbNumeroDomicilio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.Label label11;
    }
}