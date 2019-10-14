using System;
using System.Collections.Generic;
using System.Text;

namespace Alimentos
{
    class Alimentos
    {
        public string Nombre { get; set; }
        public double Grasas { get; set; }
        public double Hidratos { get; set; }

        public bool OrigenAnimal { get; set; }


        // Constructor sin argumentos
        public Alimentos()
        {


        }


        // Un constructor que inicializa los atributos con todos los valores pasados como argumentos

        public Alimentos(string nombre, double grasas, double hidratos, bool origenAnimal)
        {
            Nombre = nombre;
            Grasas = grasas;
            Hidratos = hidratos;
            OrigenAnimal = origenAnimal;
        }

        //●	Un método llamado EsDietetico que devuelve verdadero si  tiene menos de 12 de grasas y no es de origen animal.

        public bool EsDietetico()
        {
            if (Grasas < 12 && OrigenAnimal == false)
            {

                return true;
            }

            {
                return false;
            }

        }

        //Un método llamado ClaveA que devuelve la clave del alimento formada por las 
        //tres primeras letras en mayúsculas seguidas del nº de grasas. EN PROCESO

        public string ClaveA()
        {
            string acumular = "";
            for (int i = 0; i < Nombre.Length; i++) 

            {
                string acumular = Nombre.Substring(0, i);

            }

            return claveA;
        }

        //Un método llamado Calorías que recibe como argumento los gramos de alimento y devuelve las calorías 
        // correspondientes , sabiendo que:  Calorías=gramos* (grasas*5.3+hidratos*2.1)

        public double Calorias(int gramos)
        {

            double calorias = gramos * (Grasas * 5.3 + Hidratos * 2.1);

            return calorias;

        }


    }
}
