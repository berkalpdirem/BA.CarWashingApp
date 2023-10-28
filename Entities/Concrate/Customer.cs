using BA.CarWashingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.Entity.Concrate
{
    public class Customer : BaseEntity
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        //Navigation Properties
        public List<Car> cars { get; set; }

    }
}
