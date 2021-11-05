using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absraccion_Encapsulamiento.Clases.Entidades
{
    public class Empleado
    {
        private String _nombre;
        private int _sueldo;
        private String _descripcionTrabajo;

        public Empleado()
        {
        }

        public Empleado(string nombre, int sueldo, string descripcionTrabajo)
        {
            _nombre = nombre;
            _sueldo = sueldo;
            _descripcionTrabajo = descripcionTrabajo;
        }

        public String Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public int Precio
        {
            get
            {
                return _sueldo;
            }
            set
            {
                _sueldo = value;
            }
        }
        public String Producto
        {
            get
            {
                return _descripcionTrabajo;
            }
            set
            {
                _descripcionTrabajo = value;
            }
        }
    }
}
