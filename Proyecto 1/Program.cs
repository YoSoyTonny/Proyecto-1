using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            persona persona1 = new persona(25, "José");

            Console.WriteLine(persona1.nombre + "Tiene " + persona1.edad + " años");

            Console.ReadLine();
        }
    }
}
