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

        public bool ComprobarBeca()
        {
            bool beca;
            if (Matricula.Calificacion_final >= 0 || Matricula.Calificacion_final < 4)
            {
                beca = false;
            }
            else
            {
                beca = true;
            }
            return beca;
        }
    }
}
