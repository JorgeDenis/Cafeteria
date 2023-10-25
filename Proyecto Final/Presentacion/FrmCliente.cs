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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            this.txbCodigo.Text = "Autonumérico";
            this.txbNombre.Text = "";
            this.txbApellidoP.Text = "";
            this.txbApellidoM.Text = "";
            this.txbNumeroTelf.Text = "";
            this.txbMunicipio.Text = "";
            this.txbCalle.Text = "";
            this.txbNumeroDom.Text = "";
            this.rbFemenino.Checked = false;
            this.rbMasculino.Checked = false;
            this.txbBuscar.Text = "Todos";
            this.cbEliminar.Checked = false;
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //================================================ BOTONES =========================================================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RNCliente ObjRNCliente = new RNCliente();
            Clientes ObjCliente = new Clientes();
            TelefonoCli ObjTelefonoCli = new TelefonoCli();
            DireccionCli ObjDireccionCli = new DireccionCli();

            if (this.verificarCamposVacios())
            {
                MessageBox.Show("Llene todos los campos");
            }
            else
            {
                ObjCliente.idCliente = ObjRNCliente.GenerarId();
                ObjCliente.nombre = this.txbNombre.Text;
                ObjCliente.apellidoPaterno = txbApellidoP.Text;
                ObjCliente.apellidoMaterno = txbApellidoM.Text;
                if (rbFemenino.Checked)
                {
                    ObjCliente.genero = "Femenino";
                }
                else
                {
                    ObjCliente.genero = "Masculino";
                }
                ObjTelefonoCli.idTelfCli = ObjCliente.idCliente;
                ObjTelefonoCli.idCliente = ObjCliente.idCliente;
                ObjTelefonoCli.numero = Convert.ToInt32(this.txbNumeroTelf.Text);

                ObjDireccionCli.idDirCli = ObjCliente.idCliente;
                ObjDireccionCli.idCliente = ObjCliente.idCliente;
                ObjDireccionCli.municipio = txbMunicipio.Text;
                ObjDireccionCli.calles = txbCalle.Text;
                ObjDireccionCli.numero = Convert.ToInt32(txbNumeroDom.Text);


                if (ObjRNCliente.Insertar(ObjCliente, ObjTelefonoCli, ObjDireccionCli))
                {
                    MessageBox.Show("Usuario insertado con éxito!");
                    this.txbCodigo.Text = ObjCliente.idCliente.ToString();
                    this.dgvCliente.DataSource = ObjRNCliente.TraerClientes(ObjCliente.idCliente);
                    Utilitarios.Utilitarios.id = ObjCliente.idCliente;
                }
                else
                {
                    MessageBox.Show("Error en el registro de Usuario");
                }
                this.dgvCliente.DataSource = ObjRNCliente.TraerClientes(Convert.ToInt32(this.txbCodigo.Text));
            }
        }
        //anotaciones
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void btnClientesEstrella_Click(object sender, EventArgs e)
        {
            this.limpiar();
            RNCliente ObjRNCliente = new RNCliente();
            this.dgvCliente.DataSource = ObjRNCliente.TopClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.txbCodigo.Text = "0";
            this.limpiar();
            RNCliente ObjRNCliente = new RNCliente();
            if (this.txbBuscar.Text == "Todos" || this.txbBuscar.Text == "")
            {
                this.dgvCliente.DataSource = ObjRNCliente.TraerClientes(0);
                this.txbCodigo.Text = "0";
            }
            else
            {
                int id;
                if (int.TryParse(this.txbBuscar.Text, out id))
                {
                    this.dgvCliente.DataSource = ObjRNCliente.TraerClientes(id);
                }
                else
                {
                    this.dgvCliente.DataSource = ObjRNCliente.TraerClientesPorNombre(this.txbBuscar.Text);
                }

            }
        }
      
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            RNCliente ObjRNCliente = new RNCliente();
            Clientes ObjCliente = new Clientes();
            TelefonoCli ObjTelefonoCli = new TelefonoCli();
            DireccionCli ObjDireccionCli = new DireccionCli();

            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Está seguro que desea eliminar estos registros?", "Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    Boolean Rpta = false;
                    foreach (DataGridViewRow row in dgvCliente.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            ObjCliente.idCliente = Convert.ToInt32(row.Cells[1].Value);
                            ObjTelefonoCli.idTelfCli = Convert.ToInt32(row.Cells[1].Value);
                            ObjDireccionCli.idDirCli = Convert.ToInt32(row.Cells[1].Value);

                            Rpta = ObjRNCliente.Eliminar(ObjCliente, ObjTelefonoCli, ObjDireccionCli);

                            if (Rpta)
                            {
                                this.MensajeOk("Se elimino correctamente");
                                this.cbEliminar.Checked = false;
                            }
                            else
                            {
                                this.MensajeError("No se pudo eliminar porque el Cliente, esta asignado a otras tablas");
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
            this.dgvCliente.DataSource = ObjRNCliente.TraerClientes(0);
        }

        //================================================ DETECTAR CAMBIOS =========================================================================
        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            RNCliente ObjRNCliente = new RNCliente();
            if (this.txbBuscar.Text == "Todos")
            {
                this.dgvCliente.DataSource = ObjRNCliente.TraerClientes(0);
            }
            else
            {
                int id;
                if (int.TryParse(this.txbBuscar.Text, out id))
                {
                    this.dgvCliente.DataSource = ObjRNCliente.TraerClientes(id);
                }
                else
                {
                    this.dgvCliente.DataSource = ObjRNCliente.TraerClientesPorNombre(this.txbBuscar.Text);
                }

            }
        }

        private void cbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            RNCliente ObjRNCliente = new RNCliente();
            if (cbEliminar.Checked)
            {
                this.dgvCliente.Columns[0].Visible = true;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.dgvCliente.Columns[0].Visible = false;
                this.btnEliminar.Enabled = false;
            }
            this.dgvCliente.DataSource = ObjRNCliente.TraerClientes(0);
        }

        

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCliente.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells[1].Value);



                Utilitarios.Utilitarios.id = id;
            }
        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            this.txbCodigo.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells[1].Value);
            this.txbNombre.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells[2].Value);
            this.txbApellidoP.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells[3].Value);
            this.txbApellidoM.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells[4].Value);
            if (Convert.ToString(this.dgvCliente.CurrentRow.Cells[5].Value) == "Femenino")
            {
                this.rbFemenino.Checked = true;
            }
            else
            {
                this.rbMasculino.Checked = true;
            }

            this.txbNumeroTelf.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells[6].Value);
            this.txbMunicipio.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells[7].Value);
            this.txbCalle.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells[8].Value);
            this.txbNumeroDom.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells[9].Value);
            this.btnGuardar.Text = "Actualizar";
        }

        //================================================ METODOS AUXILIARES =========================================================================
        private void txbNumeroTelf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbNumeroDom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool verificarCamposVacios()
        {
            bool vacio = false;

            foreach (TextBox textBox in new TextBox[] { txbNombre, txbApellidoP, txbApellidoM, txbNumeroTelf, txbMunicipio, txbCalle, txbNumeroDom })
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    vacio = true;
                    break; // Si un campo de TextBox está vacío, no es necesario verificar más campos.
                }
            }

            // Verificar si al menos un género está seleccionado
            if (!(rbFemenino.Checked || rbMasculino.Checked))
            {
                vacio = true;
            }

            return vacio;
        }
    }
}
