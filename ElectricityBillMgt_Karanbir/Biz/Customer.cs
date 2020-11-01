using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityBillMgt_Karanbir.Biz
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int BillID { get; set; }
        public int UnitID { get; set; }
        public Unit Unit { get; set; }
        public Bill Bill { get; set; }
    }
}
