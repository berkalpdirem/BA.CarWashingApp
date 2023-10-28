using BA.CarWashingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.Entity.Concrate
{
    public class StockItem : BaseEntity
    {
        public string name { get; set; }
        public double quantity { get; set; }
        public double stockLimit { get; set; }
    }
}
