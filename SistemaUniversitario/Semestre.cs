using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUniversitario
{
    class Semestre
    {
        private DateTime fecha_actual;
        private double valor_credito;
        private DateTime fecha_max_inscripcion;
        private DateTime fecha_max_cancelacion;
        List<Profesor> profesores = new List<Profesor>();
        List<Estudiante> estudiantes = new List<Estudiante>();

        public Semestre(DateTime fecha_actual)
        {
            this.Fecha_actual = fecha_actual;
        }

        public DateTime Fecha_actual { get => fecha_actual; set => fecha_actual = value; }
        public double Valor_credito { get => valor_credito; set => valor_credito = value; }
        public DateTime Fecha_max_inscripcion { get => fecha_max_inscripcion; set => fecha_max_inscripcion = value; }
        public DateTime Fecha_max_cancelacion { get => fecha_max_cancelacion; set => fecha_max_cancelacion = value; }
        internal List<Profesor> Profesores { get => profesores; set => profesores = value; }
        internal List<Estudiante> Estudiantes { get => estudiantes; set => estudiantes = value; }


        public void CerrarSemestre()
        {

        }
    }
}
