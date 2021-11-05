using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Expendedora
    {
        private List<Lata> _latas;
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;

        public Expendedora()
        {

        }
        public Expendedora (List<Lata> Latas , string proveedor, int capacidad, double dinero)
        {
            _latas = Latas;
            _proveedor = proveedor;
            _capacidad = capacidad;
            _dinero = dinero;
            _encendida = true;
        }

        public List<Lata> Latas { get => _latas; }
        public string Proveedor { get => _proveedor; }
        public int Capacidad { get => _capacidad; }
        public double Dinero { get => _dinero; }
        public bool Encendida { get => _encendida; set{ _encendida = value;} }

        public void AgregarLata(Lata lataIngresada)
        {

            foreach ( Lata lata in _latas)
            {
                if (lata == lataIngresada)
                    throw new Excep.LataYaExcisteException();
            }
            if (_latas.Count + 1 >= _capacidad)
                throw new Excep.CapacidadMaximaException();
        }
        public Lata ExtraerLata(string a , double b)
        {
            foreach (Lata lata in _latas)
            {
                if (lata.Codigo != a)
                    throw new Excep.LataNoExcisteException();
                else if (lata.Codigo == a && lata.Precio != b)
                {
                    throw new Excep.FaltaMoneyException();
                }
                else if (lata.Stock <= 0)
                {
                    throw new Excep.NoHayStock();
                }
                _latas = RestarStock(_latas, lata);
                _dinero += b;
                return lata;
            }
            return null;
        }
        public string GetBalance()
        {
            return $"Cantidad de Dinero - {_dinero} - Cantidad de latas - {_latas.Count}";

        }
        public int GetCapacidadRestante()
        {
            return _capacidad - _latas.Count;

        }
        public void EncenderMaquina()
        {
            _encendida = true;
        }
        //public bool EstaVacia()
        //{
        //    foreach (Lata lata in _latas)
        //    {

        //    }
        //}
        public List< Lata > RestarStock(List<Lata> latas ,Lata lata)
        {
            foreach (Lata la in latas)
            {
                if (la == lata)
                    la.Stock --;
                break;
            }
            return latas;
        }
    }
}
