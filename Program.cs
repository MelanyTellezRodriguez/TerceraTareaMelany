using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceraTareaMelany
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Universidad uni = new Universidad();


            Alumno alumno1 = new Alumno("Jose Rafel Perez Nuñez", 19, Alumno.Carreras.Ingenieria_de_Sistemas, "JRPN1234", new List<double> { 50, 60, 50, 70, 45, 67 });
            Alumno alumno2 = new Alumno("Cristel Junieth Mendieta Galan", 19, Alumno.Carreras.Ingenieria_Industrial, "CJMG5678", new List<double> { 60, 70, 90, 85, 69, 74 });
            Alumno alumno3 = new Alumno("Maria Gabriela Gaitan Murillo", 19, Alumno.Carreras.Telecomunicaciones, "MGGM9101", new List<double> { 78, 89, 65, 70, 89, 68 });

            //Agregar a la lista alumno
            uni.AgregarAlumno(alumno1);
            uni.AgregarAlumno(alumno2);
            uni.AgregarAlumno(alumno3);

            //para mostrar los detalles de cada uno de los alumnos


            foreach (var alumno in uni.ObtenerListaAlumnos())
            {
                Console.WriteLine();
                Console.WriteLine("::::SISTEMA DE REGISTRO DE ALUMNOS::::");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Nombre: " + alumno.Nombre);
                Console.WriteLine("Edad:" + alumno.Edad);
                Console.WriteLine("Carrera:" + alumno.carrera);
                Console.WriteLine("Carnet:" + alumno.Carnet);
                //Quise imprimir cada una de las calificaciones de los alumnos pero no pude 
                Console.WriteLine("Promedio del alumno:" + alumno.CalcularPromedioCalificaciones());
                Console.WriteLine("Estado de aprobacion: " + alumno.EstadoAprobacion());



            }
        }
    }
}
