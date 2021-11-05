using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facu.Biblioteca.Entidades
{
    public sealed class Salario
    {
        private double _bruto; 
        private string _codigoTranferencia;
        private double _descuentos;
        private DateTime _fecha;
        //CONTRUCTOR
        public Salario(double bruto, string Transferencia, double descuento)
        {
            bruto = _bruto;
            Transferencia = _codigoTranferencia;
            descuento = _descuentos;
        }
        //GETTER && SETTER
        public double bruto { get => _bruto; }
        public string CodigoTransferencia { get => _codigoTranferencia; }
        public double Descuetos { get => _descuentos; }
        public DateTime Fecha { get => _fecha; }

        public double GetSalarioNeto()
        {
            return _bruto - _descuentos;
        }
        //public double Salario()
        //{

        //}
    }
}
