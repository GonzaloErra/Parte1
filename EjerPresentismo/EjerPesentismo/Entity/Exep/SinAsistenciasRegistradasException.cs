using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Exep
{
    public class SinAsistenciasRegistradasException:Exception
    {
        public SinAsistenciasRegistradasException() : base ("No se encontro una lista en esa fecha") 
        {
        }
    }
}
