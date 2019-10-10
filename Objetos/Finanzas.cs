using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{

    //1. Realiza una clase Finanzas que convierta dólares a euros y viceversa.Codifica los métodos dolaresToEuros y eurosToDolares.

    //Prueba que dicha clase funciona correctamente haciendo conversiones entre euros y dólares.

    //La clase tiene que tener:

    // Un constructor Finanzas() por defecto, el cual establecerá el cambio Dólar-Euro en 0.92 .

    // Un constructor Finanzas(double), el cual permitirá configurar el cambio dólar-euro.


    class Finanzas
    {


        private double cambio;
        
      
        public Finanzas()

        {
            cambio = 0.92;
        }

        public Finanzas(double cambio)
        {
            this.cambio = cambio;
        }

      

        public double EurosToDolares(double euros)
        {

            return euros/ cambio;
        }
            public double DolaresToEuros(double dolares) {

         

             return dolares * cambio;
        }

        }
    }

