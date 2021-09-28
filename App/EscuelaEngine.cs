using System.Collections.Generic;
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
            Escuela.Cursos = new List<Curso>() {
                new Curso(){Nombre = "101" , Jornada = TiposJornada.Manana },
                new Curso(){Nombre = "201" , Jornada = TiposJornada.Manana},
                new Curso(){Nombre = "301" , Jornada = TiposJornada.Manana },
                new Curso(){Nombre = "401" , Jornada = TiposJornada.Manana },
                new Curso(){Nombre = "501" , Jornada = TiposJornada.Manana},
            };
        }
    }
}