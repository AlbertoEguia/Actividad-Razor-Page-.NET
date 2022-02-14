using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ActividadRazorPage.Data;
using ActividadRazorPage.Modelos;

namespace ActividadRazorPage.Pages.CarpetaDeportes
{
    public class DeleteModel : PageModel
    {
        private readonly ActividadRazorPage.Data.ActividadRazorPageContext _context;

        public DeleteModel(ActividadRazorPage.Data.ActividadRazorPageContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Deportes Deportes { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Deportes = await _context.Deportes.FirstOrDefaultAsync(m => m.ID == id);

            if (Deportes == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Deportes = await _context.Deportes.FindAsync(id);

            if (Deportes != null)
            {
                _context.Deportes.Remove(Deportes);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
