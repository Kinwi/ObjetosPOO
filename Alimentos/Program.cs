using System;

namespace Alimentos
{
    class Program
    {
        static void Main(string[] args)
        {

            // Construccion de objetos

            Alimentos alimento1 = new Alimentos("Manzana", 0.5, 50, true);
            Alimentos alimento2 = new Alimentos("Merluza", 18, 200, true);
            Alimentos alimento3 = new Alimentos("Chuleton", 30, 250, true);
            Alimentos alimento4 = new Alimentos("Bollicao", 50, 450, false);


            // Ejecuccion de metodos

            Console.WriteLine($"Este alimeto es dietetico {alimento1.EsDietetico()}");
            Console.WriteLine($"Numero de calorias por 100 gr de Merluza {alimento2.Calorias(100)}");
            Console.WriteLine($"Numero de calorias por 100 gr de Bollicao {alimento4.Calorias(100)}");
            Console.WriteLine($"Este alimeto es dietetico {alimento3.EsDietetico()}");




        }
    }
}
