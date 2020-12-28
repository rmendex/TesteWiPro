using MoedaCotacaoClient.BLL;
using MoedaCotacaoClient.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MoedaCotacaoClient.Controllers
{
    public class ClienteController
    {
        Item item = new Item();
        public async Task<Item> ObterProxItem(string uri)
        {
            item = null;
            try
            {
                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync(uri))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var ItemJsonString = await response.Content.ReadAsStringAsync();
                            item = JsonConvert.DeserializeObject<Item>(ItemJsonString);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return item;
        }

        public List<DadosMoeda> ObterDadosMoeda(Item item)
        {
            return new DadosMoedaBLL().ObterDadosMoeda(item);
        }

        public List<DadosCotacao> ObterDadosCotacao()
        {
            return new DadosCotacaoBLL().ObterDadosMoeda();
        }

        public void MontarDePara(List<DadosMoeda> lstDadosMoeda, List<DadosCotacao> lstDadosCotacao)
        {
            new DeParaBLL().MontarDePara(lstDadosMoeda, lstDadosCotacao);
        }
    }
}
