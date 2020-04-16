using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebCalculationPrint.Data;
using WebCalculationPrint.Models;

namespace WebCalculationPrint.Pages.Calculations
{
    public class DeleteModel : PageModel
    {
        private readonly WebCalculationPrint.Data.WebCalculationPrintContext _context;

        public DeleteModel(WebCalculationPrint.Data.WebCalculationPrintContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Calculation Calculation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Calculation = await _context.Calculation
                .Include(c => c.Colourfulness)
                .Include(c => c.Format)
                .Include(c => c.Paper).FirstOrDefaultAsync(m => m.CalculationID == id);

            if (Calculation == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Calculation = await _context.Calculation.FindAsync(id);

            if (Calculation != null)
            {
                _context.Calculation.Remove(Calculation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
