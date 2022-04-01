using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUniversitario
{
    class Matricula
    {
        private DateTime fecha_max_inscripcion;
        private DateTime fecha_max_cancelacion;
        private double valor_credito;
        private Estudiante estudiante;
        private Semestre semestre;
        private List<MateriaMatriculada> materiasMatriculadas = new List<MateriaMatriculada>();

        public Matricula()
        {
        }

        public DateTime Fecha_max_inscripcion { get => fecha_max_inscripcion; set => fecha_max_inscripcion = value; }
        public DateTime Fecha_max_cancelacion { get => fecha_max_cancelacion; set => fecha_max_cancelacion = value; }
        public double Valor_credito { get => valor_credito; set => valor_credito = value; }
        internal Estudiante Estudiante { get => estudiante; set => estudiante = value; }
        internal Semestre Semestre { get => semestre; set => semestre = value; }    
        internal List<MateriaMatriculada> Materias { get => materiasMatriculadas; set => materiasMatriculadas = value; }


        public void CalcularCostoTotal()
        {

        }

        public void CancelarMateria(MateriaMatriculada materias)
        {

        }

        public void CalcularCalificacionSemestre()
        {

        }

    }
}
