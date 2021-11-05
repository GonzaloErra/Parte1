using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRespuestos.Biblioteca.Except
{
    public class TieneStockException : Exception
    {
        public TieneStockException() : base("Tiene stock no se puede eliminar el Respuesto")
        {

        }
    }
}
