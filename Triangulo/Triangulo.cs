using System;
using System.Collections.Generic;
using System.Text;

namespace Triangulo
{
    class Triangulo
    {

        public int lado1 { get; set; }
        public int lado2 { get; set; }
        public int lado3 { get; set; }

        public Triangulo(int lado1, int lado2, int lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }


        public bool EsEquilatero()
        {
            bool respuesta = true;

            if (lado1 ==lado2 && lado2 == lado3)
            {

                respuesta = true;
            }

            else
            {
                respuesta = false;
            }

            return respuesta;
        }




        public bool EsIsosceles()

        {
            bool respuesta = true;
            if (lado1 == lado2 || lado1 == lado2 || lado2 == lado3)


            {

                respuesta = true;
            }

            else
            {
                respuesta = false;
            }

            return respuesta;

        }

        public bool EsEscaleno()
        {
            bool respuesta = true;

            if (lado1 != lado2 && lado1 != lado2 && lado2 != lado3)

            {

                respuesta = true;
            }

            else
            {
                respuesta = false;
            }

            return respuesta;


        }

        public int perimetroTriangulo()
        {


            return lado1 + lado2 + lado3;
        }
    }
}
