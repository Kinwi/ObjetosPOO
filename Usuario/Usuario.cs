using System;
using System.Collections.Generic;
using System.Text;

namespace Usuario
{
    class Usuario
    {

        /*
        Diseñar una clase llamada Usuario:
        Atributos o propiedades:
        String Nombre, String Apellido y  String Telefono
        */


        // 2. Atributos y Metodos Selectores y Modificadores

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }

        


        //Metodos

        // 1. Un constructor que inicializa los datos con los valores pasados como argumentos


        public Usuario(string nombre, string apellido, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;

        }

        // 3. Un método llamado EsDeCantabria que devuelve verdadero si el teléfono comienza por “942” y falso en caso contrario.

        // Un numero de telefono tiene 10 caracteres incluyendo el prefijo . Ejemplo 9424077290
        public bool EsDeCantabria()
        {


            return respuesta;
        }


        /*
        Un método llamado GeneraEmail que genera y devuelve un email para el usuario :
        poniendo el nombre, , un guion el apellido y la última cifra de su teléfono y 
        añadiendo @javamail.com , todo en minúsculas

        ejemplo: si los datos son Julio, Santamaria ,942484848 devolveraàjulio_santamaria8@javamail.com
        */

        public void gerenarEmail()
        {

           // Guardar el email generado para el usuario u1 y mostrarlo después

            string email = $"El email generado  : {Nombre}_{Apellido}{Telefono.Substring(10, 10)}@javamail.com";
            Console.WriteLine(email);
        }

        /*
        Un método llamado ContieneLetra  que recibe como argumento una letra 
        y devuelve el número de veces que el Apellido contiene esa letra
        En el ejemplo anterior si le pasamos la letra ‘a’ devolvera a4
        */

        public int ContieneLetra (char letra)
        {


            return numeroletras;

        }



    }
}
