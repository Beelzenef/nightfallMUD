using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nightfallMUD
{
    class PJ
    {
        string nombre;
        int nivel;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
    }

    class MensajesPersonaje
    {
        static string obtenerNombre = "¿Cual es tu nombre?";
        static string bienvenidaNombre = "Bienvenido";

        public static string ObtenerNombre
        {
            get { return obtenerNombre; }
        }

        public static string BienvenidaNombre
        {
            get { return bienvenidaNombre; }
        }
    }
}
