using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Data
    {
        private string DATO, OPERACION, RESULTADO;
        public void setValues(string D, string O, string R)
        {
            DATO = D;
            OPERACION = O;
            RESULTADO = R;
        }

        public string getDATO()
        {
            return DATO;
        }
        public string getOPERACION()
        {
            return OPERACION;
        }
        public string getRESULTADO()
        {
            return RESULTADO;
        }
    }
}
