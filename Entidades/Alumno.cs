using System;

namespace Maria_Micaela.Entidades
{
    public class Alumno
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public Alumno() => Id = Guid.NewGuid().ToString();
    }
}