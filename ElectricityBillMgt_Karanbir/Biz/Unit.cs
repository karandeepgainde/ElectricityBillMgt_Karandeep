using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityBillMgt_Karanbir.Biz
{
    public class Unit
    {
        public int ID { get; set; }
        public int TotalUnits { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
