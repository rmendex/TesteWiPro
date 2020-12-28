using System;
using System.Collections.Generic;
using System.Text;

namespace WiProApiFila.Dominio.Entidades
{
    public class Item
    {
        public int ID { get; set; }
        public string Moeda { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
    }
}
