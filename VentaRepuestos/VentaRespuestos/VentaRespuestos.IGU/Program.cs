using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRespuestos.Biblioteca.Entidades;
using VentaRespuestos.Biblioteca.Except;

namespace VentaRespuestos.IGU
{
    class Program
    {
        static bool _consolaActiva;
        static VentaRespuesto _VentaRespuestos;
        static Program()
        {
            _consolaActiva = true;
            _VentaRespuestos = new VentaRespuesto("Cameron", "Alsina 900");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenida a la Casa de Repuestos " + _VentaRespuestos.NombreComercio);

            while (_consolaActiva)
            {
                Menu();
                string opcionMenu = Console.ReadLine();

                switch (opcionMenu.ToLower())
                {
                    case "1":
                        // Lista Respuestos
                        ListarRepuestos();
                        break;
                    case "2":
                        // Agregar Repuesto
                        AgregarRespuestos();
                        break;
                    case "3":
                        //Eliminar Respuesto
                        EliminarRespuesto();
                        break;
                    case "4":
                        ModificarPrecios();
                        break;
                    case "5":
                        //Agregar Stock
                        AgregarStock();
                        break;
                    case "6":
                        QuitarStock();
                        break;
                    case "7":
                        TraerPorCategoria();
                        break;
                    case "x":
                        _consolaActiva = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadLine();

            }
        }

        private static void TraerPorCategoria()
        {
            Console.WriteLine("Ingrese el codigo de una categoria");

            int codigo = int.Parse(Console.ReadLine());

            List<Respuesto> respuesto = _VentaRespuestos.TraerPorCategoria(codigo);
            foreach (Respuesto r in respuesto)
            {
                Console.WriteLine(r.Nombre);
            }
        }
        private static void QuitarStock()
        {
            Console.WriteLine("Ingrese codigo");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de Stock a quitar");
            int stock2 = Convert.ToInt32(Console.ReadLine());
            _VentaRespuestos.AgregarStock(codigo, stock2);
            Console.WriteLine("Stock Restado.");
        }
        private static void ModificarPrecios()
        {
            Console.WriteLine("Ingrese codigo");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese nuevo Precio");
        }
        private static void EliminarRespuesto()
        {
            try
            {
                Console.WriteLine("Ingrese codigo");
                int codigo = Convert.ToInt32(Console.ReadLine());
                _VentaRespuestos.QuitarRespuesto(codigo);
                Console.WriteLine("Respuesto Eliminado.");
            }
            catch (NoRespuestoException ex) { Console.WriteLine(ex.Message); }
            catch (Exception ex) { Console.Write(ex.Message); }
        }
        private static void AgregarRespuestos()
        {
            // Crear Repuesto
            Console.WriteLine("Ingrese nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Precio");
            int precio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Stock");
            int stock = Convert.ToInt32(Console.ReadLine());
            Categoria categoria1 = new Categoria();
            Console.WriteLine("Ingrese nombre de Categoria");
            string nombreCategoria = Console.ReadLine();

            categoria1.NombreCategoria = nombreCategoria;
            int codigo = _VentaRespuestos.TraerNuevoCodigo();

            Respuesto res = new Respuesto(codigo, nombre, precio, stock, categoria1);

            _VentaRespuestos.AgregraRespuestos(codigo + 1, res);
            Console.WriteLine("Respuesto Agregado.");


            //if (resultado)
            //{
            //    Console.WriteLine("Ficha agregada.");
            //}
            //else
            //{
            //    Console.WriteLine("Error agregar la ficha.");

            //}
        }

        //METODO
        private static void ListarRepuestos()
        {
            List<Respuesto> lst = _VentaRespuestos.TraerRespuestos();

            if (lst != null)
            {
                foreach (Respuesto res in lst)
                {
                    Console.WriteLine("Nombre " + res.Nombre + " Precio " + res.Precio + "Stock" + res.Stock);
                }
            }
            else
            {
                Console.WriteLine("Aún no hay fichas cargadas.");
            }
        }
        private static void AgregarStock()
        {
            Console.WriteLine("Ingrese codigo");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Stock");
            int stock2 = Convert.ToInt32(Console.ReadLine());
            _VentaRespuestos.AgregarStock(codigo, stock2);
            Console.WriteLine("Stock Agregado.");
        }
        //MENU
        static void Menu()
        {

            Console.WriteLine("1) Listar Respuestos");
            Console.WriteLine("2) Agregar Respuestos");
            Console.WriteLine("3) Eliminar Respuestos");
            Console.WriteLine("4) Modificar Precio");
            Console.WriteLine("5) Agregar Stock");
            Console.WriteLine("6) Quitar Respuestos");
            Console.WriteLine("X: Terminar");
        }
    }
}
