using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaRepaso
{
    class Ejercicios
    {
        public void Ejer1()
        {
            // crear una aplicación que cuente desde el número 1 hasta los últimos tres dígitos del
            //propio número de registro(en caso de ser comenzar con 0, sumarle 100), todos los
            //números deben mostrarse por pantalla y, con los múltiplos de 3 se debera agregar
            //“foo”, con los múltiplos de 5, “bar”, y, por último, con los múltiplos de ambos, “foobar”. 
            //por ejemplo, con el número mostrará “15 – foobar”.
            
            List<string> bar = new List<string>();
            List<string> foo = new List<string>();
            List<string> foobar = new List<string>();
            //string[] bar ; 
            int numero;
            Console.WriteLine("HOLA");
            for (numero = 0; numero < 100; numero++)
            {
                if (numero % 5 == 0 && numero % 3 == 0)
                {
                    Console.WriteLine("El numero es : " + numero + "foobar");
                }
                else if (numero % 3 == 0)
                {
                    Console.WriteLine("El numero es : " + numero + "foo");
                }
                else if (numero % 5 == 0)
                {
                    Console.WriteLine("El numero es : " + numero + "bar");
                }
                else
                {
                    Console.WriteLine("El numero es : " + numero);
                }
                

            }
       
        }
    
        public void Ejer2()
        {
            //Crear una aplicación que cuente desde el número 1 hasta los últimos tres dígitos del
            //propio número de registro(en caso de ser comenzar con 0, sumarle 100) e identificar
            //los múltiplos de 3 y, también, aquellos que sean números primos.
            //Para ambos casos (múltiplo de 3 y primos), deben mostrar el número en cuestión y " Es divisible por 3", 
            //"Es primo" y, en caso de ser ambos “Es primo y divisible por 3”. 
            //Por ejemplo, con el primer número mostrará “1 – Es primo”. 

            string nroRegistro;
            Console.WriteLine("Ingrese numero de registro");
            nroRegistro = Console.ReadLine();

            Console.WriteLine("1 - Es primo");
            int Limit = Int32.Parse(nroRegistro.Substring(3, 3));
            for (int i = 2; i <= Limit; i++)
            {
                bool IsPrime = true;
                bool Divisible3 = false;
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        if (i % 3 == 0)
                        {
                            Divisible3 = true;
                            IsPrime = false;
                            break;
                        }
                        else
                        {
                            Divisible3 = false;
                            IsPrime = false;
                            break;
                        }
                    }
                    else
                    {
                        if (i % 3 == 0)
                        {
                            Divisible3 = true;
                            IsPrime = true;
                        }
                        else
                        {
                            Divisible3 = false;
                            IsPrime = true;
                        }
                    }
                }
                if (IsPrime)
                {
                    if (Divisible3)
                    {
                        Console.WriteLine(i + " - Es Primo y divisible por 3");
                    }
                    else
                    {
                        Console.WriteLine(i + " - Es Primo");
                    }
                }
                else
                {
                    if (Divisible3)
                    {
                        Console.WriteLine(i + " - Es divisible por 3 ");
                    }
                    else
                    {
                        Console.WriteLine(i + " - No es primo");
                    }

                }

            }

        }
        public void Ejer3()
        {
            //Crear una aplicación que indique, cuando el usuario ingresa una palabra, si ésta es un
            //palíndromo.
            //Nota: Palíndromo son palabras que al derecho y al revés se leen igual, como "ananá".'
            string name, c;
            string eman = "";
            int i  ;
            Console.Write("Ingrese una palabra: ");
            name =Convert.ToString(Console.ReadLine());
            i = name.Length;

            for (int x = i - 1; x >= 0; x--)
            {
                c = name.Substring(x, 1);
                eman += c;
            }
            if (name == eman)
            {
                Console.WriteLine("Es Palíndromo");
            }
            else
            {
                Console.WriteLine("No es Palíndromo");
            }

        }

        public void Ejer4()

        {
            //Crear una aplicación que indique, cuando el usuario ingresa dos palabras, si éstas son
            //un anagrama. 
            //Nota: Anagrama son palabras que reordenando sus letras forman una nueva, como
            //"roma" y "amor".
            Console.WriteLine("Ingrese palabra nro 1");
            string palabra1 = Console.ReadLine();

            Console.WriteLine("Ingrese palabra nro 2");
            string palabra2 = Console.ReadLine();

            if (palabra1.Length != palabra2.Length)
            {
                Console.WriteLine("No es un anagrama");
            }
            else
            {
                char[] Caracteres1 = palabra1.ToCharArray();
                char[] Caracteres2 = palabra2.ToCharArray();

                Array.Sort(Caracteres2);
                Array.Sort(Caracteres1);

                if (Caracteres2.SequenceEqual(Caracteres1))
                {
                    Console.WriteLine("Es un anagrama");
                }
                else
                {
                    Console.WriteLine("No es un anagrama");
                }

            }
        }
        public void Ejer5()
        {
            //Crear una aplicación que, cuando el usuario ingresa un número de 5 cifras, lo invierta y
            //muestre por pantalla “El número invertido es: *nnnnn *”. Por ejemplo, si el usuario
            //ingresa “12345”, mostrará por pantalla “54321”. 
            int numero;
            int numero2 = 0;
            Console.Write("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int x = 0 ; x < 5; x++)
            {
                numero2 = numero2 * 10 + numero % 10;
                numero /= 10;
            }
            

            Console.WriteLine(numero2);
        }

        public void Ejer6()
        {
            //Crear una aplicación que, cuando el usuario ingrese dos números, realice la operación
            //aritmética(a + b) * (a - b) e indique por pantalla el resultado.
            int a , b;
            int numero3 = 0;

            Console.WriteLine("Ingrese un numero: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            b = Convert.ToInt32(Console.ReadLine());

            numero3 = (a + b) * (a - b);

            Console.WriteLine("El resultado del numero = " + numero3);
        }

        public void Ejer7()
        {
            //Crear una aplicación que, cuando el usuario ingrese cinco números, indique cuál es
            //mayor, cuál es valor intermedio y cuál el menor.

            int numero;
            List<int> numero1 = new List<int>();

           
            for (int x = 0; x < 5; x++)
            {
                Console.Write("Ingrese un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                numero1.Add(numero);
                
            }
            Console.WriteLine(numero1.Max());
            Console.WriteLine(numero1.Min());
            Console.WriteLine(numero1.Average());
        }

        public void Ejer8()
        {
            //Crear una aplicación que, cuando el usuario ingrese una fecha, calcule la diferencia entre
            //ésta y el día de hoy, mostrando por pantalla "La diferencia de fechas es de *nnnnn* 
            //días." 

            DateTime Hoy = DateTime.Today;
            DateTime Fecha;
            string Diferencia ;
            Console.Write("Ingrese una Fecha (mm/dd/AAAA) =");
            Fecha = Convert.ToDateTime(Console.ReadLine());

            Diferencia = ("La diferencia de fechas es de : " + ( Fecha - Hoy).Days);
            Console.WriteLine(Diferencia);
        }

        public void Ejer9()
        {
            //Crear una aplicación que pida al usuario su nombre e indique por pantalla “¡Hola, 
            //*usuario * !” si ingresa su nombre, en caso contrario dirá “No te conozco”. 
            //Por ejemplo, si el usuario es Suyai, e ingresa el nombre “Suyai” dirá “¡Hola, Suyai!”, si
            //no, “No te conozco” 
            string nombre;

            Console.Write("Ingrese su Nombre: ");
            nombre = Console.ReadLine();

            if (!string.IsNullOrEmpty(nombre))
                {
                Console.WriteLine("\"Hola, " + nombre + "!\"");
                }
            else
            {
                Console.WriteLine("No te conzoco");
            }
            
        }

        public void Ejer10()
        {
            //Crear una aplicación que lea un carácter tecleado por el usuario e indique si se trata de
            //una vocal, una cifra numérica o una consonante. 
            //Nota: Incluir todas las validaciones que considere necesarias(los caracteres especiales
            //no deben tenerse en cuenta).

            string entrada;
            int salida;

            Console.WriteLine("Ingrese algo:") ;
            entrada =Convert.ToString(Console.ReadLine());

            if (entrada== "a" || entrada == "e" || entrada == "i" || entrada  == "o" || entrada == "u")
            {
                Console.WriteLine(entrada + "= a una Vocal");
            } 
            else if (int.TryParse(entrada, out salida))
            {
                Console.WriteLine("El dato es un numero");
            }
            else
            {
                Console.WriteLine(entrada + "= a una Consonante");
            }
        }

        public void Ejer11()
        {
            //Crear una aplicación que, cuando el usuario ingrese un nombre, un apellido y la edad en
            //un mismo input(en cualquier orden), indique cuál es cada uno.
            //Por ejemplo, el usuario ingresa “26 Suyai Pecoraro”, el programa mostrará por pantalla 
            //“Nombre: Suyai, Apellido: Pecoraro, Edad: 26”
        }

        public void Ejer12()
        {
            //crea una aplicación que, cuando el usuario ingrese dos fechas distintas, calcule la
            //diferencia entre éstas y la muestre por pantalla, indicando años, meses y días por
            //separado(en base 365).
            //Por ejemplo, si ingreso las fechas 23 / 09 / 1993 y 09 / 04 / 1997, la aplicación devolverá por
            //pantalla “La diferencia es de 3 años, 6 meses y 19 días”.
            
            string FechaActual = DateTime.Now.ToString("dd-MM-yyyy");
            string FechaIngresada2;
            string FechaIngresada;
            DateTime date;
            DateTime date2;
            
                Console.WriteLine("Ingrese fecha en formato {0}.", FechaActual);
                FechaIngresada = Console.ReadLine();
                Console.WriteLine("Ingrese otra fecha con el mismo formato");
                FechaIngresada2 = Console.ReadLine();
                date = VerificaFecha(FechaIngresada);
                date2 = VerificaFecha(FechaIngresada2);

            //Convert.ToDateTime(FechaIngresada);
            //int dia = Convert.ToInt32(Convert.ToDateTime(FechaIngresada).Day);
            //int day = Convert.ToDateTime(FechaIngresada).Day;
            //int day2 = Convert.ToDateTime(FechaIngresada2).Day;

            //int mes = Convert.ToDateTime(FechaIngresada).Month;
            //int mes2 = Convert.ToDateTime(FechaIngresada2).Month;

            //int year = Convert.ToDateTime(FechaIngresada).Year;
            //int year2 = Convert.ToDateTime(FechaIngresada2).Year;
            
            
            //int Diferencia = Convert.ToInt32((Convert.ToDateTime(FechaIngresada2) - Convert.ToDateTime(FechaIngresada)).Days);

            TimeSpan Diferencia = date - date2;
               
            Console.WriteLine("Hay una diferencia de {0} años, {1} meses y {2} días.", Diferencia.Days);

        }
        static DateTime VerificaFecha(string FechaIngresada)
        {
            if (DateTime.TryParse(FechaIngresada, out DateTime Salida))
            {
                return Salida;
            }
            else
            {
                return Salida;
            }
        }

        public void Ejer13()
        {
            //Crear una aplicación que, cuando el usuario ingrese un número, calcule el factorial del
            //mismo y lo muestre por pantalla. 
            //Nota: El factorial de un número es el producto de todos los números enteros positivos
            //desde 1 hasta n. Por ejemplo: 5! = 1 x 2 x 3 x 4 x 5 = 120
            
            int result = 0;
            Console.Write("Ingrese el numero entero: ");
            int numero = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int j = 1; j <= numero; j++)
            {
                factorial = factorial * j;
            }

            Console.WriteLine("El factorial de " + numero + " es: " + factorial);
        }

        public void Ejer14()
        {
            //Crear una aplicación que, cuando el usuario ingrese un número, muestre su tabla de
            //multiplicar por pantalla.

            int numero ;
            Console.Write("Ingrese un numero:");
            numero = Convert.ToInt32(Console.ReadLine());
            for(int n = 0; n<10; n++)
            {
                Console.WriteLine("Tabla de  " + n + "  " + (numero * n)); 
            }
        }

        public void Ejer15()
        {
            //Crear una aplicación que verifique, en tres oportunidades, si la clave ingresada por el
            //usuario es correcta.La clave será el nombre del usuario, si acierta mostrará por pantalla
            //“Bienvenido, *usuario *”, si no acierta mostrará “Acceso denegado. La contraseña no es
            //correcta”, y cuando se cumplan los tres intentos mostrará “Clave bloqueada”. 
        }
        public void Ejer16()
        {
            //Crear una aplicación que, cuando el usuario ingrese un número, lo muestre por pantalla
            //e indique cuántos dígitos tiene. 
            //Si el usuario ingresa 5629, mostrará “Número ingresado: 5629 – Tiene 4 dígitos”
            string num2;
            Console.WriteLine("Ingrese un número");
            num2 = Console.ReadLine();

            Console.WriteLine("El numero ingresado: {0} - Tiene {1} digitos. ", num2, num2.Length);
        }
        public void Ejer17()
        {
            //Crear una aplicación que tome los nombres y sueldos de cinco empleados, para mostrar
            //por pantalla el sueldo mayor y el nombre del empleado.
        }

        public void Ejer18()
        {
            //Crear una aplicación que, cuando el usuario ingrese un número decimal, muestre por
            //pantalla el número original y el mismo número en binario, octal y hexadecimal.
        }
        public void Ejer19()
        {
            //Crear una aplicación que, cuando el usuario indique la cantidad de palabras a ingresar y
            //las cargue, las muestre por pantalla indicando el largo, en cantidad de caracteres, de
            //cada una
        }
        
        public void Ejer20()
        {
            //Crear una aplicación que, cuando el usuario ingrese un número, indique la cantidad de
            //números primos entre el cero y él, y su factorial.
            //Por ejemplo, si el usuario ingresa 5, indicará “Hasta el 5 hay 3 números primos y el
            //factorial de 5 es 120”.
        }
    }
    
}
