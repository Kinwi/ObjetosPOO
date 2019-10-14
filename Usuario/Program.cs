using System;

namespace Usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desde la clase Main prueba los  métodos de esta clase escribiendo las siguientes sentencias :

            // - Crea un usuario llamado u1 pasando los tres datos como argumentos

            Usuario u1 = new Usuario("Raul","Lopez","9464077290");

            // - Probar si el usuario u1 es de Cantabria o no.

            u1.EsDeCantabria();


            //Mostrar las veces que el apellido de u1 contiene una letra que pasamos como argumento

            //u1.ContieneLetra(a); // Hay que ponerle comillas simples para que funciones


            //Modificar el teléfono del usuario u1 y ponerle “955676767”.

            u1.Telefono = "955676767";



            Cliente c1 = new Cliente("Raul", "Lopez", "661096741", 1); // SOLUCIONAR 
            Cliente c2 = new Cliente("Itxaso", "Libano", "662086514", 2);


            /*
            c.- Generar oferta:
            Generar una oferta según el cliente tenga un contrato u otro, ofreciéndole el contrato del siguiente nivel superior.
             Ej: Si un cliente
            Nombre: Jon
            Apellido :Zabaleta
            Telefono: 600100234
            Tipo contrato: Linea + Internet


            Mensaje para : jon_zabaleta4 @javamail.com

             *************** Oferta especial para Jon Zabaleta ****************
            **Si cambias a Linea + Internet + linea móvil à                    **
            **30euros – 20 % = 24 euros el primer año              **
            **********************************************************************

            Si el cliente ya tiene la opción más completa sacar el mensaje à No hay oferta disponible en este momento.

            */


            Console.WriteLine("**************************CONTRATO CLIENTE * *****************************");
            Console.WriteLine();
            Console.WriteLine($"                    Nombre            {c1.Nombre}");
            Console.WriteLine($"                    Apellido          {c1.Apellido}");
            Console.WriteLine($"                    Telefono          {c1.Telefono}");
            Console.WriteLine($"                 Tipo de Contrato          {c1.TipoContrato}");
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");

            if (c1.TipoContrato == 4)
            {
                Console.WriteLine("No hay oferta disponible por el momneto");
            }

            else
            {

            Console.WriteLine($"****************OFERTA ESPECIAL PARA {c1.Nombre}{c1.Apellido}*******************");
            Console.WriteLine($"Si cambias {c1.TipoContrato} a                                                  ");
            Console.WriteLine($"Si cambias {c1.TipoContrato} a                                                  ");

            }

        }
    }
}
