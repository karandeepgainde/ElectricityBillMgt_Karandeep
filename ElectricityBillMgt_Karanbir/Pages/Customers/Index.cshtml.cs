using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ElectricityBillMgt_Karanbir.Biz;
using ElectricityBillMgt_Karanbir.Data;

namespace ElectricityBillMgt_Karanbir.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly ElectricityBillMgt_Karanbir.Data.ApplicationDbContext _context;

        public IndexModel(ElectricityBillMgt_Karanbir.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers
                .Include(c => c.Bill)
                .Include(c => c.Unit).ToListAsync();
        }
    }
}
