using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facul.Biblioteca
{
    public class EmpleadoNoEncontradoException : Exception
    {
        public EmpleadoNoEncontradoException() : base("No se a encontrado el empleado")
        {

        }
    }
}
