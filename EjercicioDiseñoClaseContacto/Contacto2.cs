using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDiseñoClaseContacto
{
    class Contacto2
    {
        //  Añade a la clase los siguientes Atributos

        // NumeroContactosCreados

        // TipoContacto

        // NumeroFamiliares

        // NumerosAmigos

        // NumeroCompañerosTrabajo

        // NumeroCompañerosEstudio

        public string Nombre { get; set; }

        public int Telefono { get; set; }

        public DateTime FechaNacimiento{ get; set; }


        public string TipoContacto{ get; set; }





        // Constructor para instanciar un contacto con todos los datos

        public Contacto2(string nombre, int telefono, DateTime fechanacimiento, string tipocontacto)
        {
            Nombre = nombre;
            Telefono = telefono;
            FechaNacimiento = fechanacimiento;
            TipoContacto = tipocontacto;


            switch (tipocontacto)
            {
                case "Familia":
                    Console.WriteLine("Eres del Grupo Familia");
                    break;

                case "Amigos":
                    Console.WriteLine("Eres del Grupo Amigos");
                    break;

                case "Trabajos":
                    Console.WriteLine("Eres del Grupo Trabajos");
                    break;

                case "Estudios":
                    Console.WriteLine("Eres del Grupo Estudios");
                    break;
                default:
                    Console.WriteLine("Se te ha asignado por defecto el Grupo Amigos");
                    break;

            }
        }

        //Constructor para instanciar un contacto con nombre y fecha de nacimiento 
        // (Si la fecha no es correcta poner la fecha actual)

        public Contacto2(string nombre, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            this.TipoContacto = "Amigos";

            

            if (fechaNacimiento.Year > 1920 && fechaNacimiento < DateTime.Today)

            {
                FechaNacimiento = fechaNacimiento;
            }

            else
            {
                FechaNacimiento = DateTime.Today;

            }
        }
      



    // Constructor para instanciar un contacto con nombre y telefono
    // (La fecha de nacimiento se inicializa con la actual)

    public Contacto2 (string nombre, int telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
            this.FechaNacimiento = DateTime.Now;
            this.TipoContacto = "Amigos";
        }



        // METODOS A IMPLEMENTAR

        //public void CambiarNombre(string nombre)
        //{
        //    this.Nombre = nombre;

        //}

        //public string DevolverNombre()
        //{

        //    return Nombre;
        //}


        //public void CambiarTel(int telefono)
        //{
        //    this.Telefono = telefono;
        //}


        //public int DevolverTel()
        //{
        //    return Telefono;
        //}

        //public void MostrarDatosContacto()

        //{

        //}

        public void MostrarDatos()

        {
            //Console.WriteLine($"Nombre :{nombre})

        }

       
    }
}
