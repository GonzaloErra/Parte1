using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Exep
{
    public class AsistenciaExistenteEseDiaException:Exception

    {
        public AsistenciaExistenteEseDiaException() : base("Ya se registro un asistencia para ese Dia. ")
        {

        }
    }
}
