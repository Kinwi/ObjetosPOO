using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo(5, 5, 5);
            Triangulo t2 = new Triangulo(5, 5, 6);
            Triangulo t3 = new Triangulo(5, 4, 6);

            Console.WriteLine("Este triangulo (t1)es equilatero" + t1.EsIsosceles());
            Console.WriteLine("Este triangulo(t1) es escaleno" + t1.EsEscaleno());
            Console.WriteLine("Este triangulo(t2) es equilatero" +  t2.EsEscaleno());
            Console.WriteLine("El perimetro del triangulo es " + t2.perimetroTriangulo());

        }
    }
}
