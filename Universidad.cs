using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceraTareaMelany
{
    public partial class Universidad
    {

        //Lista de alumnos
        private List<Alumno> listaAlumnos = new List<Alumno>();

        //Constructor para inicializar la lista de alumnos

        public Universidad()
        {
            listaAlumnos = new List<Alumno>();

        }

        //Metodo estatico par agregar un nuevo alumno a la lista

        public void AgregarAlumno(Alumno alumno)
        {
            listaAlumnos.Add(alumno);

        }

        //Metodo estatico para mostrar la lista de alumnos con detalles

        public List<Alumno> ObtenerListaAlumnos()
        {
            return listaAlumnos;

        }
    }
}
