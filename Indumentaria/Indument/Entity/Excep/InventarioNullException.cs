using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Excep
{
    public class InventarioNullException:Exception
    {
        public InventarioNullException() : base("No se encontro nada en el inventario")
        {

        }
    }
}
