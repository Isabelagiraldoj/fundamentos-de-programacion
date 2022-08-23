using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplosparametrosfunciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para demostrar los tipos de parametros en funciones");

            Console.Write("Ingresa un numero entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El numero antes de entrar a la funcion por valor es {numero}");
            IncrementaValorNumero(numero);

            IncrementaReferenciaNumero(ref numero);
            Console.WriteLine($"el numero despues de entarar a la funcion es {numero} ");

            Console.Read();


            
        }
        //si estan en llaves distintas son contextos diferentes

        static void IncrementaReferenciaNumero (ref int numero)
        {
            numero  += 5;
            Console.WriteLine($"El numero en la funcion es {numero}");
        }
        static void IncrementaValorNumero(int datoNumero)
        {
            datoNumero +=5;
            Console.WriteLine($"El numero en la funcion es {datoNumero}");

        }

        
    }
}
