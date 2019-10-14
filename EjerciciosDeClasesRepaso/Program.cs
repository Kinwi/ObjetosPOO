using System;

namespace EjerciciosDeClasesRepaso
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r1 = new Rectangulo();
            Rectangulo r2 = new Rectangulo();

            Console.WriteLine("La diagonal del rectangulo 1 es " + r1.Diagonal(5,8));
            Console.WriteLine(" El area del rectangulo 1 es " +  r1.Area(6,8));

        }
    }
}
