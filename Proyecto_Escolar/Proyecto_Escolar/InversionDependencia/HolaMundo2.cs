using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Escolar.InversionDependencia
{
    class HolaMundo2
    {
        private DateTime _horaSaludo;

        public HolaMundo(DateTime horaSaludo)
        {
            _horaSaludo = horaSaludo;
        }

        public string Saludar(string nombre)
        {
            if (_horaSaludo.Hour < 12)
                return "Buenos días " + nombre;
            if (_horaSaludo.Hour > 19)
                return "Buenas noches " + nombre;
            return "Buenas tardes " + nombre;
        }
    }
}
