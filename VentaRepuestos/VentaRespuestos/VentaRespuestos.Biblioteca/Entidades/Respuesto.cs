using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRespuestos.Biblioteca.Entidades
{
    public class Respuesto
    {
        private int _codigo;
        private String _nombre;
        private double _precio;
        private int _stock;
        private Categoria _categoria;
        //CONSTRUCTOR
        public Respuesto()
        {
        }

        public Respuesto(int codigo, string nombre, double precio, int stock, Categoria categoria)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
            _categoria = categoria;
        }
        //GETTERS && SETTER
        public int Codigo
        {
            get
            {
                return _codigo;
            }
        }
        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }
        public double Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }
        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
            }
        }
        public Categoria Categoria
        {
            get
            {
                return _categoria;
            }
        }
        
        public override string ToString()
        {
            return string.Format($"{this._codigo} - {this._nombre} - Cantidad: {this._stock} - Precio: ${this._precio}.-");
        }
        //public override bool Equals(Object o)
        //{
        //    if (o == null)
        //        return false;

        //    if (this._categoria == ((Respuesto)o).Categoria)
        //        return true;
        //    return false;
        //}

    }
}
