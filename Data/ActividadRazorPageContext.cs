using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ActividadRazorPage.Modelos;

namespace ActividadRazorPage.Data
{
    public class ActividadRazorPageContext : DbContext
    {
        public ActividadRazorPageContext (DbContextOptions<ActividadRazorPageContext> options)
            : base(options)
        {
        }

        public DbSet<ActividadRazorPage.Modelos.Deportes> Deportes { get; set; }
    }
}
