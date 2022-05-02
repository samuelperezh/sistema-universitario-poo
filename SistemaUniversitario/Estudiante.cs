using System;

namespace SistemaUniversitario
{
    abstract class Estudiante
    {
        private string nombre;
        private string id;
        private bool es_aprobado;

        public Estudiante(string nombre)
        {
            this.Nombre = nombre;
            this.Id = GenerarID();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Id { get => id; set => id = value; }
        public bool Es_aprobado { get => es_aprobado; set => es_aprobado = value; }

        public void VerificarAprobacion()
        {

        }

        public string GenerarID()
        {
            Random rnd = new Random();
            id = DateTime.Today.ToString("yyyy");
            for (int i = 0; i < 4; i++)
            {
                id = "E" + id + rnd.Next(0, 9).ToString();
            }
            return id;
        }
    }
}
