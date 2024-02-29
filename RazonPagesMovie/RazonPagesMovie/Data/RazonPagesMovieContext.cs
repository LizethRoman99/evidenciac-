using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazonPagesMovie.Models;

namespace RazonPagesMovie.Data
{
    public class RazonPagesMovieContext : DbContext
    {
        public RazonPagesMovieContext (DbContextOptions<RazonPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazonPagesMovie.Models.Pelicula> Pelicula { get; set; } = default!;
    }
}
