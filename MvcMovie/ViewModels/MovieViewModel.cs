using MvcMovie.Abstractions;
using MvcMovie.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.ViewModels;

public class MovieViewModel : IMovie
{
    public MovieViewModel()
    {
    }

    public MovieViewModel(Movie m)
    {
        Id = m.Id;
        BestPictureWinner = m.BestPictureWinner;
        Duration = m.Duration;
        Rating = m.Rating;
        ReleaseDate = m.ReleaseDate;
        Title = m.Title;
        Year = m.Year;
    }

    public Movie ToMovie()
    {
        return new Movie()
        {
            Id = Id,
            BestPictureWinner = BestPictureWinner,
            Duration = Duration,
            Rating = Rating,
            ReleaseDate = ReleaseDate,
            Title = Title,
            Year = Year
        };
    }

    /// <summary>
    /// A application specific unique identifier for the movie.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// True if the movie won the oscar for Best Picture
    /// </summary>
    public bool BestPictureWinner { get; set; }

    /// <summary>
    /// The running time of the movie
    /// </summary>
    [Required]
    [Range(30, 360)]
    public int Duration { get; set; }

    /// <summary>
    /// The MPAA rating for the movie, if available.
    /// </summary>
    public MovieRating Rating { get; set; } = MovieRating.Unrated;

    /// <summary>
    /// The release date of the movie.
    /// </summary>
    [DisplayName("Release Date")]
    [DataType(DataType.Date)]
    [Required]
    public DateOnly ReleaseDate { get; set; }

    /// <summary>
    /// The title of the movie.
    /// </summary>
    [Required]
    [StringLength(250, MinimumLength = 1)]
    public string Title { get; set; } = "";

    /// <summary>
    /// The year that the movie was released.
    /// </summary>
    public int Year { get; set; }
}
