using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entidades
{
    public class VentaItem
    {
        private Indumentaria _prenda;
        private int _cantidad;

        public Double GetTotal()
        {
            return _cantidad;
        }
    }
}
