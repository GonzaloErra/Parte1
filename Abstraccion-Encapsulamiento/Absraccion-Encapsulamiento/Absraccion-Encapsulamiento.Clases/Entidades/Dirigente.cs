using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absraccion_Encapsulamiento.Clases.Entidades
{
    public class Dirigente
    {
        public String _nombre;
        public String _cargo;
        public int _salario;

        public Dirigente()
        {
        }

        public Dirigente(string nombre, string cargo, int salario)
        {
            _nombre = nombre;
            _cargo = cargo;
            _salario = salario;
        }

        public String NombreDirgente
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public String Cargo
        {
            get
            {
                return _cargo;
            }
            set
            {
                _cargo = value;
            }
        }
public int Salario
        {
            get
            {
                return _salario;
            }
            set
            {
                _salario = value;
            }
        }
    }
}
