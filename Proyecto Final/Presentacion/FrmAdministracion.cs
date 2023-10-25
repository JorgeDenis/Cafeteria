using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Proyecto1.RN;
using Datos;

namespace Presentacion
{
    public partial class FrmAdministracion : Form
    {
        private string usuario;
        private string clave;
        private string rol;
        private int id;

        public FrmAdministracion(string usuario, string clave, string rol, int id)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.clave = clave;
            this.rol = rol;
            this.id = id;
        }

        public FrmAdministracion()
        {
            InitializeComponent();
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private void FrmAdministracion_Load(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmInicio());
            if (rol == "Administrador")
            {
                this.btnVendedores.Visible = true;
                this.pbLogoDorado.Visible = true;
                this.panelVendedores.Visible = true;

                this.btnrptVendedores.Visible = true;
                this.panelRptVendedores.Visible = true;
            }
            else
            {
                this.pbLogoBlanco.Visible = true;
            }

            
            actualizarNombre();

            
        }

        public void actualizarNombre()
        {
            RNVendedor ObjRNVendedor = new RNVendedor();
            Vendedor vendedor = ObjRNVendedor.TraerVendedorPorUsuarioParaLabel(usuario).FirstOrDefault();
            int panelWidth = this.MenuVertical.Width;
            int panelHeight = this.MenuVertical.Height;

            if (vendedor != null)
            {
                this.lblNombre.Text = vendedor.nombre;
            }

            int labelWidth = lblNombre.Width;

            int labelX = (panelWidth - labelWidth) / 2;

            lblNombre.Location = new Point(labelX, 163);
            lblNombre.BringToFront();
            pictureBox2.BringToFront();
            pictureBox2.Location = new Point(labelX + labelWidth, 165);
        }
        //================================================= BOTONES MENU ======================================================
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbLogoBlanco_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmInicio());
            if (this.SubmenuReportes.Visible)
            {
                this.cerrarSubmenuReportes();
            }

            this.btnProductos.BackColor = Color.FromArgb(89, 52, 20);
            this.btnClientes.BackColor = Color.FromArgb(89, 52, 20);
            this.btnVentas.BackColor = Color.FromArgb(89, 52, 20);
            this.btnReportes.BackColor = Color.FromArgb(89, 52, 20);
            this.btnVendedores.BackColor = Color.FromArgb(89, 52, 20);
        }

        private void pbLogoDorado_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmInicio());
            if (this.SubmenuReportes.Visible)
            {
                this.cerrarSubmenuReportes();
            }

            this.btnProductos.BackColor = Color.FromArgb(89, 52, 20);
            this.btnClientes.BackColor = Color.FromArgb(89, 52, 20);
            this.btnVentas.BackColor = Color.FromArgb(89, 52, 20);
            this.btnReportes.BackColor = Color.FromArgb(89, 52, 20);
            this.btnVendedores.BackColor = Color.FromArgb(89, 52, 20);
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            if (this.SubmenuReportes.Visible)
            {
                this.cerrarSubmenuReportes();
            }

            AbrirFormHija(new FrmPerfilDeUsuario(this.usuario, id, rol));

            this.btnProductos.BackColor = Color.FromArgb(89, 52, 20);
            this.btnClientes.BackColor = Color.FromArgb(89, 52, 20);
            this.btnVentas.BackColor = Color.FromArgb(89, 52, 20);
            this.btnReportes.BackColor = Color.FromArgb(89, 52, 20);
            this.btnVendedores.BackColor = Color.FromArgb(89, 52, 20);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (this.SubmenuReportes.Visible)
            {
                this.cerrarSubmenuReportes();
            }

            AbrirFormHija(new FrmProductos());

            this.btnProductos.BackColor = Color.FromArgb(242, 188, 141);
            this.btnClientes.BackColor = Color.FromArgb(89, 52, 20);
            this.btnVentas.BackColor = Color.FromArgb(89, 52, 20);
            this.btnReportes.BackColor = Color.FromArgb(89, 52, 20);
            this.btnVendedores.BackColor = Color.FromArgb(89, 52, 20);

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            if (this.SubmenuReportes.Visible)
            {
                this.cerrarSubmenuReportes();
            }
            AbrirFormHija(new FrmCliente());

            this.btnProductos.BackColor = Color.FromArgb(89, 52, 20);
            this.btnClientes.BackColor = Color.FromArgb(242, 188, 141);
            this.btnVentas.BackColor = Color.FromArgb(89, 52, 20);
            this.btnReportes.BackColor = Color.FromArgb(89, 52, 20);
            this.btnVendedores.BackColor = Color.FromArgb(89, 52, 20);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (this.SubmenuReportes.Visible)
            {
                this.cerrarSubmenuReportes();
            }
            AbrirFormHija(new FrmVenta(usuario));

            this.btnProductos.BackColor = Color.FromArgb(89, 52, 20);
            this.btnClientes.BackColor = Color.FromArgb(89, 52, 20);
            this.btnVentas.BackColor = Color.FromArgb(242, 188, 141);
            this.btnReportes.BackColor = Color.FromArgb(89, 52, 20);
            this.btnVendedores.BackColor = Color.FromArgb(89, 52, 20);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (this.SubmenuReportes.Visible)
            {
                this.cerrarSubmenuReportes();
            }
            else
            {
                SubmenuReportes.Visible = true;
                this.btnVendedores.Location = new Point(4, 461);
                this.panelVendedores.Location = new Point(0, 461); //410
            }

            this.btnProductos.BackColor = Color.FromArgb(89, 52, 20);
            this.btnClientes.BackColor = Color.FromArgb(89, 52, 20);
            this.btnVentas.BackColor = Color.FromArgb(89, 52, 20);
            this.btnReportes.BackColor = Color.FromArgb(242, 188, 141);
            this.btnVendedores.BackColor = Color.FromArgb(89, 52, 20);
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            if (this.SubmenuReportes.Visible)
            {
                this.cerrarSubmenuReportes();
            }
            AbrirFormHija(new FrmUsuarios());

            this.btnProductos.BackColor = Color.FromArgb(89, 52, 20);
            this.btnClientes.BackColor = Color.FromArgb(89, 52, 20);
            this.btnVentas.BackColor = Color.FromArgb(89, 52, 20);
            this.btnReportes.BackColor = Color.FromArgb(89, 52, 20);
            this.btnVendedores.BackColor = Color.FromArgb(242, 188, 141);
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        //================================================= BOTONES SUBMENU ======================================================
        private void btnrptVentas_Click(object sender, EventArgs e)
        {
            this.cerrarSubmenuReportes();
            AbrirFormHija(new FrmTopVentas());
        }

        private void btnrptVendedores_Click(object sender, EventArgs e)
        {
            this.cerrarSubmenuReportes();
            AbrirFormHija(new FrmTopVendedores());
        }

        private void btnrptClientes_Click(object sender, EventArgs e)
        {
            this.cerrarSubmenuReportes();
            AbrirFormHija(new FrmTopClientes());
        }


        //================================================= AUXILIARES ======================================================

        private void lblCerrarSesion_MouseEnter(object sender, EventArgs e)
        {
            lblCerrarSesion.Font = new Font(lblCerrarSesion.Font, FontStyle.Underline);
        }

        private void lblCerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            lblCerrarSesion.Font = new Font(lblCerrarSesion.Font, FontStyle.Regular);
        }


        private void lblNombre_MouseEnter(object sender, EventArgs e)
        {
            actualizarNombre();
            this.pictureBox2.Visible = true;
            this.lblNombre.Font = new Font(lblNombre.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblNombre_MouseLeave(object sender, EventArgs e)
        {
            actualizarNombre();
            this.pictureBox2.Visible = false;
            this.lblNombre.Font = new Font(lblNombre.Font, FontStyle.Bold | FontStyle.Regular);
        }





        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cerrarSubmenuReportes()
        {

            this.SubmenuReportes.Visible = false;
            this.btnVendedores.Location = new Point(4, 356);
            this.panelVendedores.Location = new Point(0, 356);
        }

        private void MenuVertical_Click(object sender, EventArgs e)
        {
            if (this.SubmenuReportes.Visible)
            {
                this.cerrarSubmenuReportes();
            }
        }


        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }







        
     }
}
