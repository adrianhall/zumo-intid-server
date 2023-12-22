using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Abstractions;
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

            #region Mobile Adjustments
            modelBuilder.Entity<Movie>().Property(m => m.MobileId)
                .HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Movie>().Property(m => m.UpdatedAt)
                .HasDefaultValueSql("GETUTCDATE()");
            modelBuilder.Entity<Movie>()
                .HasIndex(m => m.MobileId).IsUnique();
            modelBuilder.Entity<Movie>()
                .HasIndex(m => m.UpdatedAt);
            modelBuilder.Entity<Movie>()
                .HasIndex(m => m.Deleted);
            #endregion

            modelBuilder.Entity<Movie>()
                .HasData(Movies.MovieList);

            base.OnModelCreating(modelBuilder);
        }
    }
}
