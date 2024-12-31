using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interface.Repository;
using Core.Service;

namespace Service
{
    public abstract class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        protected ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);

        }

        public async Task AddAsync(TEntity obj)
        {
            await _repository.AddAsync(obj);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
        public void Delete(TEntity obj)
        {
            _repository.Delete(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
