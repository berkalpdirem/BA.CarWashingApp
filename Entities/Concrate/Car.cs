using BA.CarWashingApp.Entity.Abstract;
using BA.CarWashingApp.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.Entity.Concrate
{
    public class Car : BaseEntity
    {
        
        public string plate { get; set; }

        public string brand { get; set; }

        public string model { get; set; }

        public Colour colour { get; set; }

        public CarType carType { get; set; }

        public PollutionStatus polution { get; set; }

        //Navigation Prop

        //Customer-Car Relation
        public Customer customer { get; set; }
        public int customerID { get; set; }

        //Washing-Car Relation
        public Washing washing { get; set; }
        public int washingID { get; set; }


    }
}
