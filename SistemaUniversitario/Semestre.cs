using System;
using System.Collections.Generic;

namespace SistemaUniversitario
{
    class Semestre
    {
        private List<Estudiante> estudiantes = new List<Estudiante>();

        IReporte reporte = new ReporteTexto();

        public Semestre() { }

        internal List<Estudiante> Estudiantes { get => estudiantes; private set => estudiantes = value; }
        
        public void AñadirEstudiantes(string nombre, string tipo)
        {
            if (tipo == "R" || tipo == "r")
            {
                estudiantes.Add(new Regular(nombre));
                Estudiante est = estudiantes.Find(e => e.Nombre == nombre);
                est.Matricular();
                Console.WriteLine($"Nombre: {est.Nombre}, ID: {est.Id}, Tipo de estudiante: Regular");
            }
            else if (tipo == "B" || tipo == "b")
            {
                estudiantes.Add(new Becado(nombre));
                Estudiante est = estudiantes.Find(e => e.Nombre == nombre);
                est.Matricular();
                Console.WriteLine($"Nombre: {est.Nombre}, ID: {est.Id}, Tipo de estudiante: Becado");
            }
            else if (tipo == "I" || tipo == "i")
            {
                estudiantes.Add(new Intercambio(nombre));
                Estudiante est = estudiantes.Find(e => e.Nombre == nombre);
                est.Matricular();
                Console.WriteLine($"Nombre: {est.Nombre}, ID: {est.Id}, Tipo de estudiante: Intercambio");
            }
            else
            {
                Console.WriteLine($"\nNo hay un tipo de estudiante {tipo}");
            }
        }

        public void EliminarEstudiantes(string id)
        {
            Estudiante est = estudiantes.Find(e => e.Id == id);
            estudiantes.Remove(est);
        }
    }
}
