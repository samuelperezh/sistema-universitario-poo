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
            string id;
            Semestre semestre = new Semestre();
            List<Materia> lista_materias = new List<Materia>();

            //List<Matricula> lista_matriculas = new List<Matricula>();
            //List<MateriaMatriculada> lista_materia_matriculada = new List<MateriaMatriculada>();
            //List<Profesor> lista_profesores = new List<Profesor>();
            //List<Estudiante> lista_estudiantes = new List<Estudiante>();

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

            //foreach(var item in lista_materias)
            //{
            //    MostrarMaterias(item);
            //}
            
            //MateriaMatriculada poo = new MateriaMatriculada(lista_materias.Find(c1 => c1.Nrc == "99370011"));
            //MostrarMateriaMatriculada(poo);

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
                                                id = Console.ReadLine();
                                                Estudiante est = semestre.Estudiantes.Find(e => e.Id == id);
                                                Console.WriteLine("\nIngresa el NRC de la materia que deseas matricular: ");
                                                nrc = Console.ReadLine();
                                                Materia mat = lista_materias.Find(m => m.Nrc == nrc);
                                                est.Matricula.MatricularMaterias(mat);
                                                break;

                                            case 2://Cancelar materias
                                                break;

                                            case 3://Ver calificaciones
                                                break;

                                            case 4://Ver materias matriculadas y profesores
                                                Console.WriteLine("\nIngresa tu ID: ");
                                                id = Console.ReadLine();
                                                Estudiante est1 = semestre.Estudiantes.Find(e => e.Id == id);
                                                MostrarMateriasMatriculadas(est1);
                                                break;
                                        }
                                    }
                                    catch (Exception ee)
                                    {
                                        Console.WriteLine(ee.Message);
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
                                                //do
                                                //{
                                                //    Console.WriteLine("\nIngresa tu ID: ");
                                                //    esNro = int.TryParse(Console.ReadLine(), out id);
                                                //} while (!esNro) ;
                                                break;

                                            case 2://Ver materias dictadas
                                                break;
                                        }
                                    }
                                    catch (Exception ep)
                                    {
                                        Console.WriteLine(ep.Message);
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
                                                id = Console.ReadLine();
                                                semestre.EliminarEstudiantes(id);
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
                        Console.WriteLine(e.Message);
                    }
                } while (op != 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //public static void MostrarInfoEstudiante(Estudiante est)
        //{
        //    if (est is Regular)
        //    {
        //        Console.WriteLine($"Nombre: {est.Nombre}, ID: {est.Id}, Tipo de estudiante: Regular\n");
        //    }
        //    else if (est is Becado)
        //    {
        //        Console.WriteLine($"Nombre: {est.Nombre}, ID: {est.Id}, Tipo de estudiante: Becado\n");
        //    }
        //    else if (est is Intercambio)
        //    {
        //        Console.WriteLine($"Nombre: {est.Nombre}, ID: {est.Id}, Tipo de estudiante: Intercambio\n");
        //    }
        //}

        public static void MostrarMateriasMatriculadas(Estudiante est)
        {
            foreach (var item in est.Matricula.Materias_matriculadas)
            {
                Console.WriteLine($"Materia matriculada: {item.Nombre}, Creditos: {item.Numero_creditos}, NRC: {item.Nrc}, Profesor: {item.Profesor.Nombre}");
            }
            Console.WriteLine("");
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
                "4. Ver materias matriculadas y profesores\n" +
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
                "0. Regresar al menú anterior");
        }
    }
}
