using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Absraccion_Encapsulamiento.Clases.Entidades;

namespace Absraccion_Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {

            Jugador jugador = new Jugador();
            
            Jugador jugador2 = new Jugador();

            jugador.Apellido = "Renato Sanchez";

            jugador2.Apellido= "Di Santo";

            jugador.Goool();
            jugador.Goool();
            jugador.Goool();
            jugador.Goool();


            jugador2.Goool();
            jugador2.Goool();
            jugador2.Goool();
            jugador2.Goool();
            jugador2.Goool();
            jugador2.Goool();
            jugador2.Goool();
            jugador2.Goool();
            jugador2.Goool();
            jugador2.Goool();

            jugador.Goleador();
            jugador2.Goleador();
        }
    }
}
