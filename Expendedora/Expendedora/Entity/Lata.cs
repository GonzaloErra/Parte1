using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Lata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;
        private int _cantidad;
        public Lata ( string Codigo , string nombre, double precio, double volumen, int cantidad)
        {
            _codigo = Codigo;
            _nombre = nombre;
            _precio = precio;
            _volumen = volumen;
            _cantidad = cantidad;
        }
        public string Codigo { get => _codigo; }
        public string Nombre { get => _nombre; }
        public double  Precio { get => _precio; }
        public int Stock { get => _cantidad; set { _cantidad = value; } }
        public string Sabor { get => _sabor; }
        public int Cantidad { get => _cantidad; }
        public double GetPrecioPorLitro()
        {
            return (_precio / _volumen);
        }
        public override string ToString()
        {
            string msj = $"{_codigo} - {_nombre} - [{_cantidad}]";
            return msj;
        } 
            

    }
}
