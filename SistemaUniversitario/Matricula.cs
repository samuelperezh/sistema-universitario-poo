using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUniversitario
{
    class Matricula
    {
        List<Materia> materias = new List<Materia>();

        public Matricula()
        {
        }

        internal List<Materia> Materias { get => materias; set => materias = value; }
    }
}
