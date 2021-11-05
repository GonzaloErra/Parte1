using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entidades
{
    public class Preceptor : Persona
    {
        private int _legajo;  
        public Preceptor (int a , string nombre, string apellido ) :base(nombre,apellido)
            {
            a = _legajo;
            nombre = _nombre;
            apellido = _apellido;
            }
        // GETTERS// SETTERS
        public int Legajo { get => _legajo; }
        public override string Display()
        {
            return $"{ _apellido} - {_legajo}";
        }

    }
}
