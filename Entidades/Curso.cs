using System;
namespace Maria_Micaela.Entidades
{
    public class Curso
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public Curso() => Id = Guid.NewGuid().ToString();
    }
}