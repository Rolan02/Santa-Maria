using System;
using System.Collections.Generic;

namespace Maria_Micaela.Entidades
{
    public class Curso
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }
        public Curso() => Id = Guid.NewGuid().ToString();
    }
}