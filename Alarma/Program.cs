using System;

namespace Alarma
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarma a1 = new Alarma(40);

            Alarma a2 = new Alarma();


            Console.WriteLine(a1.Alarma());
            Console.WriteLine(a2.Alarma(35));
            Console.WriteLine(a1.Comprueba());
        }
    }
}
