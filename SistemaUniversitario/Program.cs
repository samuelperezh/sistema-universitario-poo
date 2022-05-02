using System;
using System.Collections.Generic;
using System.IO;

namespace SistemaUniversitario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Materia> lista_materias = new List<Materia>();
            string ubicacionArchivo = "..\\..\\..\\Materias.txt";
            StreamReader archivo = new StreamReader(ubicacionArchivo);
            string separador = ",";
            string linea;
            while ((linea = archivo.ReadLine()) != null)
            {
                string[] fila = linea.Split(separador);
                string nrc = fila[0];
                string materia = fila[1];
                int creditos = int.Parse(fila[2]);
                lista_materias.Add(new Materia(materia, nrc, creditos));
            }
            foreach (var item in lista_materias)
            {
                MostrarMaterias(item);
            }
            //try
            //{
            //    int op = 0;
            //    int op_e = 0;
            //    int op_p = 0;
            //    int op_a = 0;
            //    bool esNro = false;
            //    do
            //    {
            //        try
            //        {
            //            MostrarMenu();
            //            do
            //            {
            //                Console.WriteLine("\nDigita la opción del menú que deseas acceder: ");
            //                esNro = int.TryParse(Console.ReadLine(), out op);
            //            } while (!esNro);
            //            switch (op)
            //            {
            //                case 0:
            //                    break;
            //                case 1: //Rol estudiante
            //                    do
            //                    {
            //                        try
            //                        {
            //                            MostrarMenuEstudiante();
            //                            esNro = false;
            //                            do
            //                            {
            //                                Console.WriteLine("\nDigita la opción del menú que deseas acceder: ");
            //                                esNro = int.TryParse(Console.ReadLine(), out op_e);
            //                            } while (!esNro);
            //                            switch (op_e)
            //                            {
            //                                case 0:
            //                                    break;
            //                            }
            //                        }
            //                        catch (Exception ee)
            //                        {
            //                            Console.WriteLine(ee.Message);
            //                        }
            //                    } while (op_e != 0);
            //                    break;
            //                case 2: //Rol profesor
            //                    do
            //                    {
            //                        try
            //                        {
            //                            MostrarMenuProfesor();
            //                            esNro = false;
            //                            do
            //                            {
            //                                Console.WriteLine("\nDigita la opción del menú que deseas acceder: ");
            //                                esNro = int.TryParse(Console.ReadLine(), out op_p);
            //                            } while (!esNro);
            //                            switch (op_p)
            //                            {
            //                                case 0:
            //                                    break;
            //                            }
            //                        }
            //                        catch (Exception ep)
            //                        {
            //                            Console.WriteLine(ep.Message);
            //                        }
            //                    } while (op_e != 0);
            //                    break;
            //                case 3: //Rol administrativo
            //                    do
            //                    {
            //                        try
            //                        {
            //                            MostrarMenuAdministrativo();
            //                            esNro = false;
            //                            do
            //                            {
            //                                Console.WriteLine("\nDigita la opción del menú que deseas acceder: ");
            //                                esNro = int.TryParse(Console.ReadLine(), out op_a);
            //                            } while (!esNro);
            //                            switch (op_a)
            //                            {
            //                                case 0:
            //                                    break;
            //                            }
            //                        }
            //                        catch (Exception ea)
            //                        {
            //                            Console.WriteLine(ea.Message);
            //                        }
            //                    } while (op_e != 0);
            //                    break;
            //            }
            //        } catch (Exception e)
            //        {
            //            Console.WriteLine(e.Message);
            //        }
            //    } while (op != 0);
            //} catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }

        //public static void PruebaID(Estudiante est)
        //{
        //    Console.WriteLine($"Nombre: {est.Nombre} ID: {est.Id}");
        //}
        public static void MostrarMaterias(Materia mate)
        {
            Console.WriteLine($"Nombre de la materia: {mate.Nombre}, Creditos: {mate.Numero_creditos}, NRC: {mate.Nrc}");
        }
        public static void CargarMaterias()
        {
            //string ubicacionArchivo = "..\\..\\..\\Materias.csv";
            //StreamReader archivo = new StreamReader(ubicacionArchivo);
            //string separador = ";";
            //string linea;
            //while ((linea = archivo.ReadLine()) != null)
            //{
            //    string[] fila = linea.Split(separador);
            //    string nrc = fila[0];
            //    string materia = fila[1];
            //    int creditos = int.Parse(fila[2]);
            //    lista_materias.Add(new Materia(materia, nrc, creditos));
            //}
        }
        public static void MostrarMenu()
        {
            Console.WriteLine("===== Bienvenido al Sistema Universitario =====\n" +
                "¿Cuál es tu rol en el sistema?\n" +
                "1. Estudiante\n" +
                "2. Profesor\n" +
                "3. Administrativo\n" +
                "0. Salir del Sistema\n");
        }

        public static void MostrarMenuEstudiante()
        {
            Console.WriteLine("===== Estudiante =====\n" +
                "1. Inscribir materias\n" +
                "2. Cancelar materias\n" +
                "3. Ver calificaciones\n" +
                "4. Ver materias matriculadas y profesores\n" +
                "0. Regresar al menú anterior\n");
        }

        public static void MostrarMenuProfesor()
        {
            Console.WriteLine("===== Profesor =====\n" +
                "1. Añadir calificaciones\n" +
                "2. Ver materias dictadas\n" +
                "0. Regresar al menú anterior\n");
        }

        public static void MostrarMenuAdministrativo()
        {
            Console.WriteLine("===== Administrativo =====\n" +
                "1. Crear estudiantes\n" +
                "2. Eliminar estudiantes\n" +
                "0. Regresar al menú anterior\n");
        }
    }
}
