using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Excep
{
    public class NoOrdenesException:Exception
    {
        public NoOrdenesException() : base("No se encontro ninguna orden")
        {

        }
    }
}
