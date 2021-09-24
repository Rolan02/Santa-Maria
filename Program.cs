using System;
using Maria_Micaela.Entidades;

namespace Maria_Micaela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("U.E. Santa Maria ",1994);
            
            Console.WriteLine("La mejor escuela es la " + escuela.Nombre + "fundado en el ano " + escuela.Fundacion);
        }
    }
}
