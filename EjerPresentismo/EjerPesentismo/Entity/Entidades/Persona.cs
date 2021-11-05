using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entidades;

namespace Entity
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;
        
        public Persona(string nombre, string apellido)
        {
            nombre = _nombre;
            apellido = _apellido;
        }
        //Getters / Setters
        public string Nombre { get => _nombre; }

        public string Apellido { get => _apellido; }
        public override string ToString()
        {
            return Display();
            //if (this is Preceptor)
            //    return ($"{_apellido} - {(((Preceptor)this).Legajo)}");

            //else if (this is Alumno)
            //    return ($"{_nombre} - {(((Alumno)this).Registro)}");

            //else return "Error inseperado";  
        }
        public abstract string Display();
      

    }
}
