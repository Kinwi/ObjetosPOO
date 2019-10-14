using System;

namespace Monedero
{
    class Program
    {
        static void Main(string[] args)
        {
            Monedero m1 = new Monedero(20);

            m1.MeterDinero(10);
            m1.SacarDinero(40);
            m1.SacarDinero(-3);
            m1.SacarDinero(25);
            Console.WriteLine();
        }
    }
}
