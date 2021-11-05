using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facul.Biblioteca;
using Facul.Biblioteca.Enumerador;

namespace Facu.Biblioteca.Entidades
{
    public class Facultad
    {
        private List<Alumno> _alumnos;
        private List<Empleado> _empleados;
        private string _nombre;
        private int _cantidadSedes;

        //CONSTRUCTOR
        public Facultad() { }
        public Facultad(string nombre)
        {
            _nombre = nombre;
            _alumnos = new List<Alumno>();
            _empleados = new List<Empleado>();

        }
        //SETTERS GETTER
        public int CantidadSedes { get => _cantidadSedes; }
        public string Nombre { get => _nombre; }
        //METODOS
        public void AgregarAlumno(Alumno alu)
        {
            _alumnos.Add(alu);
        }

        public void AgregarEmpleado(int legajo, string nombre, string apellido, TipoEmpleado tipoEmpleado, string apodo , DateTime FNacimiento, DateTime FIngreso)
        {
            Empleado empleado;
            if (tipoEmpleado == TipoEmpleado.Bedel)
            {
                empleado = new Bedel(apodo, legajo, nombre, apellido,FNacimiento, FIngreso);
            }
            else if (tipoEmpleado == TipoEmpleado.Docente)
            {
                empleado = new Docente(legajo, nombre, apellido, FNacimiento, FIngreso);
            }
            else
            {
                empleado = new Directivo(legajo, nombre, apellido, FNacimiento, FIngreso);
            }

            _empleados.Add(empleado);
        }
        public void EliminarAlumno(float var1)
        {
            Alumno AlumnoaBorrar = null;
            foreach (Alumno alu in _alumnos)
            {
                if (alu.Codigo == var1)
                {
                    AlumnoaBorrar = alu;
                }
            }
            if (AlumnoaBorrar == null)
                throw new AlumnoNoEncontradoException();
            else
                _alumnos.Remove(AlumnoaBorrar);
        }
        public void EliminarEmpleado(float var1)
        {
            Empleado empleadoAEliminar = null;
            foreach (Empleado emple in _empleados)
            {
                if (emple.Legajo == var1)
                {
                    empleadoAEliminar = emple;
                }
                else
                {
                    throw new EmpleadoNoEncontradoException();
                }
            }
            _empleados.Remove(empleadoAEliminar);

        }
        public void ModificarEmpleado(Empleado emple)
        {

        }
        public List<Alumno> TraerAlumnos()
        {
            return _alumnos;
        }
        public Empleado TraerEmpleadoPorLegajo(int legajo)
        {
            return _empleados.Find(x => x.Legajo.Equals(legajo));
        }
        public List<Empleado> TraerEmpleado()
        {
            return _empleados;
        }
        public List<Empleado> TraerEmpleadosPorNombre(string nombre)
        {
            return _empleados.FindAll(x => x.Nombre == nombre);
        }
        public int UltimoCodAlu()
        {
        List<int> Codigos = new List<int>();
        foreach (Alumno alu in _alumnos)
            if (alu.Codigo != 0)
            {
                Codigos.Add(alu.Codigo);
                return Codigos.Max();
            }
           
        return 0;
        }

    }
}
