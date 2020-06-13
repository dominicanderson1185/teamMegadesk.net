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
    public class IndexModel : PageModel
    {
        private readonly Team_megadesk_.net.Data.Team_megadesk_netContext _context;

        public IndexModel(Team_megadesk_.net.Data.Team_megadesk_netContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }

        public async Task OnGetAsync()
        {
            DeskQuote = await _context.DeskQuote.ToListAsync();
        }
    }
}
