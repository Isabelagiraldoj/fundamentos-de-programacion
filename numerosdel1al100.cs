using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_del_1_al_100
{
    // escribir un programa que genere los dias del 1 al 100
    class Program
    {
        static void Main(string[] args)
        {
            // for se usa para ejecutar condiciones
            // i y j son el rango de valores ue se tomaran, se pone ++ si es el siguiente o -- si es el anterior
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
