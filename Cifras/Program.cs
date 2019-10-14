using System;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {

            Numero c1 = new Numero(12);
            if (c1.EsPar())
            {
                Console.WriteLine("Es par.");
            }
            else
            {
                Console.WriteLine("No Es par.");
            }
​
            c1.Divisores();
            Console.WriteLine($"La suma de los dígitos del número {c1.Numero} = {c1.SumaDigitos()}");





        }
    }
}
