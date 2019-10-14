using System;
using System.Collections.Generic;
using System.Text;

namespace Hipoteca
{
    class Hipoteca
    {

        public int Capital { get; set; }
        public double Redito{ get; set; }

        public int Tiempo { get; set; }


        // Un constructor que inicialize los atributos con los valores pasados como argumentos

          
        public Hipoteca(int capital, double redito, int tiempo)
        {
            Capital = capital;
            Redito = redito;
            Tiempo = tiempo;
        }

        //Un método llamado cuota que devuelve la cuota a pagar ( i=c*r*t/100)

        public double Cuota()
        {

            double cuota = Capital * Redito * Tiempo;
            Tiempo = Tiempo + 1;

            return cuota;

        }

        //Un método que muestre todos los atributos.
        public void MostrarAtributos()
        {

            Console.WriteLine($"Los atributos de la clase son : Capital   {Capital}    Redito   {Redito}    Tiempo  {Tiempo}");

        }



    }
}
