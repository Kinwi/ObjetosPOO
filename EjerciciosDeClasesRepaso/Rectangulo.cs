using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDeClasesRepaso
{
    class Rectangulo
    {
        // Cuando declaramos los atributos con pop estos son privados ( gey,set) mientras el metodo es publico.
        public int largo{ get; set; } 
        public int ancho { get; set; }

        // Constructor que permite declarar objetos sin argumentos
        public Rectangulo()
        {

        }

        // Cosntructor que permite declarar objetos con largo y ancho
        public Rectangulo(int largo, int ancho)
        {
            this.largo = largo;
            this.ancho = ancho;
        }


        public int Area(int largo, int ancho)

        {
           
            return largo * ancho;


        }

        public double Diagonal(int largo, int ancho)

        {
      

            return Math.Sqrt((largo * largo) + (ancho * ancho));
        }


    }
}
