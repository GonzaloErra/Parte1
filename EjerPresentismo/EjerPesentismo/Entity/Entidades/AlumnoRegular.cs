using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entidades
{
    public class AlumnoRegular:Alumno
    {
        private string _email;

        public string Email { get => _email; }

        public AlumnoRegular(int Registro, string Nombre, string Apellido, string Email) : base(Registro, Nombre, Apellido)
        {
            _nombre = Nombre;
            _apellido = Apellido;
            _email = Email;
        }

    }
}

