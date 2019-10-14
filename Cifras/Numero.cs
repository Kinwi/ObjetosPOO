using System;
using System.Collections.Generic;
using System.Text;

namespace Cifras
{
    class Cifras
    {
        public int Numero { get; set; }
​
        public Numero(int numero)
        {
            Numero = numero;
        }
​
        public bool EsPar()
        {
            if (Numero % 2 == 0)
            {
                return true;
            }
            return false;
        }
​
        public void Divisores()
        {
            Console.WriteLine("Divisores: ");
            for (int i = 1; i <= Numero; i++)
            {
                if (Numero % i == 0)
                {
                    Console.Write($"{i}\t");
                }
            }
            Console.WriteLine();
        }
        public int SumaDigitos()
        {
            int suma = 0;
            string numero = Numero.ToString();
            for (int i = 0; i < numero.Length; i++)
            {
                suma += Convert.ToInt32(numero.Substring(i, 1));
            }
            return suma;
        }



      }

    }
}
