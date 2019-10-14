using System;
using System.Collections.Generic;
using System.Text;

namespace Monedero
{
    class Monedero
    {
        public double Cantidad { get; set; }
​
        public Monedero(double cantidad)
        {
            Cantidad = cantidad;
        }
​
        public void MeterDinero(int dinero)
        {
            if (dinero > 0)
            {
                Cantidad += dinero;
            }
            else
            {
                Console.WriteLine("La cantidad no puede ser negativa ni 0.");
            }
        }
​
        public void SacarDinero(int dinero)
        {
            if (dinero > 0)
            {
                if (Cantidad >= dinero)
                {
                    Cantidad -= dinero;
                }
                else
                {
                    Console.WriteLine("No se puede sacar más dinero del que se dispone en el monedero.");
​
                }
            }
            else
            {
                Console.WriteLine("La cantidad no puede ser negativa ni 0.");
            }
        }
       
    }


}
