using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entidades;
using ConsolaUtils;
using Entity.Entidades.TipoIndume;
using Entity.Entidades.Indum;
using Entity.Excep;

namespace Indument.Consola
{
    class Program
    {
        static bool flag = false;
        static TiendaRopa _tiendaRopa = new TiendaRopa();
        private static void Menu()
        {
            Console.WriteLine
                ("Seleccione una opcion.\n" +
                "1) Listar Indumentaria \n" +
                "2) Agregar Indumentaria \n" +
                "3)Modificar Indumentaria \n" +
                "4)Eliminar Indumentaria \n" +
                "5)Listar Ordenes \n" +
                "6)Ingresar Ordenes \n" +
                "7)Devolver Ordenes \n" +
                "8) SALIR");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            do
            {
                Menu();
                string Opcion = Console.ReadLine();

                switch (Opcion)
                {
                    case "1":
                        ListarIndumentaria(_tiendaRopa);
                        break;
                    case "2":
                        AgregarIndumentaria(_tiendaRopa);
                        break;
                    case "3":
                        ModificarIndumentaria(_tiendaRopa);
                        break;
                    case "4":
                        EliminarIndumentaria(_tiendaRopa);
                        break;
                    case "5":
                        ListarOrdenes(_tiendaRopa);
                        break;
                    case "6":
                        IngresarOrdenes(_tiendaRopa);
                        break;
                    case "7":
                        DevolverOrden(_tiendaRopa);
                        break;
                    case "8":
                        flag = true;
                        break;
                }
            } while (flag == false);
            Console.WriteLine("Gracias por usar el programa.");
            Console.ReadKey();
        }

        private static void DevolverOrden(TiendaRopa tiendaRopa)
        {
            throw new NotImplementedException();
        }

        private static void IngresarOrdenes(TiendaRopa tiendaRopa)
        {
            int CodVenta = tiendaRopa.UltimoCodigo; 
            int codigo = Utilidades.ValidarNumericoInt("ingresar el codigo de la prenda que quiere dar la orden");
            
            
        }

        private static void ListarOrdenes(TiendaRopa tiendaRopa)
        {
            List<Venta> ordenes = tiendaRopa.ListarOrden();
            foreach(Venta venta in ordenes )
            { venta.ToString(); }
        }

