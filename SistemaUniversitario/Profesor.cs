using System;

namespace SistemaUniversitario
{
    class Profesor
    {
        private string nombre;
        private string id;

        public Profesor(string nombre)
        {
            this.Nombre = nombre;
            this.Id = GenerarID();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Id { get => id; set => id = value; }

        public string GenerarID()
        {
            Random rnd = new Random();
            id = DateTime.Today.ToString("yyyy");
            for (int i = 0; i < 4; i++)
            {
                id = "P" + id + rnd.Next(0, 9).ToString();
            }
            return id;
        }
    }
}
