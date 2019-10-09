using System;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche = new Coche("Ranault","Laguna","Neon",120,5);
            Coche coche2 = new Coche();

            coche2.SetMarca("Ferrari");
            coche.Arrancar();
            Console.WriteLine(coche.GetMarca());

            Finanzas finanzas = new Finanzas();
            Finanzas finanzas2 = new Finanzas(0.8);

            Console.WriteLine("$ 5 euros son:{finanzas.EurosToDolares(5))}dolares");
            Console.WriteLine("$ 8 dolars son:{finanzas2.DolaresToEuros(5))}euros");


            Numero numero = new Numero();
            Numero numero1 = new Numero(5);

            numero.Aniade();
            Console.WriteLine(numero.GetNumero());
            numero1.GetTriple();
            //numero1.SetNumero(numero1.GetTriple());
            numero1.GetDoble();
            //numero1.SetNumero(numero1.GetDoble());
            Console.WriteLine(numero1.GetNumero());

            //Satelite satelite1 = new Satelite(5,6,8);
            //satelite1.VariaAltura(5);
            //satelite1.EnOrbita();
            //satelite1.VariaPosicion(-5,8);
            


        }
    }
}
