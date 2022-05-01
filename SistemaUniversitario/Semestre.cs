using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUniversitario
{
    class Semestre
    {
        private DateTime fecha_inicio_clases;
        private List<Matricula> matriculas = new List<Matricula>();

        public Semestre()
        {

        }

        public DateTime Fecha_inicio_clases { get => fecha_inicio_clases; set => fecha_inicio_clases = value; }
        internal List<Matricula> Matriculas { get => matriculas; set => matriculas = value; }

        public void CerrarSemestre()
        {

        }
    }
}
