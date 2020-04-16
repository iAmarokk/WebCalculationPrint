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
    public class IndexModel : PageModel
    {
        private readonly WebCalculationPrint.Data.WebCalculationPrintContext _context;

        public IndexModel(WebCalculationPrint.Data.WebCalculationPrintContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; }

        public async Task OnGetAsync()
        {
            Client = await _context.Clients.ToListAsync();
        }
    }
}
