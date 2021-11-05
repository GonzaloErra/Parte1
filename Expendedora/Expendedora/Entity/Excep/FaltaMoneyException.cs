using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Excep
 {
    public class FaltaMoneyException:Exception
    {
        public FaltaMoneyException() : base("No ingreso el monto Solicitado")
        {
            
        }
            
    }
}
