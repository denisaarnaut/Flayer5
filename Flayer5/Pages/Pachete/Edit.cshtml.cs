using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Flayer5.Data;
using Flayer5.Models;

namespace Flayer5.Pages.Pachete
{
    public class EditModel : PageModel
    {
        private readonly Flayer5.Data.Flayer5Context _context;

        public EditModel(Flayer5.Data.Flayer5Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Pachet Pachet { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pachet = await _context.Pachet.FirstOrDefaultAsync(m => m.ID == id);

            if (Pachet == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Pachet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PachetExists(Pachet.ID))
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

        private bool PachetExists(int id)
        {
            return _context.Pachet.Any(e => e.ID == id);
        }
    }
}
