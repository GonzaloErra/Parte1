using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facul.Biblioteca
{
    public class AlumnoNoEncontradoException : Exception
    {
        public AlumnoNoEncontradoException() : base("No se encontro el alumno. ")
        {

        }
    }
}
