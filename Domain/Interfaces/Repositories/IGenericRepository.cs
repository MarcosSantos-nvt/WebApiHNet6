namespace Domain.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> BuscarTodosRegistros();

        T BuscarPorId(int id);

        void Atualizar(T objeto);

        void Inserir(T objeto);

        void Excluir(int id);
    }
}
