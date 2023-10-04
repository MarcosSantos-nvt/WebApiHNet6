using Domain.Interfaces.UnitOfWork;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore.Storage;

namespace Infra.Data.UnitOfWork
{
    public class UnitOfWorkPersistence : IUnitOfWorkPersistence
    {
        private readonly WebApiContext _webApiContext;
        private IDbContextTransaction _dbContextTransaction;

        public UnitOfWorkPersistence(WebApiContext webApiContext) => (_webApiContext) = (webApiContext);
        public void BeginTransaction()
        {
            if (_webApiContext == null) throw new ArgumentException("Não é possivel iniciar uma transação. O context está nulo.");

            _dbContextTransaction = _webApiContext.Database.BeginTransaction();
        }

        public bool Commit()
        {
            try
            {
                _webApiContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CommitTransaction()
        {
            if (_dbContextTransaction == null) throw new ArgumentException("Não é possível finalizar a transação.A transação está nula.");

            try
            {
                _dbContextTransaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void RollBackTransaction()
        {
            if (_dbContextTransaction == null) throw new ArgumentException("Não é possível dar rollback na transação.A transação está nula.");

            try
            {
                _dbContextTransaction.Rollback();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Não foi possível retornar a transação." + ex.Message);
            }
        }

        public bool SaveTransaction()
        {
            if (_webApiContext == null) throw new ArgumentException("Não é possível salvar a transação. O contexto está nulo.");
            else if (_dbContextTransaction == null) throw new ArgumentException("Não é possível salvar a transação. A transação está nula.");

            try
            {
                _webApiContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
