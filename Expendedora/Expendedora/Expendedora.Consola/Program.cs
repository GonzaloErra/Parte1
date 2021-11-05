using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using ConsolaUtils;
using Entity.Excep;

namespace Expend.Consola
{
    class Program
    {

        static void Main(string[] args)
        {

            bool continuarActivo = true;
            string menu = "//Encender Maquina // \n //Pedir Listado de Latas Disponibles // \n  //Ingresar Una Lata // \n // Ingrese el Codigo para Elegir un Lata // \n //Conocer Balance // \n //Conocer Stock y Descripcion de la Lata.// \n // Para Salir apagar precio X. ";
           
            Expendedora Expe = new Expendedora();
            do
            {
                Console.WriteLine(menu);
                string opcionSeleccionada = Console.ReadLine();
                String[] opcionesValidas = new String[] { "0","1", "2", "3", "4", "5","X"};
                if (Utilidades.EsOpcionValida(opcionSeleccionada, opcionesValidas))
                {
                    if (opcionSeleccionada.ToUpper() == "X")
                    {
                        Expe.Encendida = false;
                        continuarActivo = false;
                        continue;
                    }
                    switch (opcionSeleccionada)
                    {
                        case "0":
                            Console.WriteLine("Ingreso a La maquina Expendedora.");
                            Expe.EncenderMaquina();
                            break;
                        case "1":
                            if (Expe.Encendida == true)
                            {
                                List<Lata> latas = new List<Lata>();
                                latas = Expe.Latas;
                                latas.ToString();
                            }
                            break;
                        case "2":
                            Program.IngresarLata(Expe);
                            break;
                        case "3":
                            Program.ExtraerLata(Expe);
                            break;
                        case "4":
                            Program.ObetenerBalance(Expe);
                            break;
                        case "5":
                            Program.MostrarStock(Expe);
                            break;
                    }
                }
            } while (continuarActivo == true);
        }

        private static void IngresarLata(Expendedora exp)
        {
            if (exp.Encendida == true)
            {
                try
                {
                    string codigo = Utilidades.ValidarCadena("Ingrese el Codigo:");
                    int precio = Utilidades.ValidarNumericoInt("Ingrese el monto :");
                    double volumne = Utilidades.ValidarNumericoInt("Ingrese el Volumen:");
                    int cantidad = Utilidades.ValidarNumericoInt("ingrese la Cantidad Ingresada:");
                    string nombre = Utilidades.ValidarCadena("Ingrese el nombre del producto:");
                    Lata lata = new Lata(codigo, nombre, precio, volumne, cantidad);
                }
                catch (CapacidadMaximaException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (LataYaExcisteException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }

            else
            {
                Console.WriteLine("La Expendedora no esta Encendida");
            }
        }

        private static void ExtraerLata(Expendedora exp)
        {
            if (exp.Encendida == true)
            {
                try
                {
                    foreach (Lata lat in exp.Latas)
                    {
                        Console.WriteLine($"{lat.Codigo} - {lat.Nombre} -{lat.Precio} ");
                    }
                    string codigo = Utilidades.ValidarCadena("Ingrese el Codigo de la lata que quiere:");

                    int precio = Utilidades.ValidarNumericoInt($"Ingrese el monto de la lata selecionada ");
                    Lata lata = exp.ExtraerLata(codigo, precio);
                    Console.WriteLine("Que la Disfrute.");
                }
                catch (LataNoExcisteException ex){ Console.WriteLine(ex.Message);  }
                catch (FaltaMoneyException ex) { Console.WriteLine(ex.Message); }
                catch (NoHayStock ex) { Console.WriteLine(ex.Message); }
                catch(Exception ex) { Console.WriteLine(ex.Message); }
            }
        }
        private static void ObetenerBalance(Expendedora exp)
        {
            if (exp.Encendida == true)
            {
              

                Console.WriteLine(exp.GetBalance());
            }
        }
        private static void MostrarStock(Expendedora exp )
        {
                if (exp.Encendida == true && exp.Capacidad != 0)
                {
                foreach (Lata latas in exp.Latas)
                    Console.WriteLine($"{latas.Nombre} - {latas.Sabor} - {latas.GetPrecioPorLitro()} - {latas.Cantidad} ");

                Console.WriteLine($"La capacidad Restantes = {exp.GetCapacidadRestante()}");                    
                }
            }
    }
}
