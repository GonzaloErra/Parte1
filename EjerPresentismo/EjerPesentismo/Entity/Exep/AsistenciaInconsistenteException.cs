using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Exep
{
    public class AsistenciaInconsistenteException:Exception
    {
        public AsistenciaInconsistenteException() : base("no tiene la misma cantidad la lista alumnos con la de asistencia")
        {

        }
    }
}
