using System;

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

        public string Nombre { get => nombre; protected set => nombre = value; }
        public string Id { get => id; protected set => id = value; }
    }
}
