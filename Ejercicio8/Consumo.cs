using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    class Consumo
    {
        public double Kilometros { get; set; }
        public double Litros { get; set; }
        public double VMed { get; set; }
        public string TipoCombustible { get; set; }
        public Consumo(double kilometros, double litros, double vMed, string tipoCombustible)
        {
            Kilometros = kilometros;
            Litros = litros;
            VMed = vMed;
            TipoCombustible = tipoCombustible;
        }
        public Consumo()
        {
        }
        public string GetTiempo()
        {
            double horas = Kilometros / VMed;
            int segundos = Convert.ToInt32(horas * 3600);
            int h = segundos / 3600;
            int m = (segundos % 3600) / 60;
            int s = (segundos % 3600) % 60;
            return $"{h} h {m} m {s} s";
        }
        public double ConsumoMedio()

        {

            return (Litros / Kilometros) * 100;
        }

        public void MostrarDatos()

        {

            Console.WriteLine($"Kilometros realizados :{Kilometros}\n" +
                $"Litros consumidos :{Litros}\n" +
                 $"Velocidad Media :{VMed}\n" +
                  $"Tipo Combustible :{TipoCombustible} \n +
                    



        }
    }
}
