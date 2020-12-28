using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WiProApiFila.Dominio.Contratos;
using WiProApiFila.Dominio.Entidades;
using WiProApiFila.Repositorio.Contexto;

namespace WiProApiFila.Repositorio.Repositorios
{
    public class ItemRepositorio : BaseRepositorio<Item>, IITemRepositorio
    {
        public ItemRepositorio(WiProApiFilaContexto wiProApiFilaContexto) : base(wiProApiFilaContexto)
        {
        }

        public Item ObterProxItem()
        {
            Item item = null;
            try
            {
                item = WiProApiFilaContexto.Items.FirstOrDefault();

                if (item != null)
                {
                    WiProApiFilaContexto.Remove(item);
                    WiProApiFilaContexto.SaveChanges();
                }
                else
                {
                    throw new Exception("Item não encontrado na lista");
                }

                return item;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
