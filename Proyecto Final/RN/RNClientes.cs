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
    public class RNCliente : Contexto
    {
        CAFETERIA2023Entities Esquema;
        public RNCliente()
        {
            Esquema = this.TraerContexto();
        }

        public int GenerarId()
        {
            try
            {
                return (from e in Esquema.Clientes select e.idCliente).Max() + 1;
            }
            catch (Exception e)
            {
                return 1;
            }
        }

        public bool Insertar(Clientes ObjCliente, TelefonoCli ObjTelefonoCli, DireccionCli ObjDireccionCli)
        {
            try
            {
                Esquema.Clientes.Add(ObjCliente);
                Esquema.TelefonoCli.Add(ObjTelefonoCli);
                Esquema.DireccionCli.Add(ObjDireccionCli);
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

        public bool Modificar(Clientes ObjCliente, TelefonoCli ObjTelefonoCli, DireccionCli ObjDireccionCli)
        {
            Clientes ObjClienteAux = Esquema.Clientes.FirstOrDefault(a => a.idCliente == ObjCliente.idCliente);
            TelefonoCli ObjTelefonoCliAux = Esquema.TelefonoCli.FirstOrDefault(a => a.idTelfCli == ObjTelefonoCli.idTelfCli);
            DireccionCli ObjDireccionCliAux = Esquema.DireccionCli.FirstOrDefault(a => a.idDirCli == ObjDireccionCli.idDirCli);

            ObjClienteAux.idCliente = ObjCliente.idCliente;
            ObjClienteAux.nombre = ObjCliente.nombre;
            ObjClienteAux.apellidoPaterno = ObjCliente.apellidoPaterno;
            ObjClienteAux.apellidoMaterno = ObjCliente.apellidoMaterno;
            ObjClienteAux.genero = ObjCliente.genero;

            ObjTelefonoCliAux.idTelfCli = ObjTelefonoCli.idTelfCli;
            ObjTelefonoCliAux.idCliente = ObjTelefonoCli.idCliente;
            ObjTelefonoCliAux.numero = ObjTelefonoCli.numero;

            ObjDireccionCliAux.idDirCli = ObjDireccionCli.idDirCli;
            ObjDireccionCliAux.idCliente = ObjDireccionCli.idCliente;
            ObjDireccionCliAux.municipio = ObjDireccionCli.municipio;
            ObjDireccionCliAux.calles = ObjDireccionCli.calles;
            ObjDireccionCliAux.numero = ObjDireccionCli.numero;

            return Esquema.SaveChanges() > 0;
        }

        public bool Eliminar(Clientes ObjCliente, TelefonoCli ObjTelefonoCli, DireccionCli ObjDireccionCli)
        {
            try
            {
                Clientes ObjClienteAux = Esquema.Clientes.FirstOrDefault(a => a.idCliente == ObjCliente.idCliente);
                TelefonoCli ObjTelefonoCliAux = Esquema.TelefonoCli.FirstOrDefault(a => a.idTelfCli == ObjTelefonoCli.idTelfCli);
                DireccionCli ObjDireccionCliAux = Esquema.DireccionCli.FirstOrDefault(a => a.idDirCli == ObjDireccionCli.idDirCli);

                //vericar si el rubro no esta asociado a un cliente
                if (ObjClienteAux.Factura.Count == 0)
                {
                    Esquema.DireccionCli.Remove(ObjDireccionCliAux);
                    Esquema.TelefonoCli.Remove(ObjTelefonoCliAux);
                    Esquema.Clientes.Remove(ObjClienteAux);
                    return Esquema.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<VistaCliente> TraerClientes(int id)
        {
            if (id == 0)
            {
                return (from e in Esquema.VistaCliente select e).ToList();
            }
            else
            {
                return (from e in Esquema.VistaCliente where e.ID == id select e).ToList();
            }
        }

        public List<VistaCliente> TraerClientesPorNombre(string busqueda)
        {
            busqueda = busqueda.ToUpper();

            return (from e in Esquema.VistaCliente
                    where e.Nombre.ToUpper().StartsWith(busqueda) ||
                          e.Apellido_Paterno.ToUpper().StartsWith(busqueda) ||
                          e.Apellido_Materno.ToUpper().StartsWith(busqueda)
                    select e).ToList();
        }

        public List<VistaCliente> TraerClientesPorApellidoPaterno(string nombre)
        {
            return (from e in Esquema.VistaCliente where e.Apellido_Paterno.ToUpper().StartsWith(nombre.ToUpper()) select e).ToList();
        }

        public List<VistaCliente> TraerClientesPorApellidoMaterno(string nombre)
        {
            return (from e in Esquema.VistaCliente where e.Apellido_Materno.ToUpper().StartsWith(nombre.ToUpper()) select e).ToList();
        }



        public List<Clientes> TraerClientesParaComboBox()
        {
            return (from e in Esquema.Clientes select e).ToList();
        }

        public List<VistaTopClientes> TopClientes()
        {
            return (from e in Esquema.VistaTopClientes select e).ToList();
        }


    }
}
