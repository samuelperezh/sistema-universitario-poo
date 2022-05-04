using System;
using System.Collections.Generic;

namespace SistemaUniversitario
{
    class Semestre
    {
        private List<Estudiante> estudiantes = new List<Estudiante>();

        IReporte reporte = new ReporteTexto();

        public Semestre() { }

        internal List<Estudiante> Estudiantes { get => estudiantes; private set => estudiantes = value; }
    }
}
