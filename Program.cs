using System;
using System.Collections.Generic;
using Maria_Micaela.Entidades;
using Maria_Micaela.Util;

namespace Maria_Micaela
{
    class Program
    {
        static void Main(string[] args)
        {
            EscuelaEngine engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.IniciarTitulo("Bienvenidos a la U.E. Santa Maria Micaela");
            ImprimirCursosEscuela(engine.Escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.IniciarTitulo("Cursos de la escuela !");

            // ? no va a verificar cursos salvo que la escuela sea diferente de null 
            if (escuela?.Cursos != null )
            {
                foreach (var curso in escuela.Cursos)
                {
               Console.WriteLine($"Nombre {curso.Nombre},Id {curso.Id}");
                }
            }
        }
    }
}
