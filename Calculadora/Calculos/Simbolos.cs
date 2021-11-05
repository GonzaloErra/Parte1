using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    public static class Simbolos
    {
        public static int Suma(int numero1, int numero2)
        {
             int Total = numero1 + numero2;
            return Total;
        }
        public static int Resta(int numero1, int numero2)
        {
            int Total = numero1 - numero2;
            return Total;
        }
        public static int Division (int numero1, int numero2)
        {
            int Total = numero1 / numero2;
            return Total;
        }
        public static int Multiplicacion(int numero1, int numero2)
        {
            int Total = numero1 * numero2;
            return Total;
        }
    }
}
