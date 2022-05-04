namespace SistemaUniversitario
{
    class Calificacion
    {
        private double nota;
        private int porcentaje;
        private string descripcion;

        public Calificacion(double nota, int porcentaje, string descripcion)
        {
            this.Nota = nota;
            this.Porcentaje = porcentaje;
            this.Descripcion = descripcion;
        }

        public Calificacion(double nota, int porcentaje)
        {
            this.Nota = nota;
            this.Porcentaje = porcentaje;
            this.Descripcion = "No hay una descripción";
        }

        public double Nota { get => nota; protected set => nota = value; }
        public int Porcentaje { get => porcentaje; protected set => porcentaje = value; }
        public string Descripcion { get => descripcion; protected set => descripcion = value; }
    }
}
