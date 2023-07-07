using TGregDemo.Domain.Core.Repositories;
using TGregDemo.Domain.Core.Services;

namespace TGregDemo.Domain.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public void Add(TEntity obj)
        {
            _baseRepository.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _baseRepository.GetAll();
        }

        public TEntity GetById(Guid id)
        {
            return _baseRepository.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _baseRepository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _baseRepository.Update(obj);
        }
    }
}