using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WiProApiFila.Dominio.Contratos;
using WiProApiFila.Repositorio.Contexto;

namespace WiProApiFila.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly WiProApiFilaContexto WiProApiFilaContexto;
        public BaseRepositorio(WiProApiFilaContexto wiProApiFilaContexto)
        {
            WiProApiFilaContexto = wiProApiFilaContexto;
        }
        public void Adicionar(TEntity entity)
        {
            WiProApiFilaContexto.Set<TEntity>().Add(entity);
            WiProApiFilaContexto.SaveChanges();
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return WiProApiFilaContexto.Set<TEntity>().ToList();
        }

        public void Dispose()
        {
            WiProApiFilaContexto.Dispose();
        }
    }
}
