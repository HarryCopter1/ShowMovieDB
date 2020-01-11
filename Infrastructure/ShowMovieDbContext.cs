
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Domain.Entities;
using Application.Interfaces;

namespace Infrastructure
{
    public class ShowMovieDbContext : DbContext, IShowMovieDbContext
    { 
        public ShowMovieDbContext (DbContextOptions<ShowMovieDbContext> options)
               : base(options)
        {
        }

        public DbSet<Award> Categories { get; set; }

        public DbSet<People> Peoples { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Career> Careers { get; set; }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ShowMovieDbContext).Assembly);
        }
    }
}
