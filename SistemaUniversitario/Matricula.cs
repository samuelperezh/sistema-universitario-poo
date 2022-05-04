using System;
using System.Collections.Generic;

namespace SistemaUniversitario
{
    class Matricula
    {
        private double costo_matricula;
        private double calificacion_final;
        private List<MateriaMatriculada> materias_matriculadas = new List<MateriaMatriculada>();
        private Estudiante estudiante;

        public Matricula(Estudiante est)
        {
            this.Estudiante = est;
        }

        public double Costo_matricula { get => costo_matricula; private set => costo_matricula = value; }
        public double Calificacion_final { get => calificacion_final; private set => calificacion_final = value; }
        internal List<MateriaMatriculada> Materias_matriculadas { get => materias_matriculadas; set => materias_matriculadas = value; }
        internal Estudiante Estudiante { get => estudiante; set => estudiante = value; }

        public double CalcularCostoMatricula(Estudiante est)
        {
            int total_creditos = 0;
            foreach (var item in materias_matriculadas)
            {
                total_creditos += item.Materia.Numero_creditos;
            }
            if (est is Regular || est is Intercambio)
            {
                Costo_matricula = total_creditos * est.Valor_credito;
            }
            else if (est is Becado)
            {
                Costo_matricula = (total_creditos * est.Valor_credito) - ((total_creditos * est.Valor_credito)*0.1);
            }
            else
            {
                Costo_matricula = 0;
            }
            return Costo_matricula;
        }

        public void DescontarMatricula(Estudiante est)
        {

        }

        public void CancelarMateria(MateriaMatriculada materia)
        {
            materias_matriculadas.Remove(materia);
            materia.Estado = "Cancelada";
        }

        public double CalcularCalificacionFinal()
        {
            int total_creditos = 0;
            foreach (var item in materias_matriculadas)
            {
                total_creditos += item.Materia.Numero_creditos;
            }
            double ponderacion = 0;
            foreach (var item in materias_matriculadas)
            {
                ponderacion += item.Materia.Numero_creditos * item.Calificacion_final;
            }
            Calificacion_final = ponderacion / total_creditos;
            return Calificacion_final;
        }

    }
}
