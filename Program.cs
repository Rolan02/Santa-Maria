using System;
using System.Collections.Generic;
using Maria_Micaela.Entidades;

namespace Maria_Micaela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("U.E. Santa Maria ",1994);
            escuela.Pais = "Bolivia";
            escuela.Ciudad = "Cochabamba";


            escuela.Cursos = new List<Curso>() {
                new Curso(){Nombre = "101" , Jornada = TiposJornada.Manana },
                new Curso(){Nombre = "201" , Jornada = TiposJornada.Manana},
                new Curso(){Nombre = "301" , Jornada = TiposJornada.Manana }
            };
            escuela.Cursos.Add(new Curso(){Nombre = "102" , Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso(){Nombre = "202" , Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso(){Nombre = "302" , Jornada = TiposJornada.Tarde });
            
            var importarCursos = new List<Curso>() {
                new Curso(){Nombre = "401" , Jornada = TiposJornada.Manana },
                new Curso(){Nombre = "501" , Jornada = TiposJornada.Manana},
                new Curso(){Nombre = "601" , Jornada = TiposJornada.Manana }
            };
            
            escuela.Cursos.AddRange(importarCursos);
            
            //Metodo para borrar un elemento usando Predicate
            escuela.Cursos.RemoveAll(Predicate);
            
            //Metodo para borrar un elemento usando delegados
            escuela.Cursos.RemoveAll(delegate (Curso cur){
                return cur.Nombre == "401";
            });
            
            //Metodo para borrar un elemento usando lambdas
            escuela.Cursos.RemoveAll(cur => cur.Nombre == "501");


            Console.WriteLine(escuela);
            Console.WriteLine(new string('=', 50));
            ImprimirCursosEscuela(escuela);
           
        }

        private static bool Predicate(Curso obj)
        {
            return obj.Nombre == "301";
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("Cursos de la escuela !");
            Console.WriteLine(new string('=', 50));

            // ? no va a verificar cursos salvo que la escuela sea diferente de null 
            if (escuela?.Cursos != null )
            {
                foreach (var curso in escuela.Cursos)
                {
               Console.WriteLine($"Nombre {curso.Nombre},Id {curso.Id}");
                }
            }

        }

        private static void ImprimirCursosConWhile(Curso[] arreglosCursos)
        {
            int contador = 0;
            while(contador < arreglosCursos.Length)
            {
                Console.WriteLine($"Nombre {arreglosCursos[contador].Nombre},Id {arreglosCursos[contador].Id}");
                contador++;
            }
        }
        private static void ImprimirCursosConFor(Curso[] arreglosCursos)
        {
            for (int i = 0; i < arreglosCursos.Length; i++)
            {
                Console.WriteLine($"Nombre {arreglosCursos[i].Nombre},Id {arreglosCursos[i].Id}");
            }
        }
        private static void ImprimirCursosConForEach(Curso[] arreglosCursos)
        {
            foreach (var curso in arreglosCursos)
            {
                Console.WriteLine($"Nombre {curso.Nombre},Id {curso.Id}");
            }
        }
    }
}
