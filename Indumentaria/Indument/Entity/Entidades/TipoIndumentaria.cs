using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entidades
{
    public abstract class TipoIndumentaria
    {
        protected string _origen;
        protected double _procentajeAlgodon;
        public TipoIndumentaria() { }
        public TipoIndumentaria(string origen, double porcentajeAlgodon)
        {
            _origen = origen;
            _procentajeAlgodon = porcentajeAlgodon;
        }

        public string origen { get => _origen; }
        public double porcentajealgodon { get => _procentajeAlgodon; }

    }
}
