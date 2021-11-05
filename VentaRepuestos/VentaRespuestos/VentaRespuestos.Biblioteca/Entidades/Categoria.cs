using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRespuestos.Biblioteca.Entidades
{
   public class Categoria
    {
        private int _codigo;
        private string _nombre;
        public string NombreCategoria
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Codigo { get => _codigo; }

    }
}
   
