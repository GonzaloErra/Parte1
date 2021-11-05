using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entidades.TipoIndume
{
    public class IndumentariaDeportiva :TipoIndumentaria 
    {
        public IndumentariaDeportiva(string origen, double porcentajeAlgodon) : base(origen, porcentajeAlgodon)
        {
            _origen = origen;
            _procentajeAlgodon = porcentajeAlgodon;
        }
    }
}
