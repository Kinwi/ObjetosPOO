using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
       // 3. Dada la clase satelite:

         public class Satelite
         {
        private double meridiano;
        private double paralelo;
        private double distancia_tierra;

        public Satelite(double m, double p, double d)
        {
            meridiano = m;
            paralelo = p;
            distancia_tierra = d;
        }

        public Satelite()
        {
            meridiano = paralelo = distancia_tierra = 0;
        }


        public void SetPosicion(double m, double p, double d)
        {
            meridiano = m;
            paralelo = p;
            distancia_tierra = d;
        }
        public void PrintPosicion()
        {
            //Console.WriteLine("El satélite se encuentra en el paralelo " + paralelo + "

            //Meridiano "+meridiano+" a una distancia de la tierra de "+distancia_tierra+"

            //Kilómetros");

            Console.ReadLine();
        }

        public void VariaAltura(double desplazamiento)
        {

            if (desplazamiento > 0)
            {
                this.distancia_tierra += desplazamiento;
                Console.WriteLine("$El desplazamiento fue de {desplazamiento}");

            }

            else
            {
                this.distancia_tierra -= desplazamiento;
                Console.WriteLine("$El desplazamiento fue de {desplazamiento}");

            }

        }

        public bool EnOrbita()
        {
            if (this.distancia_tierra <=0)
            {

                return false ;
            }
            else
            {
                return true;
            }
        }


        public void VariaPosicion(double variap, double variam)
        {
            this.meridiano = variap;
            this.paralelo = variam;

            Console.WriteLine("$La posicion del satelite es {variap} paralelo y {variap} meridiano");
        }
    }


}
