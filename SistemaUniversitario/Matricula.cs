using System;
using System.Collections.Generic;

namespace SistemaUniversitario
{
    class Matricula
    {
        private DateTime fecha_max_inscripcion;
        private DateTime fecha_max_cancelacion;
        private double valor_credito;
        private double costo_matricula;
        private Estudiante estudiante;
        private List<MateriaMatriculada> materias_matriculadas = new List<MateriaMatriculada>();

        public Matricula()
        {
        }

        public DateTime Fecha_max_inscripcion { get => fecha_max_inscripcion; set => fecha_max_inscripcion = value; }
        public DateTime Fecha_max_cancelacion { get => fecha_max_cancelacion; set => fecha_max_cancelacion = value; }
        public double Valor_credito { get => valor_credito; set => valor_credito = value; }
        internal Estudiante Estudiante { get => estudiante; set => estudiante = value; }
        internal List<MateriaMatriculada> Materias { get => materias_matriculadas; set => materias_matriculadas = value; }
        public double Costo_matricula { get => costo_matricula; set => costo_matricula = value; }

        public void CalcularCostoTotal()
        {
            costo_matricula = 

        }

        public void CancelarMateria(MateriaMatriculada materias)
        {

        }

        public void CalcularCalificacionSemestre()
        {

        }

    }
}
