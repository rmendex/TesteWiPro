using MoedaCotacaoClient.DAL;
using MoedaCotacaoClient.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoedaCotacaoClient.BLL
{
    public class DadosMoedaBLL
    {
        private readonly DadosMoedaDAL _dadosMoedaDAL;
        public DadosMoedaBLL()
        {
            _dadosMoedaDAL = new DadosMoedaDAL();
        }
        public List<DadosMoeda> ObterDadosMoeda(Item item)
        {
            return _dadosMoedaDAL.ObterDadosMoedaDAL(item);
        }
    }
}
