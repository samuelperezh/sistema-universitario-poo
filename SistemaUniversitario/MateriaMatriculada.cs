using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUniversitario
{
    class MateriaMatriculada
    {
        private double calificacion_final;
        private List<Calificacion> calificaciones = new List<Calificacion>();
        private Materia materia;

        public MateriaMatriculada()
        {
            
        }

        public double CalcularCalificacionFinal()
        {
            calificacion_final = 0;
            foreach(var item in calificaciones)
            {
                calificacion_final += (item.Nota * (item.Porcentaje/100));
            }
            if (calificacion_final > 5)
            {
                calificacion_final = 0;
            }
            return calificacion_final;
        }
    }
}
