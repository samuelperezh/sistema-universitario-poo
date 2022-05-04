using System;
using System.Collections.Generic;

namespace SistemaUniversitario
{
    class Matricula
    {
        private double costo_matricula;
        private double calificacion_final;
        private double total_creditos;
        private List<MateriaMatriculada> materias_matriculadas = new List<MateriaMatriculada>();

        public Matricula(Estudiante est)
        {
            this.Costo_matricula = CalcularCostoMatricula(est);
            this.Calificacion_final = CalcularCalificacionFinal();
            this.Total_creditos = CalcularCreditos();
        }

        public double Costo_matricula { get => costo_matricula; private set => costo_matricula = value; }
        public double Calificacion_final { get => calificacion_final; private set => calificacion_final = value; }
        public double Total_creditos { get => total_creditos; private set => total_creditos = value; }
        internal List<MateriaMatriculada> Materias_matriculadas { get => materias_matriculadas; set => materias_matriculadas = value; }

        public void MatricularMaterias(Materia materia)
        {
            materias_matriculadas.Add(new MateriaMatriculada(materia));
        }

        public void CancelarMaterias(MateriaMatriculada materia)
        {
            materia.Estado = "Cancelada";
        }

        public int CalcularCreditos()
        {
            int creditos = 0;
            foreach (var item in materias_matriculadas)
            {
                creditos += item.Numero_creditos;
            }
            return creditos;
        }
        public double CalcularCostoMatricula(Estudiante est)
        {
            double costo = 0;
            int creditos = CalcularCreditos();
            if (est is Regular || est is Intercambio)
            {
                costo = creditos * est.Valor_credito;
            }
            else if (est is Becado)
            {
                costo = (creditos * est.Valor_credito) - ((creditos * est.Valor_credito)*0.1);
            }
            else
            {
                Console.WriteLine("Error");
            }
            return costo;
        }

        public double CalcularCalificacionFinal()
        {
            int creditos = CalcularCreditos();
            double ponderacion = 0;
            double final;
            foreach (var item in materias_matriculadas)
            {
                ponderacion += item.Numero_creditos * item.Calificacion_final;
            }
            final = ponderacion / creditos;
            return final;
        }
    }
}
