using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext(DbContextOptions<MvcMovieContext> options) : DbContext(options)
    {
        public DbSet<Movie> Movie => Set<Movie>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .Property(m => m.Rating)
                .HasConversion(new EnumToStringConverter<MovieRating>());

            modelBuilder.Entity<Movie>()
                .HasIndex(m => new { m.BestPictureWinner, m.Duration, m.Rating, m.ReleaseDate, m.Title, m.Year });

            modelBuilder.Entity<Movie>()
                .HasData(Movies.MovieList);

            base.OnModelCreating(modelBuilder);
        }
    }
}
