using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facu.Biblioteca.Entidades
{
    public class Alumno : Persona
    {
        private int _Codigo;

        public Alumno() { }
        public Alumno(int codigo, string nombre, string apellido, DateTime fechadenacimiento  ) : base(nombre,apellido,fechadenacimiento)
        {
            _Codigo = codigo;
        }

        public int Codigo { get => _Codigo; }
        //public string Credential { get =>_credetial.random}

        public override string GetCredential()
        {
            return $" Codigo - {this._Codigo} - {this._nombrePersona} - {this._apellido} - ";

        }
        public override string ToString()
        {
            return GetCredential();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(_Codigo == ((Alumno)obj)._Codigo))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
