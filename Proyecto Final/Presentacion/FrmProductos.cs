using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Proyecto1.RN;
using Utilitarios;

namespace Presentacion
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        //======================================== INICIO DE FORMULARIO Y CAMPOS PREDETERMINADOS ====================================================================
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            this.CargarComboTipo();
        }

        private void limpiar()
        {
            this.txbCodigo.Text = "Autonumerico";
            this.txbNombre.Text = "";
            this.txbPrecio.Text = "";
            this.cbTipo.SelectedIndex = 1;
            this.nudCantidad.Value = 1;
            this.txbDesc.Text = "";
            this.txbBuscar.Text = "Todos";
            this.cbEliminar.Checked = false;
            this.btnGuardar.Enabled = false;
            this.btnImprimir.Enabled = false;
            this.btnGuardar.Enabled = true;
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CargarComboTipo()
        {
            RNTipoProducto ObjRNTipoProducto = new RNTipoProducto();
            this.cbTipo.DataSource = ObjRNTipoProducto.TraerTipoProducto(0);
            this.cbTipo.DisplayMember = "tipo";
            this.cbTipo.ValueMember = "idTipoProducto";
        }

        //======================================== BOTONES ====================================================================

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RNProducto ObjRNProducto = new RNProducto();
            Producto ObjProducto = new Producto();

            if (this.verificarCamposVacios())
            {
                MessageBox.Show("Llene todos los campos");
            }
            else
            {
                ObjProducto.idProducto = ObjRNProducto.GenerarId();
                ObjProducto.nombre = this.txbNombre.Text;
                ObjProducto.precio = Convert.ToDecimal(this.txbPrecio.Text);
                ObjProducto.idTipoProd = int.Parse(this.cbTipo.SelectedValue.ToString());
                ObjProducto.disponible = "si";
                ObjProducto.descripcion = this.txbDesc.Text;
                ObjProducto.stock = Convert.ToInt32(this.nudCantidad.Value);

                if (ObjRNProducto.Insertar(ObjProducto))
                {
                    MessageBox.Show("Producto insertado con exito!");
                    this.txbCodigo.Text = ObjProducto.idProducto.ToString();
                    this.dgvProductos.DataSource = ObjRNProducto.TraerProductos(ObjProducto.idProducto);
                    Utilitarios.Utilitarios.id = ObjProducto.idProducto;
                }
                else
                {
                    MessageBox.Show("Error en el registro de Usuario");
                }

                this.dgvProductos.DataSource = ObjRNProducto.TraerProductos(Convert.ToInt32(this.txbCodigo.Text));
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.txbCodigo.Text = "Autonumerico";
            RNProducto ObjRNProducto = new RNProducto();
            if (this.txbBuscar.Text == "Todos")
            {
                this.dgvProductos.DataSource = ObjRNProducto.TraerProductos(0);
            }
            else
            {
                int id;
                if (int.TryParse(this.txbBuscar.Text, out id))
                {
                    this.dgvProductos.DataSource = ObjRNProducto.TraerProductos(id);
                }
                else
                {
                    this.dgvProductos.DataSource = ObjRNProducto.TraerProductosPorNombre(this.txbBuscar.Text);
                }
            }
        }
        //===========================================================
        private void btnImprimir_Click(object sender, EventArgs e)//=
        {
            if (this.txbCodigo.Text == "0")//========================
                Utilitarios.Utilitarios.NroReporte = 3;//============                //        BOTON DESHABILITADO PARA IMPRIMIR REGISTRO
            FrmReportes ObjFrmReporte = new FrmReportes();//=========
            ObjFrmReporte.Show();//==================================
        }
        //===========================================================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            RNProducto ObjRNProducto = new RNProducto();
            Producto ObjProducto = new Producto();
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Está seguro que desea eliminar estos registros?", "Productos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    Boolean Rpta = false;
                    foreach (DataGridViewRow row in dgvProductos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            ObjProducto.idProducto = Convert.ToInt32(row.Cells[1].Value);
                            ObjProducto.nombre = Convert.ToString(row.Cells[2].Value);
                            ObjProducto.precio = Convert.ToDecimal(row.Cells[3].Value);
                            int tipoProducto = ObjRNProducto.TraerIdTipoProductoNombre(Convert.ToString(row.Cells[4].Value));
                            ObjProducto.idTipoProd = tipoProducto;
                            ObjProducto.descripcion = ObjRNProducto.TraerDesc(ObjProducto.idProducto);
                            ObjProducto.disponible = "no";

                            Rpta = ObjRNProducto.Eliminar(ObjProducto);
                        }
                    }
                    if (Rpta)
                    {
                        this.MensajeOk("Se elimino correctamente");
                    }
                    else
                    {
                        this.MensajeError("No se pudo eliminar porque el Producto");
                    }
                }
                this.cbEliminar.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            this.dgvProductos.DataSource = ObjRNProducto.TraerProductos(0);
        }


        //======================================== DETECTAR CAMBIOS ====================================================================

        private void cbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            RNProducto ObjRNProducto = new RNProducto();
            if (cbEliminar.Checked)
            {
                this.dgvProductos.Columns[0].Visible = true;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.dgvProductos.Columns[0].Visible = false;
                this.btnEliminar.Enabled = false;
            }
            this.dgvProductos.DataSource = ObjRNProducto.TraerProductos(0);
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            RNProducto ObjRNProducto = new RNProducto();
            if (this.txbBuscar.Text == "Todos")
            {
                this.dgvProductos.DataSource = ObjRNProducto.TraerProductos(0);
            }
            else
            {
                int id;
                if (int.TryParse(this.txbBuscar.Text, out id))
                {
                    this.dgvProductos.DataSource = ObjRNProducto.TraerProductos(id);
                }
                else
                {
                    this.dgvProductos.DataSource = ObjRNProducto.TraerProductosPorNombre(this.txbBuscar.Text);
                }

            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells[1].Value);
                Utilitarios.Utilitarios.id = id;
            }
            RNProducto ObjRnProducto = new RNProducto();

            this.lblDesc.Text = ObjRnProducto.TraerDesc(Convert.ToInt32(this.dgvProductos.CurrentRow.Cells[1].Value));
            this.lblDesc.Visible = true;
            this.lblTituloDesc.Visible = true;
        }

        private void nudCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Si no es un número ni una tecla de retroceso, se ignora la tecla
            }
        }

        private void txbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }


        //private void dgvProductos_DoubleClick(object sender, EventArgs e)
        //{
        //    RNProducto ObjRnProducto = new RNProducto();
        //    this.txbCodigo.Text = Convert.ToString(this.dgvProductos.CurrentRow.Cells[1].Value);
        //    this.txbNombre.Text = Convert.ToString(this.dgvProductos.CurrentRow.Cells[2].Value);                                     METODO DESACTIVADO
        //    this.txbPrecio.Text = Convert.ToString(this.dgvProductos.CurrentRow.Cells[3].Value);
        //    this.cbTipo.SelectedValue = 1;
        //    this.btnGuardar.Text = "Actualizar";
        //    this.txbDesc.Text = ObjRnProducto.TraerDesc(Convert.ToInt32(this.dgvProductos.CurrentRow.Cells[1].Value));
        //}

        //======================================== METODOS AUXILIARES ====================================================================

        private bool verificarCamposVacios()
        {
            bool vacio = false;
            foreach(TextBox textBox in new TextBox[] { txbNombre, txbPrecio, txbDesc })
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    vacio = true;
                    break;
                }
            }
            return vacio;
        }
    }
}
