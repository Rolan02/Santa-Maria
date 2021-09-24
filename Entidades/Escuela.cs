namespace Maria_Micaela.Entidades

{
    class Escuela 
    {

        public string Nombre { get; set; }
        public int Fundacion { get; set; }
        public string Pais { get; set; }
        public int Ciudad { get; set; }

        // ------------igualacion por tuplas --------
        public Escuela(string nombre, int fundacion) =>(Nombre, Fundacion) = (nombre, fundacion);

        
    }
}