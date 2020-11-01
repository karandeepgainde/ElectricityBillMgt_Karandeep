using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ElectricityBillMgt_Karanbir.Biz;
using ElectricityBillMgt_Karanbir.Data;

namespace ElectricityBillMgt_Karanbir.Pages.Customers
{
    public class CreateModel : PageModel
    {
        private readonly ElectricityBillMgt_Karanbir.Data.ApplicationDbContext _context;

        public CreateModel(ElectricityBillMgt_Karanbir.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BillID"] = new SelectList(_context.Bills, "ID", "TotalBill");
        ViewData["UnitID"] = new SelectList(_context.Units, "ID", "TotalUnits");
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customers.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
