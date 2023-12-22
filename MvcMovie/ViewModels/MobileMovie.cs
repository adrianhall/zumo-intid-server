using Microsoft.AspNetCore.Datasync;
using MvcMovie.Abstractions;
using MvcMovie.Models;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.ViewModels;

public class MobileMovie : ITableData, IMovie
{
    public MobileMovie()
    {
    }

    public MobileMovie(Movie m)
    {
        Id = m.MobileId;
        Version = [.. m.Version];
        UpdatedAt = m.UpdatedAt ?? DateTimeOffset.UtcNow;
        Deleted = m.Deleted;
        m.CopyTo(this);
    }
    public Movie ToMovie()
    {
        return new Movie()
        {
            MobileId = Id,
            Version = [.. Version],
            UpdatedAt = UpdatedAt,
            Deleted = Deleted,
            BestPictureWinner = BestPictureWinner,
            Duration = Duration,
            Rating = Rating,
            ReleaseDate = ReleaseDate,
            Title = Title,
            Year = Year
        };
    }

    #region IMovie
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
    [Required]
    public DateOnly ReleaseDate { get; set; }

    /// <summary>
    /// The title of the movie.
    /// </summary>
    [Required]
    [StringLength(250, MinimumLength = 1)]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// The year that the movie was released.
    /// </summary>
    public int Year { get; set; }
    #endregion

    #region ITableData
    /// <inheritdoc />
    public string Id { get; set; } = Guid.NewGuid().ToString("N");

    /// <inheritdoc />
    public byte[] Version { get; set; } = [];

    /// <inheritdoc />
    public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;

    /// <inheritdoc />
    public bool Deleted { get; set; }
    #endregion

    public bool Equals(ITableData? other)
        => other != null && Id == other.Id && Version.SequenceEqual(other.Version);
}
