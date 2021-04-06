using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un intervalo de tiempo: ");
          

            if(TimeSpan.TryParse(Console.ReadLine(), out TimeSpan ts))
            {
                Console.Write("El ingreso no puede ser interpretado como intervalo de tiempo.");
            }
            else
            {
                Console.Write("El ingreso puede ser interpretado como intervalo de tiempo.");
            }

            Console.ReadKey();
        }
    }
}
