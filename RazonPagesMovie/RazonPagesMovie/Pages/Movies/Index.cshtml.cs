using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazonPagesMovie.Data;
using RazonPagesMovie.Models;

namespace RazonPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazonPagesMovie.Data.RazonPagesMovieContext _context;

        public IndexModel(RazonPagesMovie.Data.RazonPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Pelicula> Pelicula { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Pelicula != null)
            {
                Pelicula = await _context.Pelicula.ToListAsync();
            }
        }
    }
}
