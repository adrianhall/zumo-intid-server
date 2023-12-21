using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public enum MovieRating
{
    Unrated,
    G,
    PG,
    PG13,
    R,
    NC17
}

public class Movie
{
    /// <summary>
    /// A application specific unique identifier for the movie.
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// True if the movie won the oscar for Best Picture
    /// </summary>
    public bool BestPictureWinner { get; set; }

    /// <summary>
    /// The running time of the movie
    /// </summary>
    public int Duration { get; set; }

    /// <summary>
    /// The MPAA rating for the movie, if available.
    /// </summary>
    public MovieRating Rating { get; set; } = MovieRating.Unrated;

    /// <summary>
    /// The release date of the movie.
    /// </summary>
    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateOnly ReleaseDate { get; set; }

    /// <summary>
    /// The title of the movie.
    /// </summary>
    public string Title { get; set; } = "";

    /// <summary>
    /// The year that the movie was released.
    /// </summary>
    public int Year { get; set; }
}
