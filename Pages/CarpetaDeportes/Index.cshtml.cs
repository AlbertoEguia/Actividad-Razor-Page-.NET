using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ActividadRazorPage.Data;
using ActividadRazorPage.Modelos;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ActividadRazorPage.Pages.CarpetaDeportes
{
    public class IndexModel : PageModel
    {
        private readonly ActividadRazorPage.Data.ActividadRazorPageContext _context;

        public IndexModel(ActividadRazorPage.Data.ActividadRazorPageContext context)
        {
            _context = context;
        }

        public IList<Deportes> Deportes { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }




        public async Task OnGetAsync()
        {
            //Deportes = await _context.Deportes.ToListAsync();

            var movies = from m in _context.Deportes
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Nombre.Contains(SearchString));
            }

            Deportes = await movies.ToListAsync();
        }
    }
}
