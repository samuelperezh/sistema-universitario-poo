using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUniversitario
{
    abstract class Estudiante
    {
        private string nombre;
        private string id;
        private double calificacion_final;
        private bool es_aprobado;
        private List<Materia> materias = new List<Materia>();
        private Matricula matricula;

        public Estudiante(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Id { get => id; set => id = value; }
        public double Calificacion_final { get => calificacion_final; set => calificacion_final = value; }
        public bool Es_aprobado { get => es_aprobado; set => es_aprobado = value; }
        internal List<Materia> Materias { get => materias; set => materias = value; }
        internal Matricula Matricula { get => matricula; set => matricula = value; }
    }
}
