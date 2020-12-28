using MoedaCotacaoClient.DAL;
using MoedaCotacaoClient.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoedaCotacaoClient.BLL
{
    public class DeParaBLL
    {
        public void MontarDePara(List<DadosMoeda> lstDadosMoeda, List<DadosCotacao> lstDadosCotacao)
        {
            List<DePara> lstDePara = new List<DePara>();

            if (lstDadosMoeda.Any())
            {
                lstDePara = new DeParaDAL().ObterDePara(lstDadosMoeda, lstDadosCotacao);

                this.ExportarCSV(lstDePara);
            }
        }

        public void ExportarCSV(List<DePara> lstDePara)
        {
            new DeParaDAL().ExportarCSV(lstDePara);
        }
    }
}
