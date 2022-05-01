using System;
using System.Collections.Generic;

namespace SistemaUniversitario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int op = 0;
                bool esNro = false;
                do
                {
                    try
                    {
                        MostrarMenu();
                        do
                        {
                            Console.WriteLine("Opcion");
                            esNro = int.TryParse(Console.ReadLine(), out op);
                        } while (!esNro);
                        switch (op)
                        {
                            case 0:
                                break;
                        }
                    } catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (op != 0);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

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

        public static void MostrarMenu()
        {
            Console.WriteLine("===== Menú principal =====");
        }
    }
}
