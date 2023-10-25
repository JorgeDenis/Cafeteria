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
    public class RNTipoProducto : Contexto
    {
        CAFETERIA2023Entities Esquema;
        public RNTipoProducto()
        {
            Esquema = this.TraerContexto();
        }
        public Int64 GenerarId()
        {
            try
            {
                return (from e in Esquema.TipoProducto select e.idTipoProducto).Max() + 1;
            }
            catch (Exception e)
            {
                return 1;
            }

        }
        public bool Insertar(TipoProducto ObjTipoProducto)
        {
            try
            {
                Esquema.TipoProducto.Add(ObjTipoProducto);
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
        public Boolean Modificar(TipoProducto ObjTipoProducto)
        {
            TipoProducto ObjTipoProductoAux = Esquema.TipoProducto.FirstOrDefault(a => a.idTipoProducto == ObjTipoProducto.idTipoProducto);
            ObjTipoProductoAux.idTipoProducto = ObjTipoProducto.idTipoProducto;
            ObjTipoProductoAux.tipo = ObjTipoProducto.tipo;
            return Esquema.SaveChanges() > 0;

        }
        public Boolean Eliminar(TipoProducto ObjTipoProducto)
        {
            try
            {
                TipoProducto ObjTipoProductoAux = Esquema.TipoProducto.FirstOrDefault(a => a.idTipoProducto == ObjTipoProducto.idTipoProducto);
                //vericar si el tipo de producto no esta asociado a ningun producto
                if (ObjTipoProductoAux.Producto.Count == 0)
                {
                    Esquema.TipoProducto.Remove(ObjTipoProductoAux);
                    return Esquema.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }


        }
        public List<TipoProducto> TraerTipoProducto(int id) //Busca los rubros por codigo
        {
            if (id == 0)
            {
                return (from e in Esquema.TipoProducto select e).ToList();
            }
            else
            {
                return (from e in Esquema.TipoProducto where e.idTipoProducto.Equals(id) select e).ToList();
            }
        }

        public List<TipoProducto> TraerTipoProductoPorTipo(string tipo) //Busca los rubros por nombre
        {
            return (from e in Esquema.TipoProducto where e.tipo.ToUpper().StartsWith(tipo.ToUpper()) select e).ToList();

        }
    }
}
