using System;
using System.Collections.Generic;
using System.Text;
using WiProApiFila.Dominio.Entidades;

namespace WiProApiFila.Dominio.Contratos
{
    public interface IITemRepositorio : IBaseRepositorio<Item>
    {
        Item ObterProxItem();
    }
}
