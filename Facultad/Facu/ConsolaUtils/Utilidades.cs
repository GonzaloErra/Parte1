using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaUtils
{
    public class Utilidades
    {
        public static bool EsOpcionValida(string op1, Array op2)
        {
            foreach(string value in op2)
            {
                if (value == op1)
                {
                    return true;
                }
            }
            return false;
        }
        public static string ValidarCadena(string mensaje)
        {
            string cadena;
            do
            {
                Console.WriteLine(mensaje);
                cadena = Console.ReadLine();

                if (string.IsNullOrEmpty(cadena))
                {
                    Console.WriteLine("No puede dejar el campo vacio");
                }


            } while (string.IsNullOrEmpty(cadena));
            return cadena;
        }
        public static float ValidarNumericoFlo(string mensaje)
        {
            string dato;
            bool flag = false;
            do
            {
                Console.WriteLine(mensaje);
                dato = Console.ReadLine();
                if (string.IsNullOrEmpty(dato))
                {
                    Console.WriteLine("Debe ingresar un valor");
                }
                else if (Convert.ToSingle(dato) < 0)
                {
                    Console.WriteLine("Debe ingresar un valor positivo");
                }
                else
                {
                    flag = true;
                }
            } while (flag == false);

            return Convert.ToSingle(dato);
        }
        public static int ValidarNumericoInt(string mensaje)
        {
            string dato;
            bool flag = false;
            do
            {
                Console.WriteLine(mensaje);
                dato = Console.ReadLine();
                if (string.IsNullOrEmpty(dato))
                {
                    Console.WriteLine("Debe ingresar un valor");
                }
                else if (Convert.ToSingle(dato) < 0)
                {
                    Console.WriteLine("Debe ingresar un valor positivo");
                }
                else
                {
                    flag = true;
                }
            } while (flag == false);

            return Convert.ToInt32(dato);
        }
        public static DateTime ValidarFecha(string mensaje)
        {
            //DateTime fecha;
            //do
            //{
            //    Console.WriteLine(mensaje);
            //    if (!DateTime.TryParse(Console.ReadLine(), out fecha))
            //    {
            //        Console.WriteLine("Dato invalido");
            //    }
            //} while (!DateTime.TryParse(Console.ReadLine(), out fecha));

            //return fecha;

            DateTime fecha = new DateTime();
            string entrada;
            bool flag = false;

            while (!flag)
            {
                Console.WriteLine(mensaje);
                entrada = Console.ReadLine();
                flag = DateTime.TryParse(entrada, out fecha);
                if (!flag)
                {
                    Console.WriteLine("Formato no valido");

                }
                if (fecha > DateTime.Now)
                {
                    Console.WriteLine("Debe ingresar una fecha menor al dia de hoy");
                }
                else
                {
                    flag = true;
                }
            }
            return fecha;
        }

        public static bool ValidarBoolean(string mensaje, string tipo)
        {
            string cadena;
            bool flag = false;
            do
            {
                Console.WriteLine(mensaje + " presione (y) o (n)");
                cadena = Console.ReadLine();

                if (string.IsNullOrEmpty(cadena))
                {
                    Console.WriteLine("El campo " + tipo + " no puede estar vacío");
                }
                else if (cadena != "y" && cadena != "Y" && cadena != "n" && cadena != "N")
                {
                    Console.WriteLine("Opción incorrecta");

                }
                else if (cadena == "Y" || cadena == "y")
                {
                    flag = true;
                }

            } while (cadena != "y" && cadena != "Y" && cadena != "n" && cadena != "N");

            return flag;

        }
        //public static int ValidarLegajo(string mensaje)
        //{
        //    do
        //    {
        //        Console.WriteLine(mensaje);
        //        int legajo = Convert.ToInt32(Console.ReadLine());
        //        foreach 
        //        if (legajo !=  )
        //        {
        //            Console.WriteLine("Dato invalido");
        //        }



        //    return fecha;
        //}
        public static int ValidarOpcion(int cantidadOpciones)
        {
            int opcion;
            bool valido = false;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Debe ingresar el número de la opcion. ");
                }
                else if (opcion <= 0 || opcion > cantidadOpciones)
                {
                    Console.WriteLine("Ingrese un número válido de opcion.");
                }
                else
                {
                    valido = true;
                }
            } while (valido == false);
            return opcion;
        }
    }
}

