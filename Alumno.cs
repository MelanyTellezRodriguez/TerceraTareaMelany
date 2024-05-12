using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceraTareaMelany
{
    //Definicion de la clase alumno
    public partial class Alumno
    {

        //Propiedades principales del alumno
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carnet { get; set; }
        public Carreras carrera { get; set; }
        public List<double> Calificaciones { get; set; }

        //Propiedades principales del alumno

        //Constructor para inicializar las propiedades del alumno

        public Alumno(string nombre, int edad, Carreras carrera, string carnet, List<double> calificaciones)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.carrera = carrera;
            this.Carnet = carnet;
            Calificaciones = new List<double>(calificaciones);




        }






        //Metodo par calcular el promedio de calificaciones del alumno

        public double CalcularPromedioCalificaciones()
        {
            if (Calificaciones.Count == 0)
            {
                return 0; //Si no hay calificaciones el promedio es igual a cero

            }
            double sumaCalificaciones = 0;
            foreach (var calificacion in Calificaciones)
            {
                sumaCalificaciones += calificacion;


            }
            return sumaCalificaciones / Calificaciones.Count;

        }

        //Metodo para determinar si el alumno aprobó ( promedio >= 60) o reprobó (promedio < 60)

        public string EstadoAprobacion()
        {
            double promedio = CalcularPromedioCalificaciones();
            if (promedio >= 60)
            {
                return "Aprobado";
            }
            else
            {
                return "Reprobado";
            }
        }

        //Metodo para asignar y obtener el numero de carnet del alumno


        public enum Carreras
        {
            Ingenieria_de_Sistemas,
            Ingeniria_en_Computacion,
            Telecomunicaciones,
            Ingenieria_Electronica,
            Ingenieria_Industrial,


        }
    }
}
