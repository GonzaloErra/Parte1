using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facu.Biblioteca.Entidades
{
    public abstract class Persona : Object
    {
        protected String _apellido;
        protected DateTime _fechaNac;
        protected String _nombrePersona;

        //CONSTRUCTOR
        public Persona (string nombre, string apellido , DateTime fechadenacimiento)
        {
            _apellido = apellido;
            _nombrePersona = nombre;
            _fechaNac = fechadenacimiento;
        }

        //GETTERS Y SETTERS
        public string Apellido { get => _apellido; }

        public int Edad { get => Convert.ToInt32(DateTime.Now.Year -_fechaNac.Year); }

        public string Nombre { get => _nombrePersona; }

        //METODOS

        internal abstract string GetCredential();
       
        public virtual string GetNombreCompleto()
        {
            return $"{_nombrePersona} {_apellido}";
        }
    }
}
