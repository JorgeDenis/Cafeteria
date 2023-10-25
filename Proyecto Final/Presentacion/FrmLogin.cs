using Datos;
using Proyecto1.RN;
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

namespace Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

        }



        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txbClave.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            RNVendedor ObjRNVendedor = new RNVendedor();
            FrmAdministracion frmAdmin = new FrmAdministracion();
            try
            {
                List<Vendedor> vendedores = ObjRNVendedor.VendedorLista();
                Boolean Rpta = false;
                string rol = "";
                int id = -1;
                foreach (Vendedor vendedor in vendedores)
                {
                    if (vendedor.usuario == this.txbUsuario.Text && vendedor.clave == this.txbClave.Text)
                    {
                        Rpta = true;
                        rol = vendedor.rol;
                        id = vendedor.idVendedor;
                    }
                }
                if (Rpta)
                {
                    frmAdmin = new FrmAdministracion(this.txbUsuario.Text, this.txbClave.Text, rol, id);
                    frmAdmin.Show();

                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Usuario o Clave incorrecta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void txbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                RNVendedor ObjRNVendedor = new RNVendedor();
                FrmAdministracion frmAdmin = new FrmAdministracion();
                try
                {
                    List<Vendedor> vendedores = ObjRNVendedor.VendedorLista();
                    Boolean Rpta = false;
                    string rol = "";
                    int id = -1;
                    foreach (Vendedor vendedor in vendedores)
                    {
                        if (vendedor.usuario == this.txbUsuario.Text && vendedor.clave == this.txbClave.Text)
                        {
                            Rpta = true;
                            rol = vendedor.rol;
                            id = vendedor.idVendedor;
                        }
                    }
                    if (Rpta)
                    {
                        frmAdmin = new FrmAdministracion(this.txbUsuario.Text, this.txbClave.Text, rol, id);
                        frmAdmin.Show();

                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Usuario o Clave incorrecta");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txbClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                RNVendedor ObjRNVendedor = new RNVendedor();
                FrmAdministracion frmAdmin = new FrmAdministracion();
                try
                {
                    List<Vendedor> vendedores = ObjRNVendedor.VendedorLista();
                    Boolean Rpta = false;
                    string rol = "";
                    int id = -1;
                    foreach (Vendedor vendedor in vendedores)
                    {
                        if (vendedor.usuario == this.txbUsuario.Text && vendedor.clave == this.txbClave.Text)
                        {
                            Rpta = true;
                            rol = vendedor.rol;
                            id = vendedor.idVendedor;
                        }
                    }
                    if (Rpta)
                    {
                        frmAdmin = new FrmAdministracion(this.txbUsuario.Text, this.txbClave.Text, rol, id);
                        frmAdmin.Show();

                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Usuario o Clave incorrecta");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
