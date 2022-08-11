using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeromayor
{
    // Pedir dos números al usuario por teclado y decir que número es el mayor.
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Escribeme el primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribeme el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            //ToInt32 dara 0
            if (num1 >= num2)
            {
                Console.WriteLine("El primer numero es mayor o igual que el segundo");
            }
            else
            {
                Console.WriteLine("El segundo numero es mayor que el primero");
            }

            Console.ReadLine();
        }

    }
}

