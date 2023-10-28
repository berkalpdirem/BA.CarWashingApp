using BA.CarWashingApp.Entity.Abstract;
using BA.CarWashingApp.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.Entity.Concrate
{
    public class Employee : BaseEntity
    {
        public string userName { get; set; }
        public string password { get; set; }
        public employeeRole employeeRole { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int salary { get; set; }
        public DateTime enteringJob { get; set; }
        public DateTime? leaveingJob { get; set;}



    }
}