        private static void EliminarIndumentaria(TiendaRopa tiendaRopa)
        {
            try
            {

                string opcion = Utilidades.ValidarCadena("Ingrese que prenda quiere modificar C/P");
                int codigo = Utilidades.ValidarNumericoInt("Ingrese el codigo de la prenda que quiere modificar");
                if (opcion == "C")
                {
                    Camisa camisa = new Camisa(codigo);
                    tiendaRopa.Quitar(camisa);
                }
                else if (opcion == "P")
                {
                    Pantalon panta = new Pantalon(codigo);
                    tiendaRopa.Quitar(panta);

                }
            }
            catch (CodigoNoEncontradoException ex) { Console.WriteLine(ex.Message); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }

        private static void ModificarIndumentaria(TiendaRopa tiendaRopa)
        {
            try
            {

                string opcion = Utilidades.ValidarCadena("Ingrese que prenda quiere modificar C/P");
                int codigo = Utilidades.ValidarNumericoInt("Ingrese el codigo de la prenda que quiere modificar");
                string talle = Utilidades.ValidarCadena("Ingrese el talle nuevo");
                
                if (opcion == "C")
                {
                    Camisa camisa = new Camisa(codigo, talle);
                    tiendaRopa.Modificar(camisa);
                }
                else if (opcion == "P")
                {
                    Pantalon panta = new Pantalon(codigo, talle);
                    tiendaRopa.Modificar(panta);

                }
            }
            catch (CodigoNoEncontradoException ex) { Console.WriteLine(ex.Message); }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
            
            
        }

        private static void AgregarIndumentaria(TiendaRopa tienda)
        {
            bool bolsillo;
            bool estampado;
            

            string origen = Utilidades.ValidarCadena("de que origen es?");
            double porcentajeAlgodon = Utilidades.ValidarNumericoInt("Ingrese el porcentaje de algodon ");
            string tipoIndumentaria = Utilidades.ValidarCadena("Ingrese tipo de indumentaria \n" +
                                                                "Casual // Deportiva //Formal");
            string Indumentaria = Utilidades.ValidarCadena("Quiere Agregar Camisa o Pantalon C/P");
            int codigo = tienda.GetProximoCodigo();
            string talle = Utilidades.ValidarCadena("Ingrese el talle.");
            double precio = Utilidades.ValidarNumericoInt("Ingrese Precio");

            if (tipoIndumentaria == "Casual" )
            {
                IndumentariaCasual tipoindum = new IndumentariaCasual(origen,porcentajeAlgodon);
                if (Indumentaria == "C")
                {
                    string estamp = Utilidades.ValidarCadena("Ingresar si quiere estampado Y/N");
                    if (estamp == "Y")
                    {
                        estampado = true;
                    }
                    else
                    {
                        estampado = false;
                    }
                    string manga = Utilidades.ValidarCadena("Ingrese el tipo de manga que quiere ");
                    Camisa camisa = new Camisa(tipoindum, codigo, talle, precio, estampado, manga);
                    tienda.Agregar(camisa);
                }
                else if (Indumentaria == "P")
                {
                    string estamp = Utilidades.ValidarCadena("Quiere con Bolsillo Y/N");
                    if (estamp == "Y")
                    {
                        bolsillo = true;
                    }
                    else
                    {
                        bolsillo = false;
                    }
                    string manga = Utilidades.ValidarCadena("de que material lo quiere ");
                    Pantalon pantalon = new Pantalon(tipoindum, codigo, talle, precio, bolsillo, manga);
                    tienda.Agregar(pantalon);
                }
            }
            
            else if (tipoIndumentaria == "Deportiva")
            {
                IndumentariaDeportiva tipoindum = new IndumentariaDeportiva(origen, porcentajeAlgodon);
                if (Indumentaria == "C")
                {
                    string estamp = Utilidades.ValidarCadena("Ingresar si quiere estampado Y/N");
                    if (estamp == "Y")
                    {
                        estampado = true;
                    }
                    else
                    {
                        estampado = false;
                    }
                    string manga = Utilidades.ValidarCadena("Ingrese el tipo de manga que quiere ");
                    Camisa camisa = new Camisa(tipoindum, codigo, talle, precio, estampado, manga);
                    tienda.Agregar(camisa);
                }
                else if (Indumentaria == "P")
                {
                    string estamp = Utilidades.ValidarCadena("Quiere con Bolsillo Y/N");
                    if (estamp == "Y")
                    {
                        bolsillo = true;
                    }
                    else
                    {
                        bolsillo = false;
                    }
                    string manga = Utilidades.ValidarCadena("de que material lo quiere ");
                    Pantalon pantalon = new Pantalon(tipoindum, codigo, talle, precio, bolsillo, manga);
                    tienda.Agregar(pantalon);
                }
            }
            else if (tipoIndumentaria == "Formal")
            {
                IndumentariaFormal tipoindum = new IndumentariaFormal(origen, porcentajeAlgodon);
                if (Indumentaria == "C")
                {
                    string estamp = Utilidades.ValidarCadena("Ingresar si quiere estampado Y/N");
                    if (estamp == "Y")
                    {
                        estampado = true;
                    }
                    else
                    {
                        estampado = false;
                    }
                    string manga = Utilidades.ValidarCadena("Ingrese el tipo de manga que quiere ");
                    Camisa camisa = new Camisa(tipoindum, codigo, talle, precio, estampado, manga);
                    tienda.Agregar(camisa);
                }
                else if (Indumentaria == "P")
                {
                    string estamp = Utilidades.ValidarCadena("Quiere con Bolsillo Y/N");
                    if (estamp == "Y")
                    {
                        bolsillo = true;
                    }
                    else
                    {
                        bolsillo = false;
                    }
                    string manga = Utilidades.ValidarCadena("de que material lo quiere ");
                    Pantalon pantalon = new Pantalon(tipoindum, codigo, talle, precio, bolsillo, manga);
                    tienda.Agregar(pantalon);
                }
            }
            else
            {
                Console.WriteLine("INCORRECTO");
            } 
        }
        private static void ListarIndumentaria(TiendaRopa tienda)
        {
            List<Indumentaria> indu = tienda.Listar();
            foreach (Indumentaria x in indu)
            {
                Console.WriteLine(x.GetDetalle() + System.Environment.NewLine);
            }
            
        }
    }
}
