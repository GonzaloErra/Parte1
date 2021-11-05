using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facul.Biblioteca;
using Facu.Biblioteca.Entidades;
using ConsolaUtils;
using Facul.Biblioteca.Enumerador;

namespace Facu.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables de estado de consola, flag de control de la aplicación
            bool continuarActivo = true;
            // menú que se va a mostrar luego de CADA acción
            string menu = "1) Listar Alumnos \n2) Listar Empleados\n3) Agregar Alumnos\n4) Modificar Alumnos\n5) Eliminar Alumnos\n6) Agregar Empleado\n7) Modificar Empleado\n8) Eliminar Empleado\n9)Limpiar Consola\n9)X para Salir";
            // Creo el objeto con el que voy a trabajar en este programa
            Facultad facultad = new Facultad("FCE");
            // pantalla de bienvenida
            Console.WriteLine("Bienvenido a " + facultad.Nombre);
            do
            {
                Console.WriteLine(menu); //mostramos el menú
                                         //capturamos la seleccion
                string opcionSeleccionada = Console.ReadLine();
                // validamos si el input es válido (en este caso podemos tmb dejar que el switch se encargue en el default.
                String[] opcionesValidas = new String[] { "1", "2", "3", "4", "5", "6", "7", "X" };
                if (Utilidades.EsOpcionValida(opcionSeleccionada, opcionesValidas))
                {
                    if (opcionSeleccionada.ToUpper() == "X")
                    {
                        continuarActivo = false;
                        continue;
                    }
                    switch (opcionSeleccionada)
                    {
                        case "1":
                            // listar
                            ListarAlumnos(facultad);
                            break;
                        case "2":
                            // listar
                            ListarEmpleados(facultad);
                            break;
                        case "3":
                            // alta
                            AgregarAlumno(facultad);
                            break;
                        //case "4":
                        //    //modificar
                        //    Program.ModificarAlumno(facultad);
                        //    break;
                        case "5":
                            // borrar
                            EliminarAlumno(facultad);
                            break;
                        case "6":
                            // alta
                            AgregarEmpleado(facultad);
                            break;
                        case "7":
                            // modificar
                            ModificarEmpleado(facultad);
                            break;
                        case "8":
                            // borrar
                            EliminarEmpleado(facultad);
                            break;
                        case "9":
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida.");
                }
                Console.WriteLine("Ingrese una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
            while (continuarActivo);
            Console.WriteLine("Gracias por usar la app.");
            Console.ReadKey();
            }

        private static void ModificarEmpleado(Facultad facultad)
        {
            throw new NotImplementedException();
        }

        private static void EliminarEmpleado(Facultad facultad)
        {
            int leg = Utilidades.ValidarNumericoInt("ingrese el legajo del empleado que quiere modificar");
            try
            {
                facultad.EliminarEmpleado(leg);
                Console.WriteLine("Se elimino el Empleado");
            }
            catch (EmpleadoNoEncontradoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AgregarEmpleado(Facultad facultad)
        {
            try
            {
                int tipoEmpleado;
                string apodo = "";
                TipoEmpleado tipoDeEmpleado;
                do
                {
                    Console.WriteLine("¿Que tipo de Empleado desea agregar?: \n" +
                    $"1 - Bedel \n" +
                    $"2 - Docente \n" +
                    $"3 - Directivo");
                    tipoEmpleado = Utilidades.ValidarOpcion(3);
                    tipoDeEmpleado = TipoEmpleado.Docente;
                    if (tipoEmpleado == 1)
                    {
                        tipoDeEmpleado = TipoEmpleado.Bedel;
                        //strTipoEmpleado = "Bedel";
                    }
                    else if (tipoEmpleado == 2)
                    {
                        tipoDeEmpleado = TipoEmpleado.Docente;
                        //strTipoEmpleado = "Docente";
                    }
                    else
                    {
                        tipoDeEmpleado = TipoEmpleado.Directivo;
                        //strTipoEmpleado = "Directivo";
                    }
                } while (tipoEmpleado != 1 && tipoEmpleado != 2 && tipoEmpleado != 3);


                Console.WriteLine("ingrese el nuevo empleado");

                string nombre = Utilidades.ValidarCadena("nombre");

                string apellido = Utilidades.ValidarCadena("apellido");

                DateTime fecha_nacimiento = Utilidades.ValidarFecha("ingrese la fecha de nacimiento");

                DateTime fecha_ingreso = DateTime.Now;

                Random rand = new Random();
                int legajo = rand.Next();

                if (tipoDeEmpleado == TipoEmpleado.Bedel)
                {
                    apodo = Utilidades.ValidarCadena("Ingrese el Apodo del empleado");
                }
                double bruto = Utilidades.ValidarNumericoInt("ingrese el monto del salario bruto");
                string codtransfer = Utilidades.ValidarCadena("ingrese el cod de transferencia: ");
                double descuento = Utilidades.ValidarNumericoInt("ingrese el descento");

                Salario salario1 = new Salario(bruto, codtransfer, descuento);

                facultad.AgregarEmpleado(legajo, nombre, apellido, tipoDeEmpleado,apodo , fecha_nacimiento, fecha_ingreso);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void EliminarAlumno(Facultad facultad)
        {
            float Cod = Utilidades.ValidarNumericoFlo("Ingrese el codigo del alumno que quiere Eliminar");
            try
            {
                facultad.EliminarAlumno(Cod);
                Console.WriteLine("Se elimino el alumno");
            }
            catch(AlumnoNoEncontradoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //private static void ModificarAlumno(Facultad facultad)
        //{
        //    float Cod = Utilidades.ValidarNumerico("Ingrese el codigo del alumno que quiere modificar");

        //}

        private static void AgregarAlumno(Facultad facultad)
        {
            Console.WriteLine("Ingrese el nuevo alumno");
            string nombre = Utilidades.ValidarCadena("Nombre");
            string apellido = Utilidades.ValidarCadena("Apellido");
            DateTime fecha_nacimiento = Utilidades.ValidarFecha($"Ingrese la Fecha de Nacimiento: de este formato{DateTime.Now}");
            
            int codigo = (facultad.UltimoCodAlu()+1);
            
            Alumno alumno1 = new Alumno(codigo,nombre,apellido,fecha_nacimiento);

            facultad.AgregarAlumno(alumno1);
        }

        private static void ListarEmpleados(Facultad facultad)
        {
            List<Empleado> empleados = facultad.TraerEmpleado();
            if (empleados != null)
            {
            foreach (Empleado emple in empleados)
                {
                    Console.WriteLine(emple.ToString());
                }
            }
            else
            {
                Console.WriteLine(" Aun no hay fichas Cargadas.");
            }

        }
        private static void ListarAlumnos(Facultad facultad)
        {
            List<Alumno> alumnos = facultad.TraerAlumnos();
            if (alumnos != null)
            {
                foreach (Alumno alu in alumnos)
                {
                    Console.WriteLine(alu.ToString());
                }
            }
            else
            {
                Console.WriteLine(" Aun no hay fichas Cargadas.");
            }

        }
    }
}
  
