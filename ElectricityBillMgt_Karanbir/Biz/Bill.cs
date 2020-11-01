using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityBillMgt_Karanbir.Biz
{
    public class Bill
    {
        public int ID { get; set; }
        public int BillNo { get; set; }
        public decimal TotalBill { get; set; }

        [DataType(DataType.Date)]
        public DateTime BillLastDate { get; set; }
        public List<Customer> Customers { get; set; }

    }
}
