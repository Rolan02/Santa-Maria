using System;

namespace Maria_Micaela.Entidades
{
    public class Asignatura
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public Asignatura() => Id = Guid.NewGuid().ToString();
    }
}