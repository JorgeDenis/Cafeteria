using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto1.RN;
using Datos;

namespace Presentacion
{
    public partial class FrmPerfilDeUsuario : Form
    {
        private string usuario;
        private int id;
        private string rol;
        public FrmPerfilDeUsuario()
        {
            InitializeComponent();
        }
        public FrmPerfilDeUsuario(string usuario, int id, string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.id = id;
            this.rol = rol;
        }

        FrmAdministracion frmAdmin = new FrmAdministracion();

        private void FrmPerfilDeUsuario_Load(object sender, EventArgs e)
        {
            int panelWidth = this.panel1.Width;

            RNVendedor ObjRNVendedor = new RNVendedor();
            Vendedor ObjVendedor = ObjRNVendedor.TraerVendedorPorUsuarioParaLabel(usuario).FirstOrDefault();


            if (ObjVendedor != null)
            {
                this.lblNombre.Text = ObjVendedor.nombre;
                this.lblRol.Text = ObjVendedor.rol;

                this.txbNombre.Text = ObjVendedor.nombre;
                this.txbApellidoP.Text = ObjVendedor.apellidoPaterno;
                this.txbApellidoMaterno.Text = ObjVendedor.apellidoMaterno;
                //this.txbTelefono.Text = ObjVendedor.dom;

                this.txbUsuario.Text = ObjVendedor.usuario;
                this.txbClave.Text = ObjVendedor.clave;

                this.txbMunicipio.Text = ObjVendedor.municipio;
                this.txbCalle.Text = ObjVendedor.calle;
                this.txbNumeroDomicilio.Text = ObjVendedor.numero;
            }

            int labelWidth = lblNombre.Width;
            int labelWidth2 = lblRol.Width;
            int pictureBoxWidth = pictureBox1.Width;

            int labelX = (panelWidth - labelWidth) / 2;
            int label2X = (panelWidth - labelWidth2) / 2;
            int pictureBoxX = (panelWidth - pictureBoxWidth) / 2;

            lblNombre.Location = new Point(labelX, 300);
            lblRol.Location = new Point(label2X, 336);
            pictureBox1.Location = new Point(pictureBoxX, 100);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RNVendedor ObjRNVendedor = new RNVendedor();
            Vendedor ObjVendedor = new Vendedor();
            TelefonoVen ObjTelefonoVen = new TelefonoVen();
            bool guardar = false;
            if (string.IsNullOrWhiteSpace(txbNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' está vacío.");
            }
            else
            {
                guardar = true;
            }

            if (string.IsNullOrWhiteSpace(txbApellidoP.Text))
            {
                MessageBox.Show("El campo 'Apellido Paterno' está vacío.");
            }
            else
            {
                guardar = true;
            }

            if (string.IsNullOrWhiteSpace(txbApellidoMaterno.Text))
            {
                MessageBox.Show("El campo 'Apellido Materno' está vacío.");
            }
            else
            {
                guardar = true;
            }

            if (string.IsNullOrWhiteSpace(txbUsuario.Text))
            {
                MessageBox.Show("El campo 'Usuario' está vacío.");
            }
            else
            {
                guardar = true;
            }

            if (string.IsNullOrWhiteSpace(txbClave.Text))
            {
                MessageBox.Show("El campo 'Clave' está vacío.");
            }
            else
            {
                guardar = true;
            }

            if (string.IsNullOrWhiteSpace(txbMunicipio.Text))
            {
                MessageBox.Show("El campo 'Municipio' está vacío.");
            }
            else
            {
                guardar = true;
            }

            if (string.IsNullOrWhiteSpace(txbCalle.Text))
            {
                MessageBox.Show("El campo 'Calle' está vacío.");
            }
            else
            {
                guardar = true;
            }

            if (string.IsNullOrWhiteSpace(txbNumeroDomicilio.Text))
            {
                MessageBox.Show("El campo 'Número de Domicilio' está vacío.");
            }
            else
            {
                guardar = true;
            }

            if (string.IsNullOrWhiteSpace(txbTelefono.Text))
            {
                MessageBox.Show("El campo 'Número de Teléfono' está vacío.");
            }
            else
            {
                guardar = true;
            }

            if (guardar)
            {
                ObjVendedor.idVendedor = this.id;
                ObjVendedor.nombre = this.txbNombre.Text;
                ObjVendedor.apellidoPaterno = txbApellidoP.Text;
                ObjVendedor.apellidoMaterno = txbApellidoMaterno.Text;
                ObjVendedor.usuario = txbUsuario.Text;
                ObjVendedor.clave = txbClave.Text;
                ObjVendedor.municipio = txbMunicipio.Text;
                ObjVendedor.calle = txbCalle.Text;
                ObjVendedor.numero = txbNumeroDomicilio.Text;
                ObjVendedor.rol = this.rol;

                ObjTelefonoVen.idTelfVen = ObjVendedor.idVendedor;
                ObjTelefonoVen.idVendedor = ObjVendedor.idVendedor;
                ObjTelefonoVen.numero = this.txbTelefono.Text;


                if (ObjRNVendedor.Modificar(ObjVendedor, ObjTelefonoVen))
                {
                    MessageBox.Show("Datos actualizados!");
                }
                else
                {
                    MessageBox.Show("Llene todos los campos correctamente");
                }
            }
            

            this.lblNombre.Text = this.txbNombre.Text;

            int panelWidth = this.panel1.Width;
            int labelWidth = lblNombre.Width;
            int labelWidth2 = lblRol.Width;
            int pictureBoxWidth = pictureBox1.Width;

            int labelX = (panelWidth - labelWidth) / 2;
            int label2X = (panelWidth - labelWidth2) / 2;
            int pictureBoxX = (panelWidth - pictureBoxWidth) / 2;

            lblNombre.Location = new Point(labelX, 300);
            lblRol.Location = new Point(label2X, 336);

            this.frmAdmin.actualizarNombre();

        }
    }
}
