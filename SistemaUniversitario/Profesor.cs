using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUniversitario
{
    class Profesor
    {
        private string nombre;
        private string id;

        public Profesor(string nombre, string id)
        {
            this.Nombre = nombre;
            this.Id = id;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Id { get => id; set => id = value; }
    }
}
