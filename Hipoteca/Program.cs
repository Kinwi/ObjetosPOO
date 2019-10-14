using System;

namespace Hipoteca
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Desde el método principal main() crear un programa que nos permita ver una tabla con las diferentes cuotas a pagar por interés por ejemplo: si tenemos una hipoteca de 6000 €  a un rédito del 3.5% y lo pagamos a 10,11,..,., hasta 20 años.
            Escribirá:                            	CAPITAL :6000 	REDITO: 3.5%
                                           	TIEMPO  	CUOTA
                                           	10             	2100
                                           	11             	2310
                                           	….            	……...
                                           	20             	4200

             
             */

            Hipoteca h1 = new Hipoteca(6000, 3.5,20);


            Console.WriteLine($"                 CAPITAL : {h1.Capital}   REDITO: {h1.Redito}");
            Console.WriteLine($"                         TIEMPO              CUOTA                ");
            Console.WriteLine($"                       {h1.Tiempo}        {h1.Cuota()}         ");
            Console.WriteLine($"                       {h1.Tiempo + 1}    {h1.Cuota()}         ");
            Console.WriteLine($"                       {h1.Tiempo + 1}    {h1.Cuota()}         ");

            h1.MostrarAtributos();
        }


    }
}
