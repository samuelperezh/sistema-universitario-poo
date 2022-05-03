using System;
using System.Collections.Generic;

namespace SistemaUniversitario
{
    class Matricula
    {
        private double costo_matricula;
        private double calificacion_final;
        private string aprobacion;
        private List<MateriaMatriculada> materias_matriculadas = new List<MateriaMatriculada>();
        private Estudiante estudiante;

        public Matricula()
        {

        }

        public double Costo_matricula { get => costo_matricula; private set => costo_matricula = value; }
        public double Calificacion_final { get => calificacion_final; private set => calificacion_final = value; }
        internal List<MateriaMatriculada> Materias_matriculadas { get => materias_matriculadas; set => materias_matriculadas = value; }
        internal Estudiante Estudiante { get => estudiante; set => estudiante = value; }
        public string Aprobacion { get => aprobacion; set => aprobacion = value; }

        public void VerificarAprobacion(Estudiante est)
        {
            if (est.GetType() == typeof(Regular) || est.GetType() == typeof(Becado))
            {
                if (Calificacion_final >= 3 || Calificacion_final <= 5)
                {
                    est.Aprobacion = "Aprobado";
                }
                else
                {
                    est.Aprobacion = "Reprobado";
                }
            }
            else if (est.GetType() == typeof(Intercambio))
            {
                if (Calificacion_final >= 3.5 || Calificacion_final <= 5)
                {
                    est.Aprobacion = "Aprobado";
                }
                else
                {
                    est.Aprobacion = "Reprobado";
                }
            }
        }

        public double CalcularCostoMatricula(Estudiante est)
        {
            int total_creditos = 0;
            foreach (var item in materias_matriculadas)
            {
                total_creditos += item.Materia.Numero_creditos;
            }
            Costo_matricula = total_creditos * est.Valor_credito;
            return Costo_matricula;
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
