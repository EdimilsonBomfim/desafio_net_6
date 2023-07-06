using Microsoft.EntityFrameworkCore;
using TGregDemo.Domain.Core.Repositories;

namespace TGregDemo.Infrastructure.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly SqlServerContext _sqlServerContext;

        public BaseRepository(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        public void Add(TEntity obj)
        {
            try
            {
                _sqlServerContext.Set<TEntity>().Add(obj);
                _sqlServerContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _sqlServerContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(Guid id)
        {
            return _sqlServerContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            try
            {
                _sqlServerContext.Set<TEntity>().Remove(obj);
                _sqlServerContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                _sqlServerContext.Entry(obj).State = EntityState.Modified;
                _sqlServerContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
