﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facu.Biblioteca.Entidades
{
    public class Directivo : Empleado
    {
        public Directivo(int legajo, string nombre, string apellido, DateTime FNacimiento, DateTime FIngreso) : base(nombre, apellido, FNacimiento, FIngreso, legajo, salario)

        {
            _legajo = legajo;
            _nombrePersona = nombre;
            _apellido = apellido;
            _fechaIngreso = FIngreso;
            _fechaNac = FNacimiento;
        }
        public override string GetNombreCompleto()
        {
            return $"Sr. Directo - {_apellido}";
        }
    }
   
}
