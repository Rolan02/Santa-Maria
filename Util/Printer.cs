using static System.Console;
namespace Maria_Micaela.Util
{
    // Las clases staticas no se pueden instanciar (funciona como un objeto)
    public static class Printer
    {
        public static void DibujarSeparacion(int size = 50){
            WriteLine(new string('=', size));
        }
        public static void IniciarTitulo(string titulo)
        {
            DibujarSeparacion(titulo.Length);
            WriteLine(titulo);
            DibujarSeparacion(titulo.Length);
        }

    }
    
}