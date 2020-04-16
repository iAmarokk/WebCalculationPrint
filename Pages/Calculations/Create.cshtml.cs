using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebCalculationPrint.Data;
using WebCalculationPrint.Models;

namespace WebCalculationPrint.Pages.Calculations
{
    public class CreateModel : PageModel
    {
        private readonly WebCalculationPrint.Data.WebCalculationPrintContext _context;

        public CreateModel(WebCalculationPrint.Data.WebCalculationPrintContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ColourfulnessID"] = new SelectList(_context.Set<Colourfulness>(), "ColourfulnessID", "Name");
        ViewData["FormatID"] = new SelectList(_context.Set<Format>(), "FormatID", "Name");
        ViewData["PaperID"] = new SelectList(_context.Set<Paper>(), "PaperID", "Name");
            return Page();
        }

        [BindProperty]
        public Calculation Calculation { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Calculations.Add(Calculation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
