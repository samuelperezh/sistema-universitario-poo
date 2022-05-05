namespace SistemaUniversitario
{
    class Intercambio : Estudiante
    {
        public Intercambio(string nombre) : base(nombre)
        {
            this.Valor_credito = 800000;
        }

        public override void VerificarAprobacion()
        {
            if (Matricula.Calificacion_final >= 3.5 && Matricula.Calificacion_final <= 5)
            {
                Aprobacion = "Aprobado";
            }
            else
            {
                Aprobacion = "Reprobado";
            }
        }
    }
}
