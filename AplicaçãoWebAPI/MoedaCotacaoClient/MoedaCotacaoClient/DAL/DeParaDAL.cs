using Microsoft.Office.Interop.Excel;
using MoedaCotacaoClient.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoedaCotacaoClient.DAL
{
    public class DeParaDAL
    {
        public List<DePara> ObterDePara(List<DadosMoeda> lstDadosMoeda, List<DadosCotacao> lstDadosCotacao)
        {
            //int codigoCotacao;
            List<DePara> lstDePara = new List<DePara>();

            using (WiProApiDBEntities wp = new WiProApiDBEntities())
            {
                var lstDeParaBD = wp.DePara.ToList();

                foreach (var dadosMoeda in lstDadosMoeda)
                {
                    try
                    {
                        int codCotacao = lstDeParaBD.AsQueryable().Where(x => x.ID_MOEDA == dadosMoeda.ID_MOEDA).FirstOrDefault().COD_COTACAO;
                        var valorCotacao = lstDadosCotacao.Where(x => x.COD_COTACAO == Convert.ToInt32(codCotacao)).Select(a => a.VLR_COTACAO).FirstOrDefault();

                        if (valorCotacao != 0)
                        {
                            lstDePara.Add(new DePara()
                            {
                                ID_MOEDA = dadosMoeda.ID_MOEDA,
                                DATA_REF = dadosMoeda.DATA_REF,
                                VL_COTACAO = valorCotacao
                            });
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }

                return lstDePara;
            }
        }

        public void ExportarCSV(List<DePara> lstDePara)
        {
            Application csv = new Application();

            Workbook wb = csv.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)csv.ActiveSheet;

            csv.Visible = false;
            int index = 1;

            ws.Cells[1, 1] = "ID_MOEDA";
            ws.Cells[1, 2] = "DATA_REF";
            ws.Cells[1, 3] = "VLR_COTACAO";

            foreach (DePara dePara in lstDePara)
            {
                index++;
                ws.Cells[index, 1] = dePara.ID_MOEDA.ToString();
                ws.Cells[index, 2] = dePara.DATA_REF.ToString("dd/MM/yyyy");
                ws.Cells[index, 3] = dePara.VL_COTACAO.ToString();
            }

            string fileName = AppDomain.CurrentDomain.BaseDirectory + $@"Carga\Resultado_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.csv";

            ws.SaveAs(
                fileName,
                XlFileFormat.xlWorkbookDefault,
                Type.Missing,
                Type.Missing,
                true,
                false,
                XlSaveAsAccessMode.xlNoChange,
                XlSaveConflictResolution.xlLocalSessionChanges,
                Type.Missing,
                Type.Missing);

            csv.Quit();
        }
    }
}
