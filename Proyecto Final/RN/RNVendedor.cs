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
    public class RNVendedor : Contexto
    {
        CAFETERIA2023Entities Esquema;
        public RNVendedor()
        {
            Esquema = this.TraerContexto();
        }

        public int GenerarId()
        {
            try
            {
                return (from e in Esquema.Vendedor select e.idVendedor).Max() + 1;
            }
            catch (Exception e)
            {
                return 1;
            }
        }

        public bool Insertar(Vendedor ObjVendedor, TelefonoVen ObjTelefonoVen)
        {
            try
            {
                Esquema.Vendedor.Add(ObjVendedor);
                Esquema.TelefonoVen.Add(ObjTelefonoVen);
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
        
        public Boolean Modificar(Vendedor ObjVendedor, TelefonoVen ObjTelefonoVen)
        {
            Vendedor ObjVendedorAux = Esquema.Vendedor.FirstOrDefault(a => a.idVendedor == ObjVendedor.idVendedor);
            ObjVendedorAux.idVendedor = ObjVendedor.idVendedor;
            ObjVendedorAux.nombre = ObjVendedor.nombre;
            ObjVendedorAux.apellidoPaterno = ObjVendedor.apellidoPaterno;
            ObjVendedorAux.apellidoMaterno = ObjVendedor.apellidoMaterno;
            ObjVendedorAux.usuario = ObjVendedor.usuario;
            ObjVendedorAux.clave = ObjVendedor.clave;

            TelefonoVen ObjTelefonoVenAux = Esquema.TelefonoVen.FirstOrDefault(a => a.idTelfVen == ObjVendedor.idVendedor);
            ObjTelefonoVenAux.idTelfVen = ObjVendedor.idVendedor;
            ObjTelefonoVenAux.idVendedor = ObjVendedor.idVendedor;
            ObjTelefonoVenAux.numero = ObjTelefonoVen.numero;

            ObjVendedorAux.rol = ObjVendedor.rol;
            ObjVendedorAux.calle = ObjVendedor.calle;
            ObjVendedorAux.numero = ObjVendedor.numero;
            ObjVendedorAux.municipio = ObjVendedor.municipio;

            return Esquema.SaveChanges() > 0;
        }

        public Boolean Eliminar(Vendedor ObjVendedor, TelefonoVen ObjTelefonoVen)
        {
            try
            {
                Vendedor ObjVendedorAux = Esquema.Vendedor.FirstOrDefault(a => a.idVendedor == ObjVendedor.idVendedor);
                TelefonoVen ObjTelefonoVenAux = Esquema.TelefonoVen.FirstOrDefault(a => a.idTelfVen == ObjTelefonoVen.idTelfVen);

                //vericar si el rubro no esta asociado a un cliente
                if (ObjVendedorAux.Factura.Count == 0)
                {
                    Esquema.TelefonoVen.Remove(ObjTelefonoVenAux);
                    Esquema.Vendedor.Remove(ObjVendedorAux);
                    return Esquema.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<Vendedor> VendedorLista()
        {
            return (from e in Esquema.Vendedor select e).ToList();
        }
        public List<VistaVendedores> TraerVendedor(int id)
        {
            if (id == 0)
            {
                return (from e in Esquema.VistaVendedores select e).ToList();
            }
            else
            {
                return (from e in Esquema.VistaVendedores where e.ID.Equals(id) select e).ToList();
            }
        }

        public List<VistaVendedores> TraerVendedorPorNombre(string Nombre)
        {
            return (from e in Esquema.VistaVendedores where e.Nombre.ToUpper().StartsWith(Nombre.ToUpper()) select e).ToList();
        }

        public List<VistaVendedores> TraerVendedorPorUsuario(string Usuario)
        {
            return (from e in Esquema.VistaVendedores where e.Usuario.ToUpper().StartsWith(Usuario.ToUpper()) select e).ToList();
        }

        public List<Vendedor> TraerVendedorPorUsuarioParaLabel(string Usuario)
        {
            return (from e in Esquema.Vendedor where e.usuario.Equals(Usuario) select e).ToList();
        }

    }
}