using System;

namespace BarajaEspañola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desde el método main() de la clase principal crear 2 objetos de tipo carta y
            //decir cuál de ellas es la ganadora(número más alto).

            Baraja carta1 = new Baraja(); // Creacion de la primera carta aleatoria con el constructor vacio Baraja()
            Baraja carta2 = new Baraja(); // Creacion de la segunda carta aleatoria con el constructor vacio Baraja()

            if (carta1.Numero[0] > carta2.Numero[1])
            {


                Console.WriteLine($"La carta1 {carta1.Numero[0]} es mayor que la carta {carta2.Numero[1]}");

            }

            else
            {
                Console.WriteLine($"La carta1 {carta1.Numero[0]} es menor que la carta {carta2.Numero[1]}");

            }
        }
    }
}
