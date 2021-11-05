using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entidades
{
    public abstract class Indumentaria
    {
        protected TipoIndumentaria _tipo;
        protected int _codigo;
        protected int _stock;
        protected string _talle;
        protected double _precio;

        public int Codigo { get => _codigo; }
        public string Talle { get => _talle; set { _talle = value; } }
        public Indumentaria(int codigo)
        {
            _codigo = codigo;
        }
        public Indumentaria(int codigo, string talle)
        {
            _codigo = codigo;
            _talle = talle;
        }
        public Indumentaria(TipoIndumentaria tipo,  int codigo, string talle, double precio)
        {
            _tipo = tipo;
            _codigo = codigo;
            _talle = talle;
            _precio = precio;
            _stock = 3;
        }


        public override string ToString()
        {
            return GetDetalle();
        }
        public abstract string GetDetalle();

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            else if (_codigo == ((Indumentaria)obj).Codigo)
                return true;
            else
                return false;
        }
    }
}
