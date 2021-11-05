using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRespuestos.Biblioteca.Except
{
    public class NoRespuestoException: Exception
    {
        public NoRespuestoException() : base("No se encontro el Respuesto")
        {

        }
    }
}
