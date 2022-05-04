using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace SistemaUniversitario
{
    class ReporteTexto : IReporte
    {
        public void Reportar(List<string> reportes)
        {
            //TODO EL CODIGO VA ACÁ
            try
            {
                string strRuta = "ReporteSemestre.txt";

                StringBuilder sb = new StringBuilder();
                sb.Append("Fecha-hora: " + DateTime.Now +
                    $"\n Cantidad de materias matriculadas: {reportes[0]}" +
                    $"\n Cantidad de créditos totales: {reportes[1]}" +
                    $"\n Calificacion final (promedio crédito ponderado): {reportes[2]}"); 
                    //+
                    //$"\n tipo de pago más usado: {reportes[3]}" +
                    //$"\n tipo de combustible más usado: {reportes[4]}");

                File.WriteAllText(strRuta, sb.ToString());
            }
            catch (Exception)
            {
                throw new Exception("Error al reportar");
            }
            
                
                //throw new System.NotImplementedException();
        }

        //public void reportar(list<string> reportes)
        //{
        //    try
        //    {
        //        string strruta = "reportesemestre.txt";

        //        stringbuilder sb = new stringbuilder();
        //        sb.append("fecha-hora: " + datetime.now +
        //            $"\n cantidad de materias matriculadas: {reportes[0]}" +
        //            $"\n cantidad de créditos totales: {reportes[1]}" +
        //            $"\n calificacion final (premdio crédito ponderado): {reportes[2]}" +
        //        //$"\n tipo de pago más usado: {reportes[3]}" +
        //        //$"\n tipo de combustible más usado: {reportes[4]}");

        //        file.writealltext(strruta, sb.tostring());
        //    }
        //    catch (exception)
        //    {
        //        throw new exception("error al reportar");

        //    }
        //}


        //public void Reportar(Semestre semestre)
        //{
        //StringBuilder sb = new StringBuilder();
        //sb.Append()

        //Cambiar el stringbuilder por los datos del semestre para reportarlos

        //StringBuilder sb = new StringBuilder();
        //sb.Append(Nombre.Substring(0, 10) + " Vlr Base INICIO: " + Valor_base.ToString("C"));

        //Adiciona hasta el 50 % del valor del personal profesional
        //al valor básico del proyecto y escribe en un archivo los valores iniciales y modificados.
        //Valor_base += (Costo_integrantes - (Integrantes.FindAll(x => x.EsProfesional == false).Count) * SMVL) * .5;
        //CalcularCosto();

        //sb.Append(" VlrBase FINAL: " + Valor_base.ToString("C") + "\n");

        //File.AppendAllText("ADICIONES.txt", sb.ToString());

        //}
    }
}
