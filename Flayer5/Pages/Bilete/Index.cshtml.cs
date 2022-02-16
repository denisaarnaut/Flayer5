using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Flayer5.Data;
using Flayer5.Models;

namespace Flayer5.Pages.Bilete
{
    public class IndexModel : PageModel
    {
        private readonly Flayer5.Data.Flayer5Context _context;

        public IndexModel(Flayer5.Data.Flayer5Context context)
        {
            _context = context;
        }

        public IList<Bilet> Bilet { get;set; }

        public async Task OnGetAsync()
        {
            Bilet = await _context.Bilet
                .Include(b=>b.Companie)
                .ToListAsync();
        }
    }
}
