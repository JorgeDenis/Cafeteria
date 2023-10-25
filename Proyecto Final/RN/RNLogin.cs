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
    public class RNLogin : Contexto
    {
        CAFETERIA2023Entities Esquema;
        public RNLogin()
        {
            Esquema = this.TraerContexto();
        }

    }
}
