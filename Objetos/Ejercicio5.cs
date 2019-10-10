using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    class Conversion
    {


        //5. Crea una clase con un método MillasAMetros() que toma como parámetro de entrada un valor en millas marinas y las convierte a metros.
        //Una vez tengas este método escribe otro MillasAKilometros() que realice la misma conversión, pero esta vez exprese el resultado en kilómetros.
        //Nota: 1 milla marina equivale a 1852 metros.


        private int conversion;

        public Conversion()
        {
            conversion = 1852;
        }



        public void MillasAMetros(double millas)
        {
            double MillasAMetros = millas * conversion;
            Console.WriteLine("La conversion de millas marinas a metros sera " + MillasAMetros);
            


        }


        public void MillasAKilometros(double millas)
        {

            double kilometros = (millas * conversion) / 1000;
            Console.WriteLine("La conversion de millas a kilometros es " + kilometros);
        

        }

        // Getters y Setters

        public double GetConversion()

        {
            return conversion;
        }


        public void SetNumero(int conversion)
        {
            this.conversion = conversion;
        }

    }
}
