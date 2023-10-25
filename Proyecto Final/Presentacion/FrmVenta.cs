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


namespace Presentacion
{
    public partial class FrmVenta : Form
    {
        private string usuario;

        public FrmVenta(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        public FrmVenta()
        {
            InitializeComponent();
        }

        private void CargarComboClientes()
        {
            RNCliente ObjRNCliente = new RNCliente();
            this.cbCliente.DataSource = ObjRNCliente.TraerClientesParaComboBox();
            this.cbCliente.DisplayMember = "nombre";
            this.cbCliente.ValueMember = "idCliente";
        }

        private void CargarComboProducto()
        {
            RNProducto ObjRNProducto = new RNProducto();
            this.cbProducto.DataSource = ObjRNProducto.TraerProductos(0);
            this.cbProducto.DisplayMember = "nombre";
            this.cbProducto.ValueMember = "ID";
        }



        private void FrmVenta_Load(object sender, EventArgs e)
        {
            
            CargarComboProducto();
            CargarComboClientes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RNFactura ObjRNFactura = new RNFactura();
            RNProducto ObjRNProducto = new RNProducto();
            Factura ObjFactura = new Factura();
            RNVendedor ObjRNVendedor = new RNVendedor();            
            Vendedor ObjVendedor = ObjRNVendedor.TraerVendedorPorUsuarioParaLabel(usuario).FirstOrDefault();
            Producto ObjProducto = ObjRNProducto.TraerProducto(int.Parse(this.cbProducto.SelectedValue.ToString())).FirstOrDefault();

            


            ObjFactura.idFactura = ObjRNFactura.GenerarId();
            ObjFactura.idCliente = int.Parse(this.cbCliente.SelectedValue.ToString());
            ObjFactura.idVendedor = ObjVendedor.idVendedor;
            ObjFactura.idProducto = int.Parse(this.cbProducto.SelectedValue.ToString());
            ObjFactura.total = ObjProducto.precio * this.nudCantidad.Value;
            ObjFactura.fecha = DateTime.Now;
            ObjFactura.cantidad = (int?)this.nudCantidad.Value;




            
            if (ObjRNFactura.Insertar(ObjFactura))
            {
                MessageBox.Show("Producto agregado al carrito!");
                this.txbCodigo.Text = ObjFactura.idFactura.ToString();
                this.dgvFactura.DataSource = ObjRNFactura.TraerFactura(ObjProducto.idProducto);
                Utilitarios.Utilitarios.id = ObjProducto.idProducto;
                this.dgvFactura.DataSource = ObjRNFactura.TraerFactura(Convert.ToInt32(this.txbCodigo.Text));
                    
            

                    

            }
            else
            {
                MessageBox.Show("Error al agregar el producto");
            }
            


            
            
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            RNFactura ObjRNFactura = new RNFactura();
            if(this.txbBuscar.Text == "Todos")
            {
                this.dgvFactura.DataSource = ObjRNFactura.TraerFactura(0);
            }
            else
            {
                int id;
                if(int.TryParse(this.txbBuscar.Text, out id))
                {
                    this.dgvFactura.DataSource = ObjRNFactura.TraerFactura(id);
                }
                else
                {
                    this.dgvFactura.DataSource = ObjRNFactura.TraerfaPorProducto(this.txbBuscar.Text);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.txbCodigo.Text = "0";
            RNFactura ObjRNFactura = new RNFactura();
            if (this.txbBuscar.Text == "Todos")
            {
                this.dgvFactura.DataSource = ObjRNFactura.TraerFactura(0);
            }
            else
            {
                int id;
                if (int.TryParse(this.txbBuscar.Text, out id))
                {
                    this.dgvFactura.DataSource = ObjRNFactura.TraerFactura(id);
                }
                else
                {
                    this.dgvFactura.DataSource = ObjRNFactura.TraerfaPorProducto(this.txbBuscar.Text);
                }
            }
            
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Rubro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Rubro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            RNFactura ObjRNFactura = new RNFactura();
            Factura ObjFactura = new Factura();
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Esta seguro de eliminar estos registro?", "Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    Boolean Rpta = false;
                    foreach (DataGridViewRow row in dgvFactura.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            ObjFactura.idFactura = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = ObjRNFactura.Eliminar(ObjFactura);
                            if (Rpta)
                            {
                                this.MensajeOk("Se elimino correctamente");
                                this.cbEliminar.Checked = false;
                            }
                            else
                            {
                                this.MensajeError("No se pudo eliminar porque el rubro esta asignado a uno o varios clientes");
                                this.cbEliminar.Checked = false;
                            }

                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEliminar.Checked)
            {
                this.dgvFactura.Columns[0].Visible = true;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.dgvFactura.Columns[0].Visible = false;
                this.btnEliminar.Enabled = false;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            RNFactura ObjRNFactura = new RNFactura();
            if(this.txbCodigo.Text == "0" || this.txbBuscar.Text == "Todos")
            {
                Utilitarios.Utilitarios.id = 0;
                Utilitarios.Utilitarios.NroReporte = 5;
                FrmReportes objFrmReporte = new FrmReportes();
                objFrmReporte.Show();
            }
            this.dgvFactura.DataSource = ObjRNFactura.TraerFactura(0);
        }
    }
}
