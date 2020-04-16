using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebCalculationPrint.Data;
using WebCalculationPrint.Models;

namespace WebCalculationPrint.Pages.Clients
{
    public class DetailsModel : PageModel
    {
        private readonly WebCalculationPrint.Data.WebCalculationPrintContext _context;

        public DetailsModel(WebCalculationPrint.Data.WebCalculationPrintContext context)
        {
            _context = context;
        }

        public Client Client { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Client = await _context.Clients.FirstOrDefaultAsync(m => m.ClientID == id);

            if (Client == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
