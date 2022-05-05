namespace SistemaUniversitario
{
    class Becado : Estudiante
    {
        private bool conserva_beca;
        public Becado(string nombre) : base(nombre)
        {
            this.Valor_credito = 574000;
        }

        public bool Conserva_beca { get => conserva_beca; private set => conserva_beca = value; }

        public void ComprobarBeca()
        {
            if (Matricula.Calificacion_final >= 0 || Matricula.Calificacion_final < 4)
            {
                Conserva_beca = false;
            }
            else
            {
                Conserva_beca = true;
            }
        }
    }
}
