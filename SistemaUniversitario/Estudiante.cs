using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUniversitario
{
    abstract class Estudiante
    {
        private string nombre;
        private string id;
        private bool es_aprobado;

        public Estudiante(string nombre)
        {
            this.nombre = nombre;
            GenerarID();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Id { get => id; set => id = value; }
        public bool Es_aprobado { get => es_aprobado; set => es_aprobado = value; }

        public void VerificarAprobacion()
        {

        }

        public void GenerarID()
        {
            
        }
    }
}
