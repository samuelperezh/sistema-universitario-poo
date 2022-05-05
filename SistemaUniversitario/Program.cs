using System;
using System.Collections.Generic;
using System.IO;

namespace SistemaUniversitario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string tipo;
            string nrc;
            string id_e;
            string id_p;
            double nota;
            int porcentaje;
            string descripcion;
            Semestre semestre = new Semestre();
            List<Materia> lista_materias = new List<Materia>();
            List<Profesor> lista_profesores = new List<Profesor>();

            StreamReader archivo = new StreamReader("..\\..\\..\\BD.txt");
            string separador = ",";
            string linea;
            while ((linea = archivo.ReadLine()) != null)
            {
                string[] fila = linea.Split(separador);
                nrc = fila[0];
                string materia = fila[1];
                int creditos = int.Parse(fila[2]);
                Profesor profesor = new Profesor(fila[3],fila[4]);
                lista_materias.Add(new Materia(materia, nrc, creditos, profesor));
            }

            try
            {
                int op = 0;
                int op_e = 0;
                int op_p = 0;
                int op_a = 0;
                bool esNro = false;
                do
                {
                    try
                    {
                        MostrarMenu();
                        do
                        {
                            Console.WriteLine("\nDigita la opción del menú que deseas acceder: ");
                            esNro = int.TryParse(Console.ReadLine(), out op);
                        } while (!esNro);
                        switch (op)
                        {
                            case 0://Cerrar el programa
                                Console.WriteLine("=========== HASTA PRONTO ===========");
                                break;
                            case 1://Rol estudiante
                                do
                                {
                                    try
                                    {
                                        MostrarMenuEstudiante();
                                        esNro = false;
                                        do
                                        {
                                            Console.WriteLine("\nDigita la opción del menú que deseas acceder: ");
                                            esNro = int.TryParse(Console.ReadLine(), out op_e);
                                        } while (!esNro);
                                        switch (op_e)
                                        {
                                            case 0://Salir
                                                break;

                                            case 1://Inscribir materias
                                                Console.WriteLine("\nIngresa tu ID: ");
                                                id_e = Console.ReadLine();
                                                Estudiante est1 = semestre.Estudiantes.Find(e => e.Id == id_e);
                                                Console.WriteLine("\nIngresa el NRC de la materia que deseas matricular: ");
                                                nrc = Console.ReadLine();
                                                Materia mat1 = lista_materias.Find(m => m.Nrc == nrc);
                                                est1.Matricula.MatricularMaterias(mat1, est1);
                                                break;

                                            case 2://Cancelar materias
                                                Console.WriteLine("\nIngresa tu ID: ");
                                                id_e = Console.ReadLine();
                                                Estudiante est2 = semestre.Estudiantes.Find(e => e.Id == id_e);
                                                Console.WriteLine("\nIngresa el NRC de la materia que deseas cancelar: ");
                                                nrc = Console.ReadLine();
                                                MateriaMatriculada mat2 = est2.Matricula.Materias_matriculadas.Find(m => m.Nrc == nrc);
                                                est2.Matricula.CancelarMaterias(mat2);
                                                break;

                                            case 3://Ver calificaciones
                                                Console.WriteLine("\nIngresa tu ID: ");
                                                id_e = Console.ReadLine();
                                                Estudiante est3 = semestre.Estudiantes.Find(e => e.Id == id_e);
                                                MostrarCalificaciones(est3);
                                                break;

                                            case 4://Ver materias matriculadas, costo y total de créditos
                                                Console.WriteLine("\nIngresa tu ID: ");
                                                id_e = Console.ReadLine();
                                                Estudiante est4 = semestre.Estudiantes.Find(e => e.Id == id_e);
                                                MostrarResumenEstudiante(est4);
                                                break;

                                            case 5://
                                                break;
                                        }
                                    }
                                    catch (Exception ee)
                                    {
                                        Console.WriteLine("Error: " + ee.Message);
                                    }
                                } while (op_e != 0);
                                break;
                            case 2://Rol profesor
                                do
                                {
                                    try
                                    {
                                        MostrarMenuProfesor();
                                        esNro = false;
                                        do
                                        {
                                            Console.WriteLine("\nDigita la opción del menú que deseas acceder: ");
                                            esNro = int.TryParse(Console.ReadLine(), out op_p);
                                        } while (!esNro);
                                        switch (op_p)
                                        {
                                            case 0://Salir
                                                break;

                                            case 1://Añadir calificaciones
                                                Console.WriteLine($"\nIngresa el ID (profesor): ");
                                                id_p = Console.ReadLine();
                                                //Profesor profe = lista_profesores.Find(p => p.Id == id_p);
                                                Console.WriteLine("\nIngresa el ID del estudiante: ");
                                                id_e = Console.ReadLine();
                                                Estudiante est = semestre.Estudiantes.Find(e => e.Id == id_e);
                                                MateriaMatriculada mat = est.Matricula.Materias_matriculadas.Find(m => m.Profesor.Id == id_p);
                                                Console.WriteLine("\nIngresa la nota: ");
                                                esNro = false;
                                                do
                                                {
                                                    Console.WriteLine("\nDigita la opción del menú que deseas acceder: ");
                                                    esNro = double.TryParse(Console.ReadLine(), out nota);
                                                } while (!esNro);
                                                Console.WriteLine("\nIngresa el porcentaje: ");
                                                esNro = false;
                                                do
                                                {
                                                    Console.WriteLine("\nDigita la opción del menú que deseas acceder: ");
                                                    esNro = int.TryParse(Console.ReadLine(), out porcentaje);
                                                } while (!esNro);
                                                Console.WriteLine("\nIngresa la descripción: ");
                                                descripcion = Console.ReadLine();
                                                mat.AñadirCalificaciones(nota, porcentaje, descripcion);
                                                break;

                                            case 2://Ver materias dictadas
                                                Console.WriteLine($"\nIngresa el ID (profesor): ");
                                                id_p = Console.ReadLine();
                                                List<Materia> materia = lista_materias.FindAll(a => a.Profesor.Id == id_p);
                                                foreach (var item in materia)
                                                {
                                                    Console.WriteLine($"\nMateria: {item.Nombre}, NRC: {item.Nrc}\n");
                                                }
                                                break;
                                        }
                                    }
                                    catch (Exception ep)
                                    {
                                        Console.WriteLine("Error: " + ep.Message);
                                    }
                                } while (op_e != 0);
                                break;
                            case 3://Rol administrativo
                                do
                                {
                                    try
                                    {
                                        MostrarMenuAdministrativo();
                                        esNro = false;
                                        do
                                        {
                                            Console.WriteLine("\nDigita la opción del menú que deseas acceder: ");
                                            esNro = int.TryParse(Console.ReadLine(), out op_a);
                                        } while (!esNro);
                                        switch (op_a)
                                        {
                                            case 0://Salir
                                                break;

                                            case 1://Crear estudiantes
                                                Console.WriteLine("\nIngresa el nombre del estudiante: ");
                                                nombre = Console.ReadLine();
                                                Console.WriteLine("\n¿Es un estudiante regular, becado o de intercambio? (R/B/I): ");
                                                tipo = Console.ReadLine();
                                                semestre.AñadirEstudiantes(nombre, tipo);
                                                break;

                                            case 2://Eliminar estudiantes
                                                Console.WriteLine("\nIngresa el ID del estudiante que deseas eliminar: ");
                                                id_e = Console.ReadLine();
                                                semestre.EliminarEstudiantes(id_e);
                                                break;

                                            case 3://Mostrar todos los estudiantes
                                                foreach (Estudiante est in semestre.Estudiantes)
                                                {
                                                    if (est is Regular)
                                                    {
                                                        Console.WriteLine($"Nombre: {est.Nombre}, ID: {est.Id}, Tipo de estudiante: Regular");
                                                    }
                                                    else if (est is Becado)
                                                    {
                                                        Console.WriteLine($"Nombre: {est.Nombre}, ID: {est.Id}, Tipo de estudiante: Becado");
                                                    }
                                                    else if (est is Intercambio)
                                                    {
                                                        Console.WriteLine($"Nombre: {est.Nombre}, ID: {est.Id}, Tipo de estudiante: Intercambio");
                                                    }
                                                }
                                                Console.WriteLine();
                                                break;

                                            case 4://Generar reporte del semestre
                                                Console.WriteLine("\nGenerando reporte...\n");
                                                semestre.ReportarSemestre();
                                                break;
                                        }
                                    }
                                    catch (Exception ea)
                                    {
                                        Console.WriteLine(ea.Message);
                                    }
                                } while (op_e != 0);
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                } while (op != 0);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public static void MostrarResumenEstudiante(Estudiante est)
        {
            Console.WriteLine("");
            foreach (var item in est.Matricula.Materias_matriculadas)
            {
                Console.WriteLine($"Materia matriculada: {item.Nombre}, Creditos: {item.Numero_creditos}, NRC: {item.Nrc}, " +
                    $"\nProfesor: {item.Profesor.Nombre}, Estado: {item.Estado}");
            }
            est.Matricula.CalcularCreditos();
            est.Matricula.CalcularCostoMatricula(est);
            foreach (var item in est.Matricula.Materias_matriculadas)
            {
                item.CalcularCalificacionFinal();
            }
            est.Matricula.CalcularCalificacionFinal();
            est.VerificarAprobacion();
            Console.WriteLine($"\nCalificación final acumulada: {est.Matricula.Calificacion_final}" +
                $"\nEstado de aprobación actual: {est.Aprobacion}\n" +
                $"\nTotal de créditos: {est.Matricula.Total_creditos}" +
                $"\nValor crédito {est.Valor_credito}" +
                $"\nTotal matrícula: {est.Matricula.Costo_matricula:C}\n");
        }

        public static void MostrarCalificaciones(Estudiante est)
        {
            foreach (var item in est.Matricula.Materias_matriculadas)
            {
                Console.WriteLine($"Materia: {item.Nombre}, Profesor: {item.Profesor.Nombre}");
                foreach (var calificacion in item.Calificaciones)
                {
                    Console.WriteLine($"Nota: {calificacion.Nota}, Porcentaje: {calificacion.Porcentaje}, Descripción: {calificacion.Descripcion}");
                }
            }
        }

        public static void MostrarMenu()
        {
            Console.WriteLine("===== Bienvenido al Sistema Universitario =====\n" +
                "¿Cuál es tu rol en el sistema?\n" +
                "1. Estudiante\n" +
                "2. Profesor\n" +
                "3. Administrativo\n" +
                "0. Salir del Sistema");
        }

        public static void MostrarMenuEstudiante()
        {
            Console.WriteLine("===== Estudiante =====\n" +
                "1. Inscribir materias\n" +
                "2. Cancelar materias\n" +
                "3. Ver calificaciones\n" +
                "4. Ver materias matriculadas, costo y total de créditos\n" +
                "0. Regresar al menú anterior");
        }

        public static void MostrarMenuProfesor()
        {
            Console.WriteLine("===== Profesor =====\n" +
                "1. Añadir calificaciones\n" +
                "2. Ver materias dictadas\n" +
                "0. Regresar al menú anterior");
        }

        public static void MostrarMenuAdministrativo()
        {
            Console.WriteLine("===== Administrativo =====\n" +
                "1. Crear estudiantes\n" +
                "2. Eliminar estudiantes\n" +
                "3. Mostrar todos los estudiantes\n" +
                "4. Generar reporte del semestre\n" +
                "0. Regresar al menú anterior");
        }
    }
}
