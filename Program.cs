using System;
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

            Curso[] arreglosCursos = {
                new Curso(){Nombre = "101" },
                new Curso(){Nombre = "201" },
                new Curso(){Nombre = "301" },
            };

            Console.WriteLine(escuela);
            Console.WriteLine(new string('=', 50));
 
            ImprimirCursosConWhile(arreglosCursos);
            ImprimirCursosConFor(arreglosCursos);
            ImprimirCursosConForEach(arreglosCursos);
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
