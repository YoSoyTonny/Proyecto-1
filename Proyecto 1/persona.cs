using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class persona
    {
        public int edad;
        public string nombre;

       public persona(int edad, string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }

        public persona()
        {
            this.edad = 0;
            this.nombre = "";
        }

        void cumplirAno()
        {
            this.edad++;
        }
    }
}
