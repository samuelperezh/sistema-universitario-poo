namespace SistemaUniversitario
{
    class Calificacion
    {
        private float nota;
        private int porcentaje;
        private string descripcion;

        public Calificacion(float nota, int porcentaje, string descripcion)
        {
            this.Nota = nota;
            this.Porcentaje = porcentaje;
            this.Descripcion = descripcion;
        }

        public Calificacion(float nota, int porcentaje)
        {
            this.Nota = nota;
            this.Porcentaje = porcentaje;
            this.Descripcion = "No hay una descripción";
        }

        public float Nota { get => nota; protected set => nota = value; }
        public int Porcentaje { get => porcentaje; protected set => porcentaje = value; }
        public string Descripcion { get => descripcion; protected set => descripcion = value; }
    }
}
