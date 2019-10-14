using System;
using System.Collections.Generic;
using System.Text;

namespace RectanguloUltimoEjercicio
{
    class Rectangulo
    {

        public int Largo { get; set; }
        public int Ancho { get; set; }

        /*
        ---------------------------------------------CONSTRUCTORES-----------------------------------------------------
        Un constructor sin argumentos que pide el largo y el ancho por teclado y 
        un constructor que inicializa el largo y el ancho con los valores pasados como argumentos.
        */


        public Rectangulo()
        {


        }

        public Rectangulo(int largo, int ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }
    }
}
