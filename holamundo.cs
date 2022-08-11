using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace holamundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿humano como te llamas?");
            //console.writeline sirve para escribir cosas
            // las "" se usam para pone rlo que se quiere decir exactamente
            // para finalizar la linea
            string nombre = Console.ReadLine();
            // String es para guardar variables tipo letras
            // console.readline es para que la persona ingrese le dato y lo lea la consola
            Console.WriteLine("¿" + nombre + " en que año naciste?");
            // + x + sirve para que la consola muestre el dato guardado en una frase
            int añoNacimiento = int.Parse(Console.ReadLine());
            // se pone int. parse porque la variable console.readline lee variables tipo string entonces la debemos configurar para que lea variables numericas
            // int guardar variables tipo enteros
            int edad = DateTime.Now.Year - añoNacimiento;
                // datetime es una funcion para calcular el tiempo, now tiempo de ahora, year el año en que estamos
           Console.WriteLine("¿cuanto dinero ganas"+nombre +"?");
            float salario = float.Parse (Console.ReadLine());
            Console.WriteLine("pobre" + nombre + "a tus" + edad + "años y solo ganas" + salario + " pesitos");
            Console.Read();
        }
    }
}
