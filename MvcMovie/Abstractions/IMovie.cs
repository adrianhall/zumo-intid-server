namespace MvcMovie.Abstractions;

public enum MovieRating
{
    Unrated,
    G,
    PG,
    PG13,
    R,
    NC17
}

public interface IMovie
{
    /// <summary>
    /// True if the movie won the oscar for Best Picture
    /// </summary>
    bool BestPictureWinner { get; set; }

    /// <summary>
    /// The running time of the movie
    /// </summary>
    int Duration { get; set; }

    /// <summary>
    /// The MPAA rating for the movie, if available.
    /// </summary>
    MovieRating Rating { get; set; }

    /// <summary>
    /// The release date of the movie.
    /// </summary>
    DateOnly ReleaseDate { get; set; }

    /// <summary>
    /// The title of the movie.
    /// </summary>
    string Title { get; set; }

    /// <summary>
    /// The year that the movie was released.
    /// </summary>
    int Year { get; set; }
}

public static class IMovieExtensions
{
    public static void CopyTo(this IMovie source, IMovie destination)
    {
        destination.BestPictureWinner = source.BestPictureWinner;
        destination.Duration = source.Duration;
        destination.Rating = source.Rating;
        destination.ReleaseDate = source.ReleaseDate;
        destination.Title = source.Title;
        destination.Year = source.Year;
    }
}
