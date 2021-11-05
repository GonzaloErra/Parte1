using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entidades
{
    public abstract class Alumno : Persona 
    {
        protected int _registro ;

        public  int Registro { get => _registro; }

        public Alumno(int registro, string nombre, string apellido) : base(nombre, apellido)
        {
            _registro = registro;
            _nombre = nombre;
            _apellido = apellido;
        }
        public override string Display()
        {
            return $"Preceptor {_nombre} - codigo {_registro}";
        }
    }
}
