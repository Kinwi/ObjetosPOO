using Ejercicio6;
using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {

            Coche c1 = new Coche("Citroen", "C5");
            Coche c2 = new Coche("Renault", "Clio");
            Coche c3 = new Coche();
            //c3.Marca = "Porsche";
            //c3.Modelo = "Carrera";
            c1.mostrarInformacion();
            c2.mostrarInformacion();
            c3.mostrarInformacion();
​
            Consumo co1 = new Consumo(2000, 100, 105, "Diesel");
            Consumo co2 = new Consumo(3000, 150, 100, "Diesel");
            Consumo co3 = new Consumo(3500, 350, 120, "Gasolina");
​
            Console.WriteLine($"{c1.GetMarca()}  { c1.GetModelo()} ha tardado {co1.GetTiempo()} y ha consumido {co1.ConsumoMedio()} litros/100 km");

        }
    }
}
