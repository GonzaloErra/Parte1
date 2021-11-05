using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entidades
{ 
    public class Presentismo 

    {
        private List<Preceptor> _preceptor;
        private List<Alumno> _alumno;
        private List<Asistencia> _asistencia;
        private List<string> _fechas;

        public Presentismo()
        {
            _alumno = new List<Alumno>();
            _asistencia = new List<Asistencia>();
            _preceptor = new List<Preceptor>();
            _fechas = new List<string>();
            _alumno.Add(new AlumnoRegular(123, "Carlos", "Juarez", "cjua@gmail.com"));
            _alumno.Add(new AlumnoRegular(124, "Carla", "Jaime", "cjai@gmail.com"));
            _alumno.Add(new AlumnoOyente(320, "Ramona", "Vals"));
            _alumno.Add(new AlumnoOyente(321, "Alejandro", "Medina"));
            _preceptor.Add(new Preceptor(5, "Jorgelina", "Ramos"));
        }
         public bool AsistenciaRegistrada(string fecha)
        {
            return this._fechas.Contains(fecha) ;
        }
        public Preceptor GetPreceptorActivo()
        {
            return _preceptor.Last();
        }
        public int GetCantidadAlumnosRegulares()
        {
            return _alumno.FindAll(x => x is AlumnoRegular).Count;
        }

        public List<Alumno> GetListaAlumnos(string fecha)
        {
            List<Alumno> alumnos = new List<Alumno>();
            foreach (Asistencia a in this._asistencia)
            {
                if (a.FechaReferencia == fecha)
                {
                    alumnos.Add(a.Alumno);
                }
            }
            return alumnos;
        }
        public void AgregarAsistencia(List<Asistencia> a, string b)
        {

            if (GetCantidadAlumnosRegulares() == a.Count())
            {
                if (!AsistenciaRegistrada(b))
                {
                    foreach (Asistencia asistente in a)
                        _asistencia.Add(asistente);
                    _fechas.Add(b);
                }
                else
                    throw new Exep.AsistenciaExistenteEseDiaException();
            }
            else
                throw new Exep.AsistenciaInconsistenteException();
        }
        public List<Asistencia> GetAsistenciasPorFecha(string fecha)
        {
            if (AsistenciaRegistrada(fecha))
            {
                return _asistencia.FindAll(x => x.FechaReferencia == fecha);
            }
            //List<Asistencia> asistencia2 = new List<Asistencia>();

            //foreach (Asistencia asis in _asistencia)
            //{
            //    if (asis.FechaReferencia == fecha)
            //    {
            //        asistencia2.Add(asis);
            //    }
            //}
            else
                throw new Exep.SinAsistenciasRegistradasException();
        }
    }
}
