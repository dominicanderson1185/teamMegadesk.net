using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Team_megadesk_.net.Data;
using Team_megadesk_.net.Models;

namespace Team_megadesk_.net.Pages.DeskQuotes
{
    public class DetailsModel : PageModel
    {
        private readonly Team_megadesk_.net.Data.Team_megadesk_netContext _context;

        public DetailsModel(Team_megadesk_.net.Data.Team_megadesk_netContext context)
        {
            _context = context;
        }

        public DeskQuote DeskQuote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeskQuote = await _context.DeskQuote.FirstOrDefaultAsync(m => m.ID == id);

            if (DeskQuote == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
