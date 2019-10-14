using System;
using System.Collections.Generic;
using System.Text;

namespace BarajaEspañola
{
    class Baraja
    {
        //Atributos

        public int [] Numero { get; set; }
        public int [] Palo { get; set; }


        //Un constructor sin parámetros que crea una carta con valores aleatorios(un nº entre 1 y 10 para el número y 
        //otro nº entre 1 y 4 para el palo).
        //Utilizar el método random de la clase Math).

        public Baraja()

        {
            // Generar numero aleatorio del 1 al 4 (Sacamos Palos)



            // Generar numero aleatorio del 1 al 10 (Numeros de la baraja)

          
            for (int i = 0; i <= 40; i++)
            {
                //string[] Palos = { "Oros", "Bastos", "Espadas", "Copas" };
               
                Random numeros = new Random();
                Numero [i]=numeros.Next(1, 10);

                Random palos = new Random();
                Palo [i] = palos.Next(1, 4);
            }

            
        }


        //Un método llamado mostrar  que muestre la carta generada con el formato, por ejemplo, 3 de copas.

        public void Mostrar()

        {

            Console.WriteLine($"La carta generada sera el{Numero[0]} de {Palo[0]}");
        }
    }
}
