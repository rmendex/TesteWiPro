using MoedaCotacaoClient.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoedaCotacaoClient.DAL
{
    public class DadosMoedaDAL
    {
        public List<DadosMoeda> ObterDadosMoedaDAL(Item item)
        {
            IEnumerable<DadosMoeda> values = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\Carga\DadosMoeda.csv")
                      .Skip(1)
                      .Select(v => FromCsv(v))
                      .ToList() as IEnumerable<DadosMoeda>;

            return values.Where(a => a.DATA_REF >= item.DtInicio && a.DATA_REF <= item.DtFim).Select(a => a).ToList();
        }

        public DadosMoeda FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(';');
            DadosMoeda dadosValues = new DadosMoeda();
            dadosValues.ID_MOEDA = values[0];
            dadosValues.DATA_REF = Convert.ToDateTime(values[1]);

            return dadosValues;
        }
    }
}
