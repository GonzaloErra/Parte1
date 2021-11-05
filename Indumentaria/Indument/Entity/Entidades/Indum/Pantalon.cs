using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entidades.Indum
{
    public class Pantalon:Indumentaria
    {
        private string _material;
        private bool _tieneBlsillos;
        public Pantalon(int Codigo) : base(Codigo)
        {
            _codigo = Codigo;
        }
        public Pantalon(int codigo, string talle) : base(codigo, talle)
        {
            _codigo = codigo;
            _talle = talle;
        }
        public Pantalon(TipoIndumentaria tipo, int codigo, string talle, double precio, bool bolsillo, string material): base(tipo,codigo,talle,precio)
        {
            _tipo = tipo;
            _codigo = codigo;
            _talle = talle;
            _precio = precio;
            _stock = 3;
            _material = material;
            _tieneBlsillos = bolsillo;
        }
        public override string GetDetalle()
        {
            return $"{_codigo} - {_tieneBlsillos}";
        }
    }
}
