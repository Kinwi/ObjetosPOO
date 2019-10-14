using System;
using System.Collections.Generic;
using System.Text;

namespace Cliente
{
    class Cliente
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

        public  int TipoContrato { get; set; }




        //Metodos

        // 1. Un constructor que inicializa los datos con los valores pasados como argumentos


        public Cliente(string nombre, string apellido, string telefono,int tipocontrato)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            TipoContrato = tipocontrato;


            /*
             a.-Añadir un atributo para almacenar el tipo de contrato

                Tipo de contrato:
                    Sólo Línea Telefónica fija
                    Linea + Internet
                    Linea+ Internet + linea móvil
                    Linea+ Internet + linea móvil + televisión por cable
             */

            switch (tipocontrato)

            {
                case 1:
                    Console.WriteLine("El tipo de contrato del cliente es -Solo Linea de Telefonia Fija-");
                    break;

                case 2:
                    Console.WriteLine("El tipo de contrato del cliente es -Linea + Internet-");
                    break;

                case 3:
                    Console.WriteLine("El tipo de contrato del cliente es - Linea+ Internet + linea móvil-");
                    break;

                case 4:
                    Console.WriteLine("El tipo de contrato del cliente es - Linea+ Internet + linea móvil + television por cable-");
                    break;

                case 5:
                    Console.WriteLine("El tipo de contrato introducido no existe");
                    break;
            }


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

        public int ContieneLetra(char letra)
        {


            return numeroletras;

        }


        public void CalculoPrecioContrato(int meses)
        {
            switch (TipoContrato)
            {

                case 1:
                    int precioMesLineaFija = 12;
                    int calculoTotalContrato = precioMesLineaFija * meses;
                    Console.WriteLine($"LLeva usted {meses} con la compañia y el precio al Mes es {precioMesLineaFija}  ");
                    Console.WriteLine($"La cantidad total a pagar por el precio del contrato es  {calculoTotalContrato} ");
                    break;

                case 2:
                    int precioMesLineaInternet= 22;
                    int calculoTotalContrato1 = precioMesLineaInternet * meses;
                    Console.WriteLine($"LLeva usted {meses} con la compañia y el precio al Mes es {precioMesLineaInternet}  ");
                    Console.WriteLine($"La cantidad total a pagar por el precio del contrato es  {calculoTotalContrato1} ");
                    break;

                case 3:
                    int precioMesLineaInternetLineaMovil = 30;
                    int calculoTotalContrato2 = precioMesLineaInternetLineaMovil * meses;
                    Console.WriteLine($"LLeva usted {meses} con la compañia y el precio al Mes es {precioMesLineaInternetLineaMovil}  ");
                    Console.WriteLine($"La cantidad total a pagar por el precio del contrato es  {calculoTotalContrato2} ");
                    break;

                case 4:

                    int precioMesLineaInternetLineaMovilTelevision = 38;
                    int calculoTotalContrato3 = precioMesLineaInternetLineaMovilTelevision * meses;
                    Console.WriteLine($"LLeva usted {meses} con la compañia y el precio al Mes es {precioMesLineaInternetLineaMovilTelevision}  ");
                    Console.WriteLine($"La cantidad total a pagar por el precio del contrato es  {calculoTotalContrato3} ");
                    break;
            }

        }


    }
}
