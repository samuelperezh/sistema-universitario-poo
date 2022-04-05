using System;
using System.Collections.Generic;

namespace SistemaUniversitario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();

            listaEstudiantes.Add(new Becado("Samuel"));

            foreach (var item in listaEstudiantes)
            {
                PruebaID(item);
            }
        }

        public static void PruebaID(Estudiante est)
        {
            Console.WriteLine($"Nombre: {est.Nombre} ID: {est.Id}");
        }
    }
}
