using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Excep
{
    public class CodigoNoEncontradoException:Exception
    {
        public CodigoNoEncontradoException() : base("No se encontro el codigo")
        {

        }
    }
}
