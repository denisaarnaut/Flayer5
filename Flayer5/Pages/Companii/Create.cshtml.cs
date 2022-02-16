using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Flayer5.Data;
using Flayer5.Models;

namespace Flayer5.Pages.Companii
{
    public class CreateModel : PageModel
    {
        private readonly Flayer5.Data.Flayer5Context _context;

        public CreateModel(Flayer5.Data.Flayer5Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Companie Companie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Companie.Add(Companie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
