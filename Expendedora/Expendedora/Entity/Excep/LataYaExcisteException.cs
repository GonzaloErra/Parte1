using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Excep
{
    public class LataYaExcisteException : Exception
    {
        public LataYaExcisteException() : base(" Ya exciste la lata en la Expendedora.")
        {
            
        }
    }
}
