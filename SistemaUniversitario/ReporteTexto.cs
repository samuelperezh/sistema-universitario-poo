using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUniversitario
{
    class ReporteTexto : IReporte
    {
        public void Reportar(Semestre semestre)
        {
            //StringBuilder sb = new StringBuilder();
            //sb.Append(Nombre.Substring(0, 10) + " Vlr Base INICIO: " + Valor_base.ToString("C"));

            //Adiciona hasta el 50 % del valor del personal profesional
            //al valor básico del proyecto y escribe en un archivo los valores iniciales y modificados.
            //Valor_base += (Costo_integrantes - (Integrantes.FindAll(x => x.EsProfesional == false).Count) * SMVL) * .5;
            //CalcularCosto();

            //sb.Append(" VlrBase FINAL: " + Valor_base.ToString("C") + "\n");

            //File.AppendAllText("ADICIONES.txt", sb.ToString());

        }
    }
}
