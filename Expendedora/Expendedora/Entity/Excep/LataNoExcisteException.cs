using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Excep
{
    public class LataNoExcisteException:Exception
    {
        public LataNoExcisteException() : base("No se encontro la lata que seleccioino.")
        {

        }
    }
}
