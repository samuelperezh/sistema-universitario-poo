using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SistemaUniversitario
{
    class Materia
    {
        private string nombre;
        private string nrc;
        private int numero_creditos;
        private Profesor profesor;

        public Materia(string nombre, string nrc, int numero_creditos)
        {
            this.Nombre = nombre;
            this.Nrc = nrc;
            this.Numero_creditos = numero_creditos;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Nrc { get => nrc; set => nrc = value; }
        public int Numero_creditos { get => numero_creditos; set => numero_creditos = value; }
        internal Profesor Profesor { get => profesor; set => profesor = value; }

        //public void CargarMaterias()
        //{
        //    string ubicacionArchivo = @"Materias.txt";
        //    StreamReader archivo = new StreamReader(ubicacionArchivo);
        //    string separador = ",";
        //    string linea;
        //    while ((linea = archivo.ReadLine()) != null)
        //    {
        //        string[] fila = linea.Split(separador);
        //        string nrc = fila[0];
        //        string materia = fila[1];
        //        int creditos = int.Parse(fila[2]);
        //        new Materia(materia, nrc, creditos);
        //    }
        //}
    }
}
