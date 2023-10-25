using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Contexto
    {
        public CAFETERIA2023Entities TraerContexto()
        {
            CAFETERIA2023Entities cont = new CAFETERIA2023Entities();
            return cont;
        }
    }
}
