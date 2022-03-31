using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUniversitario
{
    class Calificacion
    {
        private double nota;
        private double porcentaje;

        public Calificacion()
        {
        }

        public double Nota { get => nota; set => nota = value; }
        public double Porcentaje { get => porcentaje; set => porcentaje = value; }
    }
}
