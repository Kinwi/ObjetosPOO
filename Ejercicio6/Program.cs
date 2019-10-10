using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.Crea la clase coche con dos constructores. Uno no toma parámetros y el otro sí. Los dos constructores inicializarán los atributos marca y modelo de la clase.


            //Implementa métodos para obtener y establecer el valor de los atributos, así como un método para mostrar toda la información.


            //Crea dos objetos(cada objeto llama a un constructor distinto) y verifica que todo funciona correctamente.




            //CREO DOS OBJETOS COCHE PARA VERIFICAR QUE EL COMPORTAMIENTO DEL CONSTRUCTOR ES DISTINTO


            Coche coche1 = new Coche();
            Coche coche2 = new Coche("Porsche", "Carrera");


            //Console.WriteLine(coche1.GetMarca());
            //Console.WriteLine(coche1.GetModelo());

            //Console.WriteLine(coche2.GetMarca());
            //Console.WriteLine(coche2.GetModelo());



            coche1.SetMarca("Citroen");
            coche1.SetModelo("ZX");

            coche2.SetMarca("Renault");
            coche2.SetModelo("Kangoo");

            Console.WriteLine( coche1.mostrarInformacion());




        }
    }
}
