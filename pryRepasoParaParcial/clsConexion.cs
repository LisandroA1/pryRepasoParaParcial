using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryRepasoParaParcial
{
     class clsConexion
    {
        public static string getCadena()
        {
            string cadena = "provider=microsoft.jet.oledb.4.0;data source=COLEGIO.mdb";
            return cadena;
        }
    }
}
