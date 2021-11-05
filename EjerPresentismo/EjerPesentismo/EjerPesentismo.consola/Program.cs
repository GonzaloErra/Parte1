using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entidades;
using ConsolaUtils;
using Entity.Exep;

namespace EjerPesentismo.consola
{
    public class Program
    {
        static bool continuarActivo = true;
        static Presentismo _presentismo = new Presentismo();
        static void Main(string[] args)        
        {
            Preceptor preceptorActivo = _presentismo.GetPreceptorActivo();
            do
            {
                DesplegarOpcionesMenu();
                string opcionMenu = "Ingrese el Menu a elegir al que quiere acceder";// pedir el valor
                switch (opcionMenu)
                {
                    case "1":
                        TomarAsistencia(preceptorActivo);
                        break;
                    case "2":
                        MostrarAsistencia();
                        break;
                    case "X":
                        continuarActivo = false;
                        break;
                    default:
                        break;
                }
            } while (continuarActivo == false);
        }
        private static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("1) Tomar Asistencia");
            Console.WriteLine("2) Mostrar Asistencia");
            Console.WriteLine("X: Terminar");
        }
        private static void TomarAsistencia(Preceptor p)
        {
            List<Asistencia> ListaAsist = new List<Asistencia>();
            DateTime fechaIngresada = Utilidades.ValidarFecha("Ingresa fecha para tomar asistencia");

            foreach (Alumno al in _presentismo.GetListaAlumnos(Convert.ToString(fechaIngresada)))
            {
                if (al is AlumnoOyente)
                {
                    Console.WriteLine(al.ToString() + " es oyente.");
                }
                else if (al is AlumnoRegular)
                {

                    Console.Write(al.ToString() + " está presente? Ingrese (S/N):");
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "S":
                            Asistencia asist = new Asistencia(input, p, al, true);
                            ListaAsist.Add(asist);
                            break;
                        case "N":
                            Asistencia asist2 = new Asistencia(input, p, al, false);
                            ListaAsist.Add(asist2);
                            break;
                        default:
                            Console.WriteLine("Opción incorrecta.");
                            break;
                    }
                    try
                    {
                        _presentismo.AgregarAsistencia(ListaAsist, input);
                    }

                    catch (AsistenciaExistenteEseDiaException ex)
                    {
                        Console.Write(ex.Message);
                    }

                    catch (AsistenciaInconsistenteException ex)
                    {
                        Console.Write(ex.Message);
                    }

                    catch (Exception ex) { Console.Write(ex.Message); }
                }
            }
        }
        // Ingreso fecha
        // Listar los alumnos
        // para cada alumno solo preguntar si está presente
        // agrego la lista de asistencia
        // Error: mostrar el error y que luego muestre el menu nuevamente
        private static void MostrarAsistencia()
        {
            try
            {
                DateTime Fecha = Utilidades.ValidarFecha("ingrese la fecha en la cual quiere saber las asistencias");
                List<Asistencia> asistencias = _presentismo.GetAsistenciasPorFecha(Convert.ToString(Fecha));
                foreach (Asistencia asis in asistencias)
                {
                    Console.WriteLine(asis.ToString());
                }
            }
            catch (SinAsistenciasRegistradasException ex) { Console.WriteLine(ex.Message); }
            catch (Exception ex ) { Console.WriteLine(ex.Message); }
            // ingreso fecha
            // muestro el toString de cada asistencia
        }
    }

}
