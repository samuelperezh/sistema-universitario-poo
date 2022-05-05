using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace SistemaUniversitario
{
    class ReporteTexto : IReporte
    {
        public void Reportar(Estudiante est)
        {
            try
            {
                string strRuta = "C:\\Users\\samue\\Desktop\\ReporteSemestre.txt";
                StringBuilder sb = new StringBuilder();

                int creditos = 0;
                foreach (var item in est.Matricula.Materias_matriculadas)
                {
                    creditos += item.Materia.Numero_creditos;
                }

                if (est is Regular || est is Intercambio)
                {
                    sb.Append($"Nombre del estudiante: {est.Nombre}" +
                        $"Tipo de estudiante: {est.GetType()}" +      
                        $"\nID: {est.Id}" +
                        $"\nCantidad de materias matriculadas: {est.Matricula.Materias_matriculadas.Count}" +
                        $"\nCantidad de créditos totales: {creditos}" +
                        $"\nCalificacion final (promedio crédito ponderado): {est.Matricula.Calificacion_final}" +
                        $"\nEstado de aprobación: {est.Aprobacion}\n \n");
                }
                else if (est is Becado)
                {
                    (est as Becado).ComprobarBeca();
                    string beca;
                    if ((est as Becado).Conserva_beca)
                    {
                        beca = "Sí";
                    }
                    else
                    {
                        beca = "No";
                    }

                    sb.Append($"Nombre del estudiante: {est.Nombre}" +
                        $"\nID: {est.Id}" +
                        $"\nCantidad de materias matriculadas: {est.Matricula.Materias_matriculadas.Count}" +
                        $"\nCantidad de créditos totales: {creditos}" +
                        $"\nCalificacion final (promedio crédito ponderado): {est.Matricula.Calificacion_final}" +
                        $"\nEstado de aprobación: {est.Aprobacion}" +
                        $"\n¿Continúa con la beca? {beca}\n");
                }
                File.AppendAllText(strRuta, sb.ToString());
            }
            catch (Exception e)
            {
                throw new Exception("¡Error al reportar!" + e.Message);
            };
        }
    }
}
