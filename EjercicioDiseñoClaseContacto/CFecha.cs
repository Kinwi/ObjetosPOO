using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDiseñoClaseContacto
{
    class CFecha
    {
        private DateTime fecha;

        public CFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }


        public int DevolverDia(DateTime fecha)
        {
            
            return fecha.Day;
        }


        public int DevolverMes(DateTime fecha)
        {
            return fecha.Month;

        }

        public int DevolverAño(DateTime fecha)
        {

            return fecha.Year;
        }


        public int ObtenerEdad()

        {
            TimeSpan timeSpan = DateTime.Now - fecha;

            return timeSpan.Days / 365;

            //int añoFechaNacimiento =FechaNacimiento.Year;
            //int añoActual = DateTime.Now.Year;
            //Console.WriteLine("La edad actual de la persona " + (añoActual - añoFechaNacimiento));
        }

        public void Felicitar()
        {
            Console.WriteLine($"Felicidades hoy cumples{ObtenerEdad()} años");
        }
    }
}
