using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    class Peso
    {


        private double peso;
        private string medida;


        public Peso(double peso,string medida) {

            this.peso = peso;
            this.medida = medida;
        }

       
        public double GetLibras(double peso) {
            double cambioALibra = 2.20462;
            return peso * cambioALibra;
        }


        public double GetLingotes(double peso)
        {
            double cambioALingote = 1.0;
            
            return peso * cambioALingote;
        }

        public int GetPeso(int peso,string medida)
        {

            return;
        }

        

    }
}
