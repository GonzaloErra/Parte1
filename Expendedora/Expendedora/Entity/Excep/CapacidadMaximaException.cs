﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Excep
{
    public class CapacidadMaximaException : Exception
    {
        public CapacidadMaximaException() : base("Capacidad Maxima. ")
        {

        }
    }
}
