﻿using System;

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

        //public string GenerarID()
        //{
        //    Random rnd = new Random();
        //    id = DateTime.Today.ToString("yyyy");
        //    for (int i = 0; i < 4; i++)
        //    {
        //        id = "P" + id + rnd.Next(0, 9).ToString();
        //    }
        //    return id;
        //}

        public void AgregarCalificaciones(MateriaMatriculada est, double nota, double porcentaje, string descripcion)
        {
            est.Calificaciones.Add(new Calificacion(nota, porcentaje, descripcion));
        }
    }
}
