namespace Maria_Micaela.Entidades

{
    class Escuela 
    {

        public string Nombre { get; set; }
        public int Fundacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TiposEscuela{get; set;}
        public Curso[] Cursos{get; set;}




        // ------------igualacion por tuplas --------
        public Escuela(string nombre, int fundacion) =>(Nombre, Fundacion) = (nombre, fundacion);
        // ------------Puedes llamar a los parametros opcionales sin importar su orden ----------
        public Escuela(string nombre, int fundacion, TiposEscuela tiposEscuela, string pais = "", string ciudad = "")
         =>(Nombre, Fundacion, TiposEscuela, Pais, Ciudad ) = (nombre, fundacion, tiposEscuela, pais, ciudad);

        public override string ToString() => ($"Nombre: {Nombre}, Tipo: {TiposEscuela} \n Pais: {Pais}, Ciudad: {Ciudad}");       
    }
}