using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absraccion_Encapsulamiento.Clases.Entidades
{
    class Estadio
    {
        private string _ubicacion;
        private Empleado _empleado;

        public Estadio()
        {
        }

        public Estadio(string ubicacion, Empleado empleado)
        {
            _ubicacion = ubicacion;
            _empleado = empleado;
        }

        public String Empleados
        {

            get
            {
                return _empleado.Nombre;
            }
        }
        public string Ubicacion
        {
            get
            {
                return _ubicacion;
            }
        }


    }
}
