using System;
using System.Collections.Generic;

namespace SistemaUniversitario
{
    class Matricula
    {
        private double costo_matricula;
        private double calificacion_final;
        private int total_creditos;
        private List<MateriaMatriculada> materias_matriculadas = new List<MateriaMatriculada>();

        public Matricula(Estudiante est)
        {
            CalcularCreditos();
            CalcularCostoMatricula(est);
            CalcularCalificacionFinal();
        }

        public double Costo_matricula { get => costo_matricula; private set => costo_matricula = value; }
        public double Calificacion_final { get => calificacion_final; private set => calificacion_final = value; }
        public int Total_creditos { get => total_creditos; private set => total_creditos = value; }
        internal List<MateriaMatriculada> Materias_matriculadas { get => materias_matriculadas; set => materias_matriculadas = value; }

        public void MatricularMaterias(Materia materia, Estudiante est)
        {
            CalcularCreditos();
            if (Materias_matriculadas.Find(a => a.Materia == materia) == null)
            {
                if (est is Regular || est is Becado)
                {
                    int creditos = Total_creditos + materia.Numero_creditos;
                    if (creditos <= 17)
                    {
                        Materias_matriculadas.Add(new MateriaMatriculada(materia));
                    }
                    else
                    {
                        Console.WriteLine("¡Error! Los estudiantes becados y regulares pueden inscribir un máximo de 17 créditos");
                    }
                }
                else if (est is Intercambio)
                {
                    int creditos = Total_creditos + materia.Numero_creditos;
                    if (creditos <= 12)
                    {
                        Materias_matriculadas.Add(new MateriaMatriculada(materia));
                    }
                    else
                    {
                        Console.WriteLine("¡Error! Los estudiantes de intercambio pueden inscribir un máximo de 12 créditos");
                    }
                }
            }
            else
            {
                Console.WriteLine("¡Error! La materia ya se encuentra matriculada");
            }
        }

        public void CancelarMaterias(MateriaMatriculada materia)
        {
            materia.Estado = "Cancelada";
        }

        public void CalcularCreditos()
        {
            Total_creditos = 0;
            foreach (var item in materias_matriculadas)
            {
                Total_creditos += item.Numero_creditos;
            }
        }

        public void CalcularCostoMatricula(Estudiante est)
        {
            CalcularCreditos();
            if (est is Regular || est is Intercambio)
            {
                Costo_matricula = Total_creditos * est.Valor_credito;
            }
            else if (est is Becado)
            {
                Costo_matricula = (Total_creditos * est.Valor_credito) - ((Total_creditos * est.Valor_credito) * 0.1);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public void CalcularCalificacionFinal()
        {
            CalcularCreditos();
            double ponderacion = 0;
            foreach (var item in materias_matriculadas)
            {
                if (item.Estado == "Matriculada")
                {
                    ponderacion += item.Numero_creditos * item.Calificacion_final;
                }
            }
            Calificacion_final = ponderacion / Total_creditos;
        }
    }
}
