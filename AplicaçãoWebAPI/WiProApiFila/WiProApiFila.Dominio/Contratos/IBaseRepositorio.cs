using System;
using System.Collections.Generic;
using System.Text;

namespace WiProApiFila.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        IEnumerable<TEntity> ObterTodos();
    }
}
