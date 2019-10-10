using System;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coche coche = new Coche("Ranault","Laguna","Neon",120,5);
            //Coche coche2 = new Coche();

            //coche2.SetMarca("Ferrari");
            //coche.Arrancar();
            //Console.WriteLine(coche.GetMarca());

            //Finanzas finanzas = new Finanzas();
            //Finanzas finanzas2 = new Finanzas(0.8);

            //Console.WriteLine("$ 5 euros son:{finanzas.EurosToDolares(5))}dolares");
            //Console.WriteLine("$ 8 dolars son:{finanzas2.DolaresToEuros(5))}euros");


            //Numero numero = new Numero();
            //Numero numero1 = new Numero(5);

            //numero.Aniade();
            //Console.WriteLine(numero.GetNumero());
            //numero1.GetTriple();
            ////numero1.SetNumero(numero1.GetTriple());
            //numero1.GetDoble();
            ////numero1.SetNumero(numero1.GetDoble());
            //Console.WriteLine(numero1.GetNumero());

            //Satelite satelite2 = new Satelite();
            //Satelite satelite1 = new Satelite(5,6,8);


            //satelite1.VariaAltura(5);
            //satelite2.EnOrbita();
            //satelite2.VariaPosicion(-5,8);


            //Console.WriteLine(" -----Conversor de Pesos--------");
            //Console.WriteLine();
            //Console.WriteLine("--------------MENU--------------------");
            //Console.WriteLine("1.Devuelve el Peso introducido a Libras");
            //Console.WriteLine("2.Devuelve el Peso introducido a Lingotes");
            //Console.WriteLine("3.Devuelve el Peso en la Medida que tu elijas");
            //Console.WriteLine("Introduce el numero del MENU para realizar la accion");
            //int caseSwitch = Convert.ToInt32(Console.ReadLine());

            //Peso peso = new Peso(peso);
            //switch (caseSwitch)
            //{
            //    case 1:
            //        Console.WriteLine("1.Devuelve el Peso introducido a Libras"););

            //        break;
            //    case 2:
            //        Console.WriteLine("Case 2");
            //        break;
            //    default:
            //        Console.WriteLine("Default case");
            //        break;
            //}


            Peso peso1 = new Peso(20, "li");
​
            Peso peso2 = new Peso(12, "q");
            Peso peso3 = new Peso(120, "g");
​
            Console.WriteLine($"{peso1.GetKilogramos()} kg son: {peso1.GetLibras()} libras");
            Console.WriteLine($"{peso2.GetKilogramos()} kg son: {peso2.GetLingotes()} lingotes");
            Console.WriteLine($"{peso3.GetKilogramos()} kg son: {peso3.GetPeso("oz")} onzas");
            Console.WriteLine(peso1.GetLingotes());
           


        }


    }
 }

