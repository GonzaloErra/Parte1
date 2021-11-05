using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entidades
{
    public class Venta
    {
        private List<VentaItem> _items;
        private Cliente _cliente;
        private int _estado;
        private int _codigo;
    }
}
