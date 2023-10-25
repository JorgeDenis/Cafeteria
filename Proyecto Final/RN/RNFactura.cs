using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Proyecto1.RN
{
    public class RNFactura : Contexto
    {
        CAFETERIA2023Entities Esquema;
        public RNFactura()
        {
            Esquema = this.TraerContexto();
        }

        public int GenerarId()
        {
            try
            {
                return (from e in Esquema.Factura select e.idFactura).Max() + 1;
            }
            catch (Exception e)
            {
                return 1;
            }
        }

        public bool Insertar(Factura ObjFatura)
        {
            try
            {
                Esquema.Factura.Add(ObjFatura);



                Producto objProductoAux = Esquema.Producto.FirstOrDefault(a => a.idProducto == ObjFatura.idProducto);

                objProductoAux.stock = objProductoAux.stock - ObjFatura.cantidad;

                






                Esquema.SaveChanges();
                return true;
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationError in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationError.ValidationErrors)
                    {
                        Console.WriteLine($"Propiedad: {validationError.PropertyName}");
                        Console.WriteLine($"Error: {validationError.ErrorMessage}");
                    }
                }
                return false;
            }
        }

        public Boolean Modificar(Factura ObjFatura)
        {
            Factura factura = Esquema.Factura.FirstOrDefault(a => a.idFactura == ObjFatura.idFactura);
            return Esquema.SaveChanges() > 0;
        }

        public Boolean Eliminar(Factura ObjFactura)
        {
            try
            {
                Factura ObjFacturaAux = Esquema.Factura.FirstOrDefault(a => a.idFactura == ObjFactura.idFactura);
                Esquema.Factura.Remove(ObjFacturaAux);
                return Esquema.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<VistaFactura> TraerFactura(int id)
        {
            if (id == 0)
            {
                return (from e in Esquema.VistaFactura select e).ToList();
            }
            else
            {
                return (from e in Esquema.VistaFactura where e.Nro_Factura.Equals(id) select e).ToList();
            }
        }

        public List<VistaFactura> TraerfaPorProducto(string busqueda)
        {
            busqueda = busqueda.ToUpper();

            return (from e in Esquema.VistaFactura
                    where e.Cliente.ToUpper().StartsWith(busqueda) ||
                          e.Vendedor.ToUpper().StartsWith(busqueda) ||
                          e.Producto.ToUpper().StartsWith(busqueda)
                    select e).ToList();
        }

        public List<VistaFactura> TraerVendedorPorUsuario(string Usuario)
        {
            return (from e in Esquema.VistaFactura where e.Cliente.ToUpper().StartsWith(Usuario.ToUpper()) select e).ToList();
        }

        
    }
}