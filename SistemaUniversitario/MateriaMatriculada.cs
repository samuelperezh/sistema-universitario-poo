using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SistemaUniversitario
{
    class MateriaMatriculada
    {
        private double calificacion_final;
        private string estado;
        private List<Calificacion> calificaciones = new List<Calificacion>();
        private Materia materia;

        public MateriaMatriculada(Materia materia)
        {
            this.Materia = materia;
            this.Estado = "Matriculada";
        }

        public double Calificacion_final { get => calificacion_final; protected set => calificacion_final = value; }
        public string Estado { get => estado; set => estado = value; }
        internal Materia Materia { get => materia; set => materia = value; }
        internal List<Calificacion> Calificaciones { get => calificaciones; set => calificaciones = value; }

        public double CalcularCalificacionFinal()
        {
            Calificacion_final = 0;
            foreach (var item in Calificaciones)
            {
                Calificacion_final += (item.Nota * (item.Porcentaje / 100));
            }
            if (Calificacion_final > 5)
            {
                Calificacion_final = 0;
            }
            return Calificacion_final;
        }
    }
}
