using MoedaCotacaoClient.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoedaCotacaoClient.DAL
{
    public class DadosCotacaoDAL
    {
        public List<DadosCotacao> ObterDadosCotacaoDAL()
        {
            IEnumerable<DadosCotacao> values = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\Carga\DadosCotacao.csv")
                      .Skip(1)
                      .Select(v => FromCsv(v))
                      .ToList() as IEnumerable<DadosCotacao>;

            return values.ToList();
        }

        public DadosCotacao FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(';');
            DadosCotacao dadosValues = new DadosCotacao();
            dadosValues.VLR_COTACAO = Convert.ToDecimal(values[0]);
            dadosValues.COD_COTACAO = Convert.ToInt32(values[1]);
            dadosValues.DAT_COTACAO = Convert.ToDateTime(values[2]);

            return dadosValues;
        }

    }
}
