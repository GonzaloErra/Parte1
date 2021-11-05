using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entidades
{
    public class AlumnoOyente:Alumno
    { 
    public AlumnoOyente(int Registro, string Nombre, string Apellido) : base(Registro, Nombre, Apellido)
    {
        _nombre = Nombre;
        _apellido = Apellido;
    }
        
    }
}
