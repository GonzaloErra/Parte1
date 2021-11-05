using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entidades
{
    public class Asistencia
    {
        private string _fechaReferencia;
        private DateTime _fechaHoraReal;
        private Preceptor _preceptor;
        private Alumno _alumno;
        private bool _estePresente;

        public Asistencia()
        {

        }
        public Asistencia( string Fecha , Preceptor pre, Alumno alu, bool presente )
        {
            _fechaReferencia = Fecha;
            _fechaHoraReal = DateTime.Now;
            _preceptor = pre;
            _alumno = alu;
            _estePresente = presente;

        }
        public string FechaReferencia { get => _fechaReferencia; }     
        public Alumno Alumno { get => _alumno; }
        public override string ToString()
        {
            return ($" {_fechaReferencia}");
        }
            
    }
}
