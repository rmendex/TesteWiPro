using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoedaCotacaoClient.Entidades
{
    public class DePara
    {
        public string ID_MOEDA { get; set; }
        public DateTime DATA_REF { get; set; }
        public decimal VL_COTACAO { get; set; }
    }
}
