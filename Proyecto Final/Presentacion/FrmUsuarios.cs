using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Proyecto1.RN;
using Utilitarios;

namespace Presentacion
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            //this.txbId.Text = "";
            this.txbNombre.Text = "";
            this.txbApellidoP.Text = "";
            this.txbApellidoM.Text = "";
            this.txbNumeroTelf.Text = "";
            this.txbMunicipio.Text = "";
            this.txbCalle.Text = "";
            this.txbNumeroDom.Text = "";
            this.txbUsuario.Text = "";
            this.txbClave.Text = "";

            //this.txbBuscar.Text = "Todos";

            //this.cbEliminar.Checked = false;
            this.btnGuardar.Enabled = false;
            //this.btnEliminar.Enabled = false;
            //this.btnImprimir.Enabled = false;
            this.btnGuardar.Text = "Guardar";
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RNVendedor ObjRNVendedor = new RNVendedor();
            Vendedor ObjVendedor = new Vendedor();
            TelefonoVen ObjTelefonoVen = new TelefonoVen();

            if(this.btnGuardar.Text == "Guardar")
            {
                ObjVendedor.idVendedor = ObjRNVendedor.GenerarId();
                ObjVendedor.nombre = this.txbNombre.Text;
                ObjVendedor.apellidoPaterno = txbApellidoP.Text;
                ObjVendedor.apellidoMaterno = txbApellidoM.Text;
                ObjVendedor.usuario = txbUsuario.Text;
                ObjVendedor.clave = txbClave.Text;

                ObjTelefonoVen.idTelfVen = ObjVendedor.idVendedor;
                ObjTelefonoVen.idVendedor = ObjVendedor.idVendedor;
                ObjTelefonoVen.numero = this.txbNumeroTelf.Text;

                ObjVendedor.rol = this.cbRol.Text;
                ObjVendedor.municipio = txbMunicipio.Text;
                ObjVendedor.calle = txbCalle.Text;
                ObjVendedor.numero = txbNumeroDom.Text;


                if (ObjRNVendedor.Insertar(ObjVendedor, ObjTelefonoVen))
                {
                    MessageBox.Show("Usuario insertado con exito!");
                    this.txbCodigo.Text = ObjVendedor.idVendedor.ToString();
                    this.dgvUsuarios.DataSource = ObjRNVendedor.TraerVendedor(ObjVendedor.idVendedor);
                    Utilitarios.Utilitarios.id = ObjVendedor.idVendedor;
                }
                else
                {
                    MessageBox.Show("Error en el registro de Usuario");
                }
            }
            else
            {
                ObjVendedor.idVendedor = Convert.ToInt32(this.txbCodigo.Text);
                ObjVendedor.nombre = this.txbNombre.Text;
                ObjVendedor.apellidoPaterno = txbApellidoP.Text;
                ObjVendedor.apellidoMaterno = txbApellidoM.Text;
                ObjVendedor.usuario = txbUsuario.Text;
                ObjVendedor.clave = txbClave.Text;

                ObjTelefonoVen.idTelfVen = ObjVendedor.idVendedor;
                ObjTelefonoVen.idVendedor = ObjVendedor.idVendedor;
                ObjTelefonoVen.numero = this.txbNumeroTelf.Text;

                ObjVendedor.rol = this.cbRol.ValueMember;
                ObjVendedor.municipio = txbMunicipio.Text;
                ObjVendedor.calle = txbCalle.Text;
                ObjVendedor.numero = txbNumeroDom.Text;

                if(ObjRNVendedor.Modificar(ObjVendedor, ObjTelefonoVen))
                {
                    MessageBox.Show("Datos actualizados con exito!");
                    this.txbCodigo.Text = ObjVendedor.idVendedor.ToString();
                    this.dgvUsuarios.DataSource = ObjRNVendedor.TraerVendedor(ObjVendedor.idVendedor);
                    Utilitarios.Utilitarios.id = ObjVendedor.idVendedor;
                }
                else
                {
                    MessageBox.Show("Error en la actualizacion de los datos");
                }

            }
            this.dgvUsuarios.DataSource = ObjRNVendedor.TraerVendedor(Convert.ToInt32(this.txbCodigo.Text));
            //this.limpiar();
        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {
            this.btnGuardar.Enabled = true;
            RNVendedor ObjRNVendedor = new RNVendedor();
            if (ObjRNVendedor.TraerVendedorPorNombre(this.txbNombre.Text).Count > 0)
            {
                this.dgvUsuarios.DataSource = ObjRNVendedor.TraerVendedorPorNombre(this.txbNombre.Text);
            }
            else
            {
                this.dgvUsuarios.DataSource = ObjRNVendedor.TraerVendedorPorNombre(this.txbNombre.Text);
            }
        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {
            RNVendedor ObjRNVendedor = new RNVendedor();
            if (ObjRNVendedor.TraerVendedorPorUsuario(this.txbUsuario.Text).Count > 0)
            {
                this.dgvUsuarios.DataSource = ObjRNVendedor.TraerVendedorPorUsuario(this.txbUsuario.Text);
            }
            else
            {
                this.dgvUsuarios.DataSource = ObjRNVendedor.TraerVendedorPorUsuario(this.txbUsuario.Text);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.NroReporte = 1;
            FrmReportes ObjFrmReporte = new FrmReportes();
            ObjFrmReporte.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.limpiar();
            RNVendedor ObjRNVendedor = new RNVendedor();
            if (this.txbBuscar.Text == "Todos" || this.txbBuscar.Text == "")
            {
                this.dgvUsuarios.DataSource = ObjRNVendedor.TraerVendedor(0);
                this.txbCodigo.Text = "0";
            }
            else
            {
                int id;
                if (int.TryParse(this.txbBuscar.Text, out id))
                {
                    this.dgvUsuarios.DataSource = ObjRNVendedor.TraerVendedor(id);
                }
                else
                {
                    this.dgvUsuarios.DataSource = ObjRNVendedor.TraerVendedorPorNombre(this.txbBuscar.Text);
                }

            }
        }

        private void cbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            RNVendedor ObjRNVendedor = new RNVendedor();
            if (cbEliminar.Checked)
            {
                this.dgvUsuarios.Columns[0].Visible = true;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.dgvUsuarios.Columns[0].Visible = false;
                this.btnEliminar.Enabled = false;
            }
            this.dgvUsuarios.DataSource = ObjRNVendedor.TraerVendedor(0);
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            RNVendedor ObjRNVendedor = new RNVendedor();
            if (this.txbBuscar.Text == "Todos")
            {
                this.dgvUsuarios.DataSource = ObjRNVendedor.TraerVendedor(0);
            }
            else
            {
                int id;
                if (int.TryParse(this.txbBuscar.Text, out id))
                {
                    this.dgvUsuarios.DataSource = ObjRNVendedor.TraerVendedor(id);
                }
                else
                {
                    this.dgvUsuarios.DataSource = ObjRNVendedor.TraerVendedorPorNombre(this.txbBuscar.Text);
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            RNVendedor ObjRNVendedor = new RNVendedor();
            Vendedor ObjVendedor = new Vendedor();
            TelefonoVen ObjTelefonoVen = new TelefonoVen();

            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Está seguro que desea eliminar estos registros?", "Usuarios", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    Boolean Rpta = false;
                    foreach (DataGridViewRow row in dgvUsuarios.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            ObjVendedor.idVendedor = Convert.ToInt32(row.Cells[1].Value);
                            ObjTelefonoVen.idTelfVen = Convert.ToInt32(row.Cells[1].Value);

                            Rpta = ObjRNVendedor.Eliminar(ObjVendedor, ObjTelefonoVen);

                            if (Rpta)
                            {
                                this.MensajeOk("Se elimino correctamente");
                                this.cbEliminar.Checked = false;
                            }
                            else
                            {
                                this.MensajeError("No se pudo eliminar porque el Usuario, esta asignado a otras tablas");
                                this.cbEliminar.Checked = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            this.dgvUsuarios.DataSource = ObjRNVendedor.TraerVendedor(0);
        }

        private void dgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            this.txbCodigo.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[1].Value);
            this.txbNombre.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[2].Value);
            this.txbApellidoP.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[3].Value);
            this.txbApellidoM.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[4].Value);
            this.txbUsuario.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[5].Value);
            this.txbClave.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[6].Value);
            this.txbNumeroTelf.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[7].Value);
            this.txbCalle.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[8].Value);
            this.txbNumeroDom.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[9].Value);
            this.txbMunicipio.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[10].Value);
            this.cbRol.SelectedItem = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells[11].Value);
            this.btnGuardar.Text = "Actualizar";
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells[1].Value);

                

                Utilitarios.Utilitarios.id = id;
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
