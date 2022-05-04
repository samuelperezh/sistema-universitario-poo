using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SistemaUniversitario
{
    abstract class Estudiante
    {
        private string nombre;
        private string id;
        private double valor_credito;
        private string aprobacion;
        private Matricula matricula;

        public Estudiante(string nombre)
        {
            this.Nombre = nombre;
            this.Id = GenerarID();
        }

        public string Nombre { get => nombre; protected set => nombre = value; }
        public string Id { get => id; protected set => id = value; }
        public string Aprobacion { get => aprobacion; set => aprobacion = value; }
        public double Valor_credito { get => valor_credito; protected set => valor_credito = value; }
        internal Matricula Matricula { get => matricula; set => matricula = value; }

        public virtual void VerificarAprobacion(Matricula matr)
        {
            if (matr.Calificacion_final >= 3 && matr.Calificacion_final <= 5)
            {
                this.Aprobacion = "Aprobado";
            }
            else
            {
                this.Aprobacion = "Reprobado";
            }
        }
        
        public string GenerarID()
        {
            Random rnd = new Random();
            Id = DateTime.Today.ToString("yyyy");
            for (int i = 0; i < 4; i++)
            {
                Id = "E" + Id + rnd.Next(0, 9).ToString();
            }
            return Id;
        }
    }
}
