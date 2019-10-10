using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioDiseñoClaseContacto
{
    class Contacto
    {


        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaNacimiento{ get; set; }

        


        // Constructor para instanciar un contacto con todos los datos

        public Contacto(string nombre, int telefono, DateTime fechanacimiento)
        {
            Nombre = nombre;
            Telefono = telefono;
            FechaNacimiento = fechanacimiento;
           

        }

        //Constructor para instanciar un contacto con nombre y fecha de nacimiento 
        // (Si la fecha no es correcta poner la fecha actual)

        public Contacto(string nombre, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;

            

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

    public Contacto (string nombre, int telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
            this.FechaNacimiento = DateTime.Now;
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
            Console.WriteLine("Los datos de c1 son " + Nombre + Telefono +  FechaNacimiento);
             

        }
     
}
