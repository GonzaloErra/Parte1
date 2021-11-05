using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absraccion_Encapsulamiento.Clases.Entidades
{
    public class Jugador
    {
        private String _nombre;
        private string _apellido;
        private DateTime _edad;
        private string _posiscion;
        private int _goles;
        private int _salario;

        public Jugador()
        {
        }

        public Jugador(string nombre, string apellido, DateTime edad, string posiscion, int goles, int salario)
        {
            _nombre = nombre;
            _apellido = apellido;
            _edad = edad;
            _posiscion = posiscion;
            _goles = goles;
            _salario = salario;
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
        public String Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _nombre = value;
            }
        }

        public DateTime Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = value;
            }
        }
        public string Posiscion
        {
            get
            {
                return _posiscion;
            }
            set
            {
                _posiscion = value;
            }
        }
        public int Goles
        {
            get
            {
                return _goles;
            }
            set
            {
                _goles = value;
            }
        }

        public int Salario
        {
            get
            {
                return _salario;
            }
            set
            {
                _salario = value;
            }
        }

        public void Goool()
        {
            _goles += 1;
        }
        public void Goleador()
        {
            if (_goles > 5)
                Console.WriteLine("Tiene " + _goles + " Goles Y es el Goleador del equipo");
            else
                Console.WriteLine("Solo tiene " + _goles + " Goles");
        }
    }
}
