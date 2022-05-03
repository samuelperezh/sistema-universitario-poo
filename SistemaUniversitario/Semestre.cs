using System;
using System.Collections.Generic;

namespace SistemaUniversitario
{
    class Semestre
    {
        private List<Matricula> matriculas = new List<Matricula>();

        public Semestre()
        {
        }

        internal List<Matricula> Matriculas { get => matriculas; private set => matriculas = value; }

    public void CerrarSemestre()
        {

        }
    }
}
