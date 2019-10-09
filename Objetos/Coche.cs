using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    class Coche
    {
        private string marca;
        private string modelo;
        private string color;
        private int caballos;
        private int puertas;


        // Constructor

        // this ---- Hace referencia al atributo no al parametro

        public Coche(string marca, string modelo, string color, int caballos, int puertas)

        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.caballos = caballos;
            this.puertas = puertas;
        }
        // Constructor

            public Coche()
            {
                marca = "Porsche";
                modelo= "Carrera";
                color= "Rojo";
                caballos = 120;
                puertas = 5;


            }

        // getters y setters
        // Getter --- Acceder al valor
        // Setter ---Modificar valor

        public string GetMarca()

        {
            return marca;
        }

        // Set al no devolver nada es Void
        public void SetMarca(string marca)
        {
            this.marca = marca;

        }


        public string GetModelo()

        {
            return modelo;
        }

        // Set al no devolver nada es Void
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;

        }


        public string GetColor()

        {
            return color;
        }

        // Set al no devolver nada es Void
        public void SetColor(string color)
        {
            this.color = color;

        }

        public int GetCaballos()

        {
            return caballos;
        }

        // Set al no devolver nada es Void
        public void SetCaballos(int caballos)
        {
            this.caballos = caballos;

        }


        public int GetPuertas()

        {
            return caballos;
        }

        // Set al no devolver nada es Void
        public void SetPuertas(int puertas)
        {
            this.puertas = puertas;

        }

        // Metodos
        public void Arrancar()
        {

            Console.WriteLine("$El coche {marca} {modelo}ha arrancado");


        }
    }
}
 