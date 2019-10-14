using System;
using System.Collections.Generic;
using System.Text;

namespace Alarma
{
    public class Alarma
    {
        public int Temperatura { get; set; }
        public bool Timbre { get; set; }
        public Alarma(int temperatura)
        {
            Temperatura = temperatura;
            Timbre = false;
        }
        public Alarma()
        {
        }
        public bool Comprueba()
        {
            if (Temperatura < 10 || Temperatura > 35)
            {
                Timbre = true;
            }
            return false;
        }
        public void Normaliza()
        {
            Temperatura = 25;
            Timbre = false;
        }
    }
    


}

