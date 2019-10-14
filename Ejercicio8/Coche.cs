using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio6
{
    class Coche
    {

        //6.Crea la clase coche con dos constructores. Uno no toma parámetros y el otro sí. Los dos constructores inicializarán los atributos marca y modelo de la clase.


        //Implementa métodos para obtener y establecer el valor de los atributos, así como un método para mostrar toda la información.


        //Crea dos objetos(cada objeto llama a un constructor distinto) y verifica que todo funciona correctamente.





        //Atributos

        //public string Marca { get; set; }
        //public string Modelo { get; set; }

        private string Marca;
        private string Modelo;

        // Constructores de Coche

        public Coche()
        {
            Marca = "Renault";
            Modelo = "Megane";



        }
        public Coche(string marca, string modelo) {

            this.Marca = marca;
            this.Modelo = modelo;


            // Getter y Setters para Modelo y Marca
        }


        public string GetMarca()

        {
            return Marca;
        }



        public void SetMarca(string marca)
        {
            this.Marca = marca;
        }



        public string GetModelo()

        {

            return Modelo;
        }



        public void SetModelo(string modelo)
        {
            this.Modelo = modelo;
        }

    
        public string mostrarInformacion()

        {
            string informacion = "Hola" + "este es tu coche" + Marca + "y este es el" + Modelo;

            return informacion;
        }

    }
}

