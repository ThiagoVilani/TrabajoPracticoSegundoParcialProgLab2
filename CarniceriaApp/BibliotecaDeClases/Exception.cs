using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class CargarDataGridViewException:Exception
    {
        public CargarDataGridViewException(string mensaje):base(mensaje)
        {

        }
    }

    public class NumeroNegativoException:Exception
    {
        public NumeroNegativoException(string mensaje) : base(mensaje)
        {
            
        }
    }
}
