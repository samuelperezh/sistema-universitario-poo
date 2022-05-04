namespace SistemaUniversitario
{
    class Intercambio : Estudiante
    {
        public Intercambio(string nombre) : base(nombre)
        {
            this.Valor_credito = 800000;
        }

        public override void VerificarAprobacion(Matricula matr)
        {
            matr.CalcularCalificacionFinal();
            if (matr.Calificacion_final >= 3.5 && matr.Calificacion_final <= 5)
            {
                this.Aprobacion = "Aprobado";
            }
            else
            {
                this.Aprobacion = "Reprobado";
            }
        }
    }
}
