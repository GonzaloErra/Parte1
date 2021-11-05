using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculos;

namespace Calculadora.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while(flag) 
            {
                Console.WriteLine("Ingrese el Simbolo del Calculo que quiera Realizar: " + "\n" + "Si quiere salir de la Calculadora ingrese 9 ");
                string Simbolo = Console.ReadLine();
                
                Console.WriteLine("Ingrese un numero : ");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el otro numero : ");
                int numero2 = Convert.ToInt32(Console.ReadLine());

                if (Simbolo == "+")
                {
                    int Total = Simbolos.Suma(numero1, numero2);
                    Console.WriteLine(Total);
                }
                else if (Simbolo == "-")
                {
                    int Total = Simbolos.Resta(numero1, numero2);
                    Console.WriteLine(Total);
                }
                else if (Simbolo == "/")
                {
                    int Total = Simbolos.Division(numero1, numero2);
                    Console.WriteLine(Total);
                }
                else if (Simbolo == "*")
                {
                    int Total = Simbolos.Multiplicacion(numero1, numero2);
                    Console.WriteLine(Total);
                }
                else if (Simbolo == "9")
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("No existe ese Simbolo.");
                }
            }
            Console.WriteLine("Precio enter para salir");
            Console.ReadLine();
        }
    }
}
