using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facu.Biblioteca.Entidades
{
    public class Empleado : Persona
    {
        protected DateTime _fechaIngreso;
        protected int _legajo;
        protected List<Salario> _salario;
        protected Salario _ultimoSalario;

        //CONSTRUCTOR
      
        public Empleado(string nombre, string apellido, DateTime FNacimiento, DateTime FIngreso, int legajo,) : base(nombre, apellido, FNacimiento)
        {
            _legajo = legajo;
            _nombrePersona = nombre;
            _apellido = apellido;
            _fechaIngreso = FIngreso;
            _fechaNac = FNacimiento;
        }

        //GETTERS SETTERS
        public int Antiguedad { get => Convert.ToInt32(_fechaIngreso.Year - DateTime.Now.Year); }
        public DateTime FechaIngresa { get => _fechaIngreso; }
        public DateTime FechaNacimiento { get => _fechaNac; }
        public int Legajo { get => _legajo; }
        public List<Salario> Salario { get => _salario; }
        public Salario UltimoSalario { get => _ultimoSalario; }

        public void AgregarSalario(Salario sueldo)
        {
            _ultimoSalario = sueldo;
            _salario.Add(sueldo);
        }
        public override bool Equals(Object o) //DUDA
        {
            if (o == null)
                return false;
            if (this._legajo == ((Empleado)o).Legajo)
                return true;
            return false;
        }
        internal override string GetCredential()
        {
            return $"{this._legajo} - {this._nombrePersona} - Salario {_ultimoSalario} ";
        }
        public override string GetNombreCompleto()
        {
            return $"{_nombrePersona} ,{_apellido} ";
        }
        public override string ToString()
        {
            return GetCredential();
        }
    }
}
