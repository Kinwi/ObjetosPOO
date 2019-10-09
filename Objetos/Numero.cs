using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    //2. Realiza una clase número que almacene un número entero y tenga las siguientes características:
    //  Constructor por defecto que inicializa a 0 el número interno.
    //  Constructor que inicializa el número interno(pasado por parámetro).
    //  Método Aniade que permite sumarle un número al valor interno(++).
    //  Método Resta que resta un número al valor interno(--).
    //  Método GetValor.Devuelve el valor interno.
    //  Método GetDoble. Devuelve el doble del valor interno.
    //  Método GetTriple. Devuelve el triple del valor interno.
    //  Método SetNumero. Inicializa de nuevo el valor interno.

    class Numero

    {
        private int numero;


        public Numero()
        {
            numero = 0;

        }

        public Numero(int numero)
        {
            this.numero = numero;

        }

        public void Aniade()
        {
            
            numero++;
        }


        public void Resta()
        {
           
            numero--;
        }


        public int GetNumero()
        {

            return numero;
        }

        public int GetDoble()
        {
            return numero * 2;
        }

        public int GetTriple()
        {
            return numero * 3;
        }

        public void SetNumero(int numero)
        {
            this.numero = numero;
        }
    }
}
