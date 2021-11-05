using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Excep
{
    public class NoHayStock:Exception
    {
        public NoHayStock() : base("No hay stock de la lata que escogiste ")
        {

        }
    }
}
