namespace Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWorkPersistence
    {
        void BeginTransaction();
        bool SaveTransaction();
        bool CommitTransaction();
        void RollBackTransaction();
        bool Commit();
    }
}
