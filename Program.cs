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

            var curso1 = new Curso(){
                Nombre = "101"
            };
            var curso2 = new Curso(){
                Nombre = "201"
            };
            var curso3 = new Curso(){
                Nombre = "301"
            };

            Console.WriteLine(escuela);
            Console.WriteLine(new string('=', 50));
            Console.WriteLine(curso1.Nombre + "," + curso1.Id);
            Console.WriteLine(curso2.Nombre + "," + curso2.Id);
            Console.WriteLine($"{curso3.Nombre} , {curso3.Id}");

            
        }

        
    }
}
