using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ElectricityBillMgt_Karanbir.Biz;
using ElectricityBillMgt_Karanbir.Data;

namespace ElectricityBillMgt_Karanbir.Pages.Bills
{
    public class DetailsModel : PageModel
    {
        private readonly ElectricityBillMgt_Karanbir.Data.ApplicationDbContext _context;

        public DetailsModel(ElectricityBillMgt_Karanbir.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Bill Bill { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bill = await _context.Bills.FirstOrDefaultAsync(m => m.ID == id);

            if (Bill == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
