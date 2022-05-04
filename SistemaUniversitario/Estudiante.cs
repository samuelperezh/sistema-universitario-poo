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

        public void Matricular()
        {
            Matricula = new Matricula(this);
        }

        public virtual string VerificarAprobacion()
        {
            string aprobacion;
            if (Matricula.Calificacion_final >= 3 && Matricula.Calificacion_final <= 5)
            {
                aprobacion = "Aprobado";
            }
            else
            {
                aprobacion = "Reprobado";
            }
            return aprobacion;
        }
        
        public string GenerarID()
        {
            Random rnd = new Random();
            Id = "E" + DateTime.Today.ToString("yyyy");
            for (int i = 0; i < 6; i++)
            {
                Id = Id + rnd.Next(0, 9).ToString();
            }
            return Id;
        }
    }
}
