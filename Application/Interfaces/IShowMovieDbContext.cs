using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Domain.Entities;
using System.Threading;

namespace Application.Interfaces
{
    public interface IShowMovieDbContext
    {
        DbSet<Awards> Categories { get; set; }

        DbSet<People> Peoples { get; set; }

        DbSet<Genre> Genres { get; set; }

        DbSet<Language> Languages { get; set; }

        DbSet<Movie> Movies { get; set; }

        DbSet<Career> Careers { get; set; }

        DbSet<Country> Countries { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
