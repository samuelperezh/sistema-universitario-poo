using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SistemaUniversitario
{
    class MateriaMatriculada
    {
        private string nombre;
        private string nrc;
        private int numero_creditos;
        private double calificacion_final;
        private string estado;
        private List<Calificacion> calificaciones = new List<Calificacion>();
        private Materia materia;
        private Profesor profesor;

        public MateriaMatriculada(Materia materia)
        {
            this.Nombre = materia.Nombre;
            this.Nrc = materia.Nrc;
            this.Numero_creditos = materia.Numero_creditos;
            this.Estado = "Matriculada";
            this.Profesor = materia.Profesor;
            this.Materia = materia;
        }

        public double Calificacion_final { get => calificacion_final; set => calificacion_final = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Nombre { get => nombre; private set => nombre = value; }
        public string Nrc { get => nrc; private set => nrc = value; }
        public int Numero_creditos { get => numero_creditos; private set => numero_creditos = value; }
        internal Materia Materia { get => materia; private set => materia = value; }
        internal List<Calificacion> Calificaciones { get => calificaciones; private set => calificaciones = value; }
        internal Profesor Profesor { get => profesor; private set => profesor = value; }

        public void AñadirCalificaciones(float nota, int porcentaje, string descripcion)
        {
            Calificaciones.Add(new Calificacion(nota, porcentaje, descripcion));
        }

        public void CalcularCalificacionFinal()
        {
            foreach (var item in Calificaciones)
            {
                Calificacion_final += (item.Nota * (item.Porcentaje / 100));
            }
        }
    }
}
