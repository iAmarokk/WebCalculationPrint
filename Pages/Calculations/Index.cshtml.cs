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
    public class IndexModel : PageModel
    {
        private readonly WebCalculationPrint.Data.WebCalculationPrintContext _context;

        public IndexModel(WebCalculationPrint.Data.WebCalculationPrintContext context)
        {
            _context = context;
        }

        public IList<Calculation> Calculation { get;set; }

        public async Task OnGetAsync()
        {
            Calculation = await _context.Calculations
                .Include(c => c.Colourfulness)
                .Include(c => c.Format)
                .Include(c => c.Paper).ToListAsync();
        }
    }
}
