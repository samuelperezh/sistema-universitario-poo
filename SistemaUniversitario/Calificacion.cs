namespace SistemaUniversitario
{
    class Calificacion
    {
        private double nota;
        private double porcentaje;
        private string descripcion;

        public Calificacion(double nota, double porcentaje, string descripcion)
        {
            this.Nota = nota;
            this.Porcentaje = porcentaje;
            this.Descripcion = descripcion;
        }

        public Calificacion(double nota, double porcentaje)
        {
            this.Nota = nota;
            this.Porcentaje = porcentaje;
            this.Descripcion = "";
        }

        public double Nota { get => nota; protected set => nota = value; }
        public double Porcentaje { get => porcentaje; protected set => porcentaje = value; }
        public string Descripcion { get => descripcion; protected set => descripcion = value; }
    }
}
