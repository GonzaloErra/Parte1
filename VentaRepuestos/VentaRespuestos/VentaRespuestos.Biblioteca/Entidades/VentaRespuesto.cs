using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRespuestos.Biblioteca.Entidades;

namespace VentaRespuestos.Biblioteca.Entidades
{
    public class VentaRespuesto
    {
        private List<Respuesto> _listaRespuesto;
        private String _nombreComercio;
        private String _drieccion;
        // COSTRUCTORES
        public VentaRespuesto(string nombreComercio, string drieccion)
        {
            _listaRespuesto= new List<Respuesto>();
            _nombreComercio = nombreComercio;
            _drieccion = drieccion;
        }
        public VentaRespuesto()
        {
        }
        // GETTERS && SETTERS
        public string NombreComercio
        {
            get
            {
                return _nombreComercio;
            }
        }
        public string Direccion
        {
            get
            {
                return _drieccion;
            }
        }

        // METODOS
        public void AgregraRespuestos( int codigo, Respuesto objeto)
        {
            List<Respuesto> lst = _listaRespuesto;
            foreach (Respuesto res in lst)
            {
                if (res.Codigo != codigo)
                    lst.Add(objeto);
            }
        }
        public void QuitarRespuesto(int codigo)
        {
            Respuesto res = _listaRespuesto.Find(x => x.Codigo.Equals(codigo));
            if (res == null)
                throw new Except.NoRespuestoException();
            else if (res.Stock != 0)
                throw new Except.TieneStockException();
            _listaRespuesto.Remove(res);
            List<Respuesto> lst = _listaRespuesto;
        }
        public void ModificarPrecio(int codigo, double valor2)
        {
            foreach (Respuesto respuesto in _listaRespuesto)
            {
                if (codigo == respuesto.Codigo)
                {
                    respuesto.Precio = valor2;
                }
            }
        }
        public void AgregarStock(int codigo, int stock2)
        {
            List<Respuesto> lst = _listaRespuesto;
            foreach (Respuesto res in lst)
            {
                if (res.Codigo != codigo)
                    res.Stock = stock2;
            }
        }
        public void QuitarStock(int codigo, int stock2)
        {
            Respuesto RespuestoAEliminar = new Respuesto();
            foreach (Respuesto res in _listaRespuesto)
            {
                if (res.Codigo == codigo)
                    RespuestoAEliminar = res;
                    //res.Stock = (res.Stock-stock2);
            }
            if (RespuestoAEliminar == null)
                throw new Except.NoRespuestoException();
            else
                _listaRespuesto.Remove(RespuestoAEliminar);
        }
        public List<Respuesto> TraerPorCategoria(int categoria)
        {
            List<Respuesto> newres = new List<Respuesto>();
            foreach (Respuesto res in _listaRespuesto)
            {
                if (res.Categoria.Codigo == categoria)
                    newres.Add(res);
            }
            return newres;
        }
        public int TraerNuevoCodigo()
        {
            // buscar el ultimo codigo de ficha dentro de la lista, sumarle 1 y retornarlo
            List<int> Codigos = new List<int>();
            List<Respuesto> lst = _listaRespuesto;
            foreach (Respuesto res in lst)
            {
                Codigos.Add(res.Codigo);
            }
            return Codigos.Max();
        }
        public List<Respuesto> TraerRespuestos()
        {
            if (_listaRespuesto.Count == 0)
                return null;
            else
                return _listaRespuesto;
        }
      

    }
}

