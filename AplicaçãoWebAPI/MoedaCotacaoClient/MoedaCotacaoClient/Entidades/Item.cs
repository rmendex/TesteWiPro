using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoedaCotacaoClient.Entidades
{
    public class Item
    {
        public int ID { get; set; }
        public string Moeda { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
    }
}
