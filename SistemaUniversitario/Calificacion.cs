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
            //En el constructor no se puede ingresar una nota mayor a 5 ni menor que 0 (en el program).
            this.Porcentaje = porcentaje;
            this.Descripcion = descripcion;
        }

        public double Nota { get => nota; protected set => nota = value; }
        public double Porcentaje { get => porcentaje; protected set => porcentaje = value; }
        public string Descripcion { get => descripcion; protected set => descripcion = value; }
    }
}
