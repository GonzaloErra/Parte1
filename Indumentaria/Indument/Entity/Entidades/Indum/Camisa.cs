using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entidades.Indum
{
   public class Camisa : Indumentaria
    {
        private bool _tieneEstampado;
        private string _tipoManga;
        public Camisa(int Codigo):base(Codigo)
        {
            _codigo = Codigo;
        }
        public Camisa(int codigo, string talle) : base(codigo, talle)
        {
            _codigo = codigo;
            _talle = talle;
        }
        public Camisa (TipoIndumentaria tipo, int codigo, string talle, double precio, bool estampado, string manga) : base(tipo, codigo, talle, precio)
        {
            _tipo = tipo;
            _codigo = codigo;
            _talle = talle;
            _precio = precio;
            _stock = 3;
            _tieneEstampado = estampado;
            _tipoManga = manga;
        }
        public override string GetDetalle()
        {
            return $" {_codigo} -{_tieneEstampado}";
        }
    }
}
