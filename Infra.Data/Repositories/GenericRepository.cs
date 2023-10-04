using Domain.Interfaces.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly WebApiContext _Context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(WebApiContext context)
        {
            _Context = context;
            _dbSet = context.Set<T>();
        }

        public void Atualizar(T objeto)
        {
            _dbSet.Update(objeto);
        }

        public T BuscarPorId(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> BuscarTodosRegistros()
        {
            return _dbSet.ToList();
        }

        public void Excluir(int id)
        {
            var objeto = _dbSet.Find(id);
            if (objeto != null) _dbSet.Remove(objeto);
        }

        public void Inserir(T objeto)
        {
            _dbSet.Add(objeto);
        }
    }
}
