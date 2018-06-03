using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escolar
{
    class HolaMundo1
    {
        public string Saludar(string nombre)
        {
            if (DateTime.Now.Hour < 12)
                return "Buenos días " + nombre;
            if (DateTime.Now.Hour > 19)
                return "Buenas noches " + nombre;
            return "Buenas tardes " + nombre;
        }
    }
}