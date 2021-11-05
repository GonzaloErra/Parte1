using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absraccion_Encapsulamiento.Clases.Entidades
{
    public class Club
    {
        private String _nombre;
        private String _ubicacion;
        private int _precio;
        private List<Jugador> _jugadores;
        private Dirigente _dirigentes;

        public Club()
        {

        }

        public Club(string nombre, string ubicacion, int precio, List<Jugador> jugadores, Dirigente dirigentes)
        {
            _nombre = nombre;
            _ubicacion = ubicacion;
            _precio = precio;
            _jugadores = jugadores;
            _dirigentes = dirigentes;
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
        public String Ubicacion
        {
            get
            {
                return _ubicacion;
            }
            set
            {
                _ubicacion = value;
            }
        }
        public int Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }
        public void AgregarJugadores(Jugador a)
        {
            _jugadores.Add(a);
        }
        public void EliminarJugador(Jugador a)
        {
            _jugadores.Remove(a);
        }
    }


}
