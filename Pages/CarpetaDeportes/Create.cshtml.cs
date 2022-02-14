using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ActividadRazorPage.Data;
using ActividadRazorPage.Modelos;

namespace ActividadRazorPage.Pages.CarpetaDeportes
{
    public class CreateModel : PageModel
    {
        private readonly ActividadRazorPage.Data.ActividadRazorPageContext _context;

        public CreateModel(ActividadRazorPage.Data.ActividadRazorPageContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Deportes Deportes { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Deportes.Add(Deportes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
