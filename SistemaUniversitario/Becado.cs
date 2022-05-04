namespace SistemaUniversitario
{
    class Becado : Estudiante
    {
        private bool conserva_beca;
        public Becado(string nombre) : base(nombre)
        {
            this.Valor_credito = 574000;
            this.Conserva_beca = true;
        }

        public bool Conserva_beca { get => conserva_beca; private set => conserva_beca = value; }

        public bool ComprobarBeca(Matricula matr)
        {
            if (matr.Calificacion_final < 4 && matr.Calificacion_final >= 0)
            {
                Conserva_beca = false;
            }
            else
            {
                Conserva_beca = true;
            }
            return Conserva_beca;
        }
    }
}
