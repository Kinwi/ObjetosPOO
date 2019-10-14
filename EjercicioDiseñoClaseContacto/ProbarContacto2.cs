using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDiseñoClaseContacto
{
    class ProbarContacto2
    {

        static void Main(string[] args)
        {

            //12.- Crea una clase con main() para probar Contacto2 que cree los siguientes contactos:

            //1.Miren  944123456 6 / 3 / 1990 Amigos
            //2.Jon  931212123 Trabajo
            //3.Ane 5 / 5 / 1995   Familia
            //4.Julen 944123321 12 / 2 / 1992 Estudios
            //5.Jone 6 / 6 / 1992
            //6.Mikel 7 / 7 / 1997   Familia

            Contacto2 c1 = new Contacto2("Miren",944123456, Convert.ToDateTime(6/3/1990),"Amigos");
            Contacto2 c2 = new Contacto2("Jon", 931212123,"Trabajo");
            Contacto2 c3 = new Contacto2("Ane" ,Convert.ToDateTime(1995/5/5) ,"Familia");
            Contacto2 c4 = new Contacto2("Julen" ,944123321 ,Convert.ToDateTime(12 / 2 / 1992) ,"Estudios");
            Contacto2 c5 = new Contacto2("Jone" , Convert.ToDateTime(6 / 6 / 1992));
            Contacto2 c6 = new Contacto2("Mikel", Convert.ToDateTime(7 / 7 / 1997) ,"Familia");

            //  16.- Mostrar los datos de todos los contactos

            c1.MostrarDatos();
            c2.MostrarDatos();
            c3.MostrarDatos();
            c4.MostrarDatos();
            c5.MostrarDatos();
            c6.MostrarDatos();
         



        }
    }
}
