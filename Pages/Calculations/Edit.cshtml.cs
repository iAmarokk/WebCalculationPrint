using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebCalculationPrint.Data;
using WebCalculationPrint.Models;

namespace WebCalculationPrint.Pages.Calculations
{
    public class EditModel : PageModel
    {
        private readonly WebCalculationPrint.Data.WebCalculationPrintContext _context;

        public EditModel(WebCalculationPrint.Data.WebCalculationPrintContext context)
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
           ViewData["ColourfulnessID"] = new SelectList(_context.Set<Colourfulness>(), "ColourfulnessID", "ColourfulnessID");
           ViewData["FormatID"] = new SelectList(_context.Set<Format>(), "FormatID", "FormatID");
           ViewData["PaperID"] = new SelectList(_context.Set<Paper>(), "PaperID", "PaperID");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Calculation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalculationExists(Calculation.CalculationID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CalculationExists(int id)
        {
            return _context.Calculation.Any(e => e.CalculationID == id);
        }
    }
}
