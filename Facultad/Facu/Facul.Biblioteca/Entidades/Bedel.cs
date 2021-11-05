using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facu.Biblioteca.Entidades
{
    public class Bedel : Empleado
    {
        private string _apodo;

        public string Apodo { get => _apodo; }
        public Bedel(string apodo,int legajo, string nombre, string apellido, DateTime FNacimiento, DateTime FIngreso) : base (nombre, apellido, FNacimiento, FIngreso, legajo, salario)
        {
            _legajo = legajo;
            _nombrePersona = nombre;
            _apellido = apellido;
            _apodo = apodo;
            _fechaIngreso = FIngreso;
            _fechaNac = FNacimiento;
        }
        public override string GetNombreCompleto()
        {
            return $"Apodo = {_apodo}";
        }
    }
}
