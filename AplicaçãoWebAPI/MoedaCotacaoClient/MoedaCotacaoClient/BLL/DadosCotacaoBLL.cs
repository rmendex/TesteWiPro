using MoedaCotacaoClient.DAL;
using MoedaCotacaoClient.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoedaCotacaoClient.BLL
{
    public class DadosCotacaoBLL
    {
        private readonly DadosCotacaoDAL _dadosCotacaoDAL;
        public DadosCotacaoBLL()
        {
            _dadosCotacaoDAL = new DadosCotacaoDAL();
        }

        public List<DadosCotacao> ObterDadosMoeda()
        {
            return _dadosCotacaoDAL.ObterDadosCotacaoDAL();
        }
    }
}
