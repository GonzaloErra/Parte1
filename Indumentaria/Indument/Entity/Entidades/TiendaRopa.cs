using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entidades.Indum;
namespace Entity.Entidades
{
    public class TiendaRopa

    {
        private List<Indumentaria> _inventario;
        private List<Venta> _ventas;
        private int _ultimoCodigo;

        public List<Indumentaria> Inventario { get => _inventario; }
        public int UltimoCodigo { get => _ultimoCodigo; }
        public int GetProximoCodigo()
        {
            return _ultimoCodigo += 1;
            //List<int> Codigo = new List<int>();
            //if (_inventario == null)
            //    return 1;
            //else
            //{
            //    foreach(Indumentaria indu in _inventario)
            //    {
            //        Codigo.Add(indu.Codigo);
            //        return Codigo.Last() + 1 ;

            //    }
            //}
            //return 1;
        }
        public void Agregar(Indumentaria indu)
        {
            if (indu is Camisa)
            {
                _inventario.Add(indu);
            }
            else if (indu is Pantalon)
            {
                _inventario.Add(indu);

            }
        }
        public void Modificar(Indumentaria indu)
        {
            foreach (Indumentaria indument in _inventario)
            {
                if (indu.Codigo.Equals(indument.Codigo))
                {
                    indument.Talle = indu.Talle;
                }
                else
                {
                    throw new Excep.CodigoNoEncontradoException();
                }
            }
        }
        public void Quitar(Indumentaria indu)
        {
            if (indu is Camisa)
            {
                Camisa cam = null;
                foreach (Indumentaria indument in _inventario)
                {
                    if (indu.Codigo.Equals(indument.Codigo))
                    {
                        cam = (Camisa)indu;
                    }
                }
                _inventario.Remove(cam);
            }
            else if (indu is Pantalon)
            {
                Pantalon pan = null;
                foreach (Indumentaria indument in _inventario)
                {
                    if (indu.Codigo.Equals(indument.Codigo))
                    {
                        pan = (Pantalon)indu;
                    }
                }
                _inventario.Remove(pan);
            }
        }
        public void IngresarOrden(Venta venta)
        {

        }
        public List<Indumentaria> Listar()
        {
            if (_inventario != null)
                return _inventario;

            else
                throw new Excep.InventarioNullException();
        }
        public List<Venta> ListarOrden()
        {
            if (_ventas != null)
            {
                return _ventas;
            }
            else
                throw new Excep.NoOrdenesException();

        }
        public void DevolverOrden(Venta orden)
        {

        }
    }
}
