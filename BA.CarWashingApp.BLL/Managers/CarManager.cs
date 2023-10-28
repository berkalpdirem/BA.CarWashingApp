using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.BLL.Managers
{
    public class CarManager : BaseManager<Car>, IService
    {
        BaseRepo<Car> _repository;
        public CarManager(BaseRepo<Car> repository) : base(repository)
        {
            _repository = repository;
        }
    }
