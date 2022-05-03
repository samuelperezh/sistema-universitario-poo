namespace SistemaUniversitario
{
    class Intercambio : Estudiante
    {
        public Intercambio(string nombre) : base(nombre)
        {
        }

        protected override void VerificarAprobacion(Matricula matr)
        {
            matr.CalcularCalificacionFinal();
            if (matr.Calificacion_final >= 3.5 && matr.Calificacion_final <= 5)
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
