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
                Estudiantes.Add(new Regular(nombre));
                Estudiante est = Estudiantes.Find(e => e.Nombre == nombre);
                est.Matricular();
                Console.WriteLine($"Nombre: {est.Nombre}, ID: {est.Id}, Tipo de estudiante: Regular");
            }
            else if (tipo == "B" || tipo == "b")
            {
                Estudiantes.Add(new Becado(nombre));
                Estudiante est = Estudiantes.Find(e => e.Nombre == nombre);
                est.Matricular();
                Console.WriteLine($"Nombre: {est.Nombre}, ID: {est.Id}, Tipo de estudiante: Becado");
            }
            else if (tipo == "I" || tipo == "i")
            {
                Estudiantes.Add(new Intercambio(nombre));
                Estudiante est = Estudiantes.Find(e => e.Nombre == nombre);
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
            Estudiante est = Estudiantes.Find(e => e.Id == id);
            Estudiantes.Remove(est);
        }

        public void ReportarSemestre()
        {
            foreach (var item in Estudiantes)
            {
                item.Matricula.CalcularCreditos();
                item.Matricula.CalcularCalificacionFinal();
                item.VerificarAprobacion();
                if (item is Becado)
                {
                    (item as Becado).ComprobarBeca();
                }
                reporte.Reportar(item);
            }
        }
    }
}
