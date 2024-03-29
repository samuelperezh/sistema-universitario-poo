﻿using System.IO;
using System.Collections.Generic;

namespace SistemaUniversitario
{
    class Materia
    {
        private string nombre;
        private string nrc;
        private int numero_creditos;
        private Profesor profesor;

        public Materia(string nombre, string nrc, int numero_creditos, Profesor profesor)
        {
            this.Nombre = nombre;
            this.Nrc = nrc;
            this.Numero_creditos = numero_creditos;
            this.Profesor = profesor;
        }

        public string Nombre { get => nombre; protected set => nombre = value; }
        public string Nrc { get => nrc; protected set => nrc = value; }
        public int Numero_creditos { get => numero_creditos; protected set => numero_creditos = value; }
        internal Profesor Profesor { get => profesor; private set => profesor = value; }
    }
}
