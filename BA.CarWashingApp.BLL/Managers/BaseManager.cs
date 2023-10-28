using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.BLL.Managers
{
    public class BaseManager<T> : IService<T> where T : class, IEntity
    {
        protected BaseRepo<T> _repository;

        public BaseManager(BaseRepo<T> repository)
        {
            _repository = repository;
        }
        public void Delete(T entity) => _repository.Delete(entity);

        public IEnumerable<T> GetAll() => _repository.GetAll();

        public T GetById(int id) => _repository.GetById(id);

        public void Insert(T entity) => _repository.Insert(entity);
        public void SaveChanges() => _repository.SaveChanges();

        public void Update(T entity) => SaveChanges();

    }
}
