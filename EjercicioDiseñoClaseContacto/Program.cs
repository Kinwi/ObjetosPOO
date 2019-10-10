using System;

namespace EjercicioDiseñoClaseContacto
{
    class Program
    {
        static void Main(string[] args)
        {

            Contacto2 c1 = new Contacto2("Raul", 661096741,Convert.ToDateTime("25/06/1993"),"Familia");
            Contacto2 c2 = new Contacto2("Perico",687897632,Convert.ToDateTime("23/02/2040"),"Trabajos");

            Contacto c3 = new Contacto("Miren", 944123456, Convert.ToDateTime("4 / 2 / 1990"));
            Contacto2 c4 = new Contacto2("Ane", Convert.ToDateTime("5 / 5 / 1995"));
            Contacto c5 = new Contacto("Julen", 944123321, Convert.ToDateTime("4 / 2 / 1992"));

            //c1.MostrarDatos(); // Al estar mal la fecha pondra la fecha de hoy
            //c2.MostrarDatos();
            //c3.MostrarDatos(); 
            //c4.MostrarDatos();
            //c5.MostrarDatos();



            // NOMBRE
            // Cambiar nombre
            // Devolver nombre

            Console.WriteLine(c1.Nombre);
            c1.Nombre = "Rafa";

            // TELEFONO
            // Cambiar telefono
            // Devolver telefono
            Console.WriteLine(c1.Telefono);
            c1.Telefono = 66190865;


            // Cambiar TipoContacto y Obtener TipoContacto

            // Obtener Tipo de Contacto
            Console.WriteLine(" El tipo de contacto del objeto c1" + c1.TipoContacto);
            Console.WriteLine(" El tipo de contacto del objeto c2 " + c2.TipoContacto);

            // Cambiar Tipo de Contacto

            c1.TipoContacto = "Friends";
            c2.TipoContacto = "Family";
            

        }
    }
}
