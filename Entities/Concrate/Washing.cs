using BA.CarWashingApp.Entity.Abstract;
using BA.CarWashingApp.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.Entity.Concrate
{
    public class Washing : BaseEntity
    {
        public int washLine { get; set; }
        public WashArea washArea { get; set; }
        public WashType washType { get; set; }

        public DateTime washingStart { get; set; }
        public DateTime washingEnd { get; set; }
        public Station washingStation { get; set; }


        //Navigation Properties
        
        //Washing-Car Relation
        public Car car { get; set; }
        public int carID { get; set; }

        //Washing-Employee Relation
        public Employee employee { get; set; }
        public int employeeID { get; set; }

        //Washing-Stokİtem Relation
        public List<StockItem> usingItems { get; set; }


    }
}
