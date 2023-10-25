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
    public class RNProducto : Contexto
    {
        CAFETERIA2023Entities Esquema;
        public RNProducto()
        {
            Esquema = this.TraerContexto();
        }
        public int GenerarId()
        {
            try
            {
                return (from e in Esquema.Producto select e.idProducto).Max() + 1;
            }
            catch (Exception e)
            {
                return 1;
            }
        }

        public bool Insertar(Producto objProducto)
        {
            try
            {
                Esquema.Producto.Add(objProducto);
                Esquema.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        

        public bool Modificar(Producto objProducto)
        {
            Producto objProductoAux = Esquema.Producto.FirstOrDefault(a => a.idProducto == objProducto.idProducto);

            objProductoAux.idProducto = objProducto.idProducto;
            objProductoAux.nombre = objProducto.nombre;
            objProductoAux.precio = objProducto.precio;
            objProductoAux.idTipoProd = objProducto.idTipoProd;
            objProductoAux.descripcion = objProducto.descripcion;

            return Esquema.SaveChanges() > 0;
        }

        public bool Eliminar(Producto objProducto)
        {
            Producto objProductoAux = Esquema.Producto.FirstOrDefault(a => a.idProducto == objProducto.idProducto);

            objProductoAux.idProducto = objProducto.idProducto;
            objProductoAux.nombre = objProducto.nombre;
            objProductoAux.precio = objProducto.precio;
            objProductoAux.idTipoProd = objProducto.idTipoProd;
            objProductoAux.disponible = objProducto.disponible;
            objProductoAux.descripcion = objProducto.descripcion;
            return Esquema.SaveChanges() > 0;
        }

        public List<VistaProductos> TraerProductos(int id)
        {
            if (id == 0)
            {
                return (from e in Esquema.VistaProductos select e).ToList();
            }
            else
            {
                return (from e in Esquema.VistaProductos where e.ID == id select e).ToList();
            }
        }

        public List<VistaProductos> TraerProductosPorNombre(string nombre)
        {
            return (from e in Esquema.VistaProductos where e.Nombre.ToUpper().StartsWith(nombre.ToUpper()) select e).ToList();
        }

        public List<VistaProductos> TraerProductosPorTipo(string tipo)
        {
            return (from e in Esquema.VistaProductos where e.Tipo == tipo select e).ToList();
        }

        public List<Producto> TraerProducto(int id)
        {
            
            return (from e in Esquema.Producto where e.idProducto == id select e).ToList();
            
        }
        public int TraerIdTipoProductoNombre(string nombreTipo)
        {
            var idTipoProducto = (from e in Esquema.TipoProducto
                                  where e.tipo.ToUpper().StartsWith(nombreTipo.ToUpper())
                                  select e.idTipoProducto).FirstOrDefault();

            return idTipoProducto;
        }

        public string TraerDesc(int id)
        {
            var desc = (from e in Esquema.Producto
                                      where e.idProducto == id
                                      select e.descripcion).FirstOrDefault();
            return desc;
        }
        //public string TraerImg(int id)
        //{
        //    var img = (from e in Esquema.Producto
        //                where e.idProducto == id
        //                select e.imagen).FirstOrDefault();
        //    return img;
        //}

    }
}
