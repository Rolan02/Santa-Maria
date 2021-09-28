using System;
using System.Collections.Generic;
using System.Linq;
using Maria_Micaela.Entidades;

namespace Maria_Micaela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
        {


        }
        public void Inicializar()
        {
            Escuela = new Escuela("U.E. Santa Maria ", 1994, TiposEscuela.Primaria, ciudad: "Cochabamba", pais: "Bolivia");

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);
                        for (var i = 0; i < 5; i++)
                        {
                            var ev = new Evaluaciones
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} Ev#{i+1}",
                                Nota = (float)(5 * rnd.NextDouble()),
                                Alumno = alumno
                            };
                            alumno.Evaluaciones.Add(ev);
                        }
                    }

                }
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura{Nombre = "Matematicas"},
                    new Asignatura{Nombre = "Ingles"},
                    new Asignatura{Nombre = "Lenguaje"},
                    new Asignatura{Nombre = "Educacion Fisica"},
                    new Asignatura{Nombre = "Sociales"},
                };
                curso.Asignaturas = (listaAsignaturas);
            }
        }

        private List<Alumno> GenerarAlumnosAzar(int cantidad)
        {
            string[] nombre = { "rolando", "daniel", "carlos", "rodrigo" };
            string[] nombre2 = { "fulanito", "Alambrito", "Zoquete", "Melendi" };
            string[] apellido = { "quispe", "mamani", "salas", "mendiza" };
            //Lenguaje integrado de consultas =  Linq
            var listaAlumnos = from n1 in nombre
                               from n2 in nombre2
                               from a1 in apellido
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };
            return listaAlumnos.OrderBy(al => al.Id).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>() {
                new Curso(){Nombre = "101" , Jornada = TiposJornada.Manana },
                new Curso(){Nombre = "201" , Jornada = TiposJornada.Manana},
                new Curso(){Nombre = "301" , Jornada = TiposJornada.Manana },
                new Curso(){Nombre = "401" , Jornada = TiposJornada.Manana },
                new Curso(){Nombre = "501" , Jornada = TiposJornada.Manana},
            };
            Random rnd = new Random();
            foreach (var cusos in Escuela.Cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                cusos.Alumnos = GenerarAlumnosAzar(cantRandom);
            }
        }
    }
}