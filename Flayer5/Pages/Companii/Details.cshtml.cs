using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Flayer5.Data;
using Flayer5.Models;

namespace Flayer5.Pages.Companii
{
    public class DetailsModel : PageModel
    {
        private readonly Flayer5.Data.Flayer5Context _context;

        public DetailsModel(Flayer5.Data.Flayer5Context context)
        {
            _context = context;
        }

        public Companie Companie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Companie = await _context.Companie.FirstOrDefaultAsync(m => m.ID == id);

            if (Companie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
