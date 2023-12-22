using Microsoft.AspNetCore.Datasync;
using Microsoft.AspNetCore.Datasync.EFCore;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Abstractions;
using MvcMovie.Data;
using MvcMovie.Models;
using MvcMovie.ViewModels;

namespace MvcMovie.Mobile;

/// <summary>
/// Create a new <see cref="EntityTableRepository{TEntity}"/> for accessing the database.
/// This is the normal ctor for this repository.
/// </summary>
/// <param name="context">The <see cref="DbContext"/> for the backend store.</param>
public class MovieRepository(MvcMovieContext context) : IRepository<MobileMovie>
{
    /// <summary>
    /// The EF Core <see cref="DbContext"/> for requests to the backend.
    /// </summary>
    internal MvcMovieContext Context { get; } = context ?? throw new ArgumentNullException(nameof(context));

    /// <summary>
    /// The <see cref="DbSet{TEntity}"/> for the data set within EF Core.
    /// </summary>
    internal DbSet<Movie> DataSet { get => Context.Movie; }

    /// <summary>
    /// Returns an unexecuted <see cref="IQueryable{T}"/> that represents the data store as a whole.
    /// This is adjusted by the <see cref="TableController{TEntity}"/> to account for filtering and
    /// paging requests.
    /// </summary>
    /// <returns>An <see cref="IQueryable{T}"/> for the entities in the data store.</returns>
    public IQueryable<MobileMovie> AsQueryable() => DataSet.Select(m => new MobileMovie(m)).AsQueryable();

    /// <summary>
    /// Returns an unexecuted <see cref="IQueryable{T}"/> that represents the data store as a whole.
    /// This is adjusted by the <see cref="TableController{TEntity}"/> to account for filtering and
    /// paging requests.
    /// </summary>
    /// <returns>An <see cref="IQueryable{T}"/> for the entities in the data store.</returns>
    public Task<IQueryable<MobileMovie>> AsQueryableAsync() => Task.FromResult(AsQueryable());

    /// <summary>
    /// Creates an entity within the data store. After completion, the system properties
    /// within the entity have been updated with new values.
    /// </summary>
    /// <param name="entity">The entity to be created.</param>
    /// <param name="token">A cancellation token.</param>
    /// <exception cref="ConflictException">if the entity to be created already exists.</exception>
    /// <exception cref="RepositoryException">if an error occurs in the data store.</exception>
    public async Task CreateAsync(MobileMovie entity, CancellationToken token = default)
    {
        ArgumentNullException.ThrowIfNull(entity);
        try
        {
            if (entity.Id != null && DataSet.Any(x => x.MobileId == entity.Id))
            {
                Movie conflictingEntity = await DataSet.FirstAsync(x => x.MobileId == entity.Id, token).ConfigureAwait(false);
                throw new ConflictException(new MobileMovie(conflictingEntity));
            }
            Movie movie = entity.ToMovie();
            DataSet.Add(movie);
            await Context.SaveChangesAsync(token).ConfigureAwait(false);
        }
        catch (DbUpdateException ex)
        {
            throw new RepositoryException(ex.Message, ex);
        }
    }

    /// <summary>
    /// Removes an entity from the data store. If a <c>version</c> is provided, the version
    /// must match the entity version.
    /// </summary>
    /// <param name="id">The globally unique ID of the entity to be removed.</param>
    /// <param name="version">The (optional) version of the entity to be removed.</param>
    /// <param name="token">A cancellation token.</param>
    /// <exception cref="NotFoundException">if the entity does not exist.</exception>
    /// <exception cref="PreconditionFailedException">if the entity version does not match the provided version</exception>
    /// <exception cref="RepositoryException">if an error occurs in the data store.</exception>
    public async Task DeleteAsync(string id, byte[]? version = null, CancellationToken token = default)
    {
        if (string.IsNullOrEmpty(id))
        {
            throw new BadRequestException();
        }

        try
        {
            Movie storedEntity = await DataSet.FirstOrDefaultAsync(m => m.MobileId == id, token)
                ?? throw new NotFoundException();
            if (PreconditionFailed(version, storedEntity.Version))
            {
                throw new PreconditionFailedException(new MobileMovie(storedEntity));
            }
            DataSet.Remove(storedEntity);
            await Context.SaveChangesAsync(token).ConfigureAwait(false);
        }
        catch (DbUpdateException ex)
        {
            throw new RepositoryException(ex.Message, ex);
        }
    }

    /// <summary>
    /// Reads the entity from the data store.
    /// </summary>
    /// <remarks>
    /// It is important that the entity returned is "disconnected" from the store. Some controller
    /// methods alter the entity to conform to the new spec.  If the entity is connected to the
    /// data store, then the data store is updated at the same time, resulting in data leakage
    /// problems.
    /// </remarks>
    /// <param name="id">The globally unique ID of the entity to be read.</param>
    /// <param name="token">A cancellation token</param>
    /// <returns>The entity, or null if the entity does not exist.</returns>
    /// <exception cref="RepositoryException">if an error occurs in the data store.</exception>
    public async Task<MobileMovie> ReadAsync(string id, CancellationToken token = default)
    {
        if (string.IsNullOrEmpty(id))
        {
            throw new BadRequestException();
        }
        Movie movie = await DataSet.FirstOrDefaultAsync(m => m.MobileId == id, token)
            ?? throw new NotFoundException();
        return new MobileMovie(movie);
    }

    /// <summary>
    /// Replace the entity within the store with the provided entity.  If a <c>version</c> is
    /// specified, then the version must match.  On return, the system properties of the entity
    /// will be updated.
    /// </summary>
    /// <param name="entity">The replacement entity.</param>
    /// <param name="version">The (optional) version of the entity to be replaced</param>
    /// <param name="token">A cancellation token</param>
    /// <exception cref="BadRequestException">if the entity does not have an ID</exception>
    /// <exception cref="NotFoundException">if the entity does not exist</exception>
    /// <exception cref="ConflictException">if the entity version does not match the provided version</exception>
    /// <exception cref="RepositoryException">if an error occurs in the data store.</exception>
    public async Task ReplaceAsync(MobileMovie entity, byte[]? version = null, CancellationToken token = default)
    {
        ArgumentNullException.ThrowIfNull(entity);
        if (string.IsNullOrEmpty(entity.Id))
        {
            throw new BadRequestException();
        }

        try
        {
            Movie storedEntity = await DataSet.FirstOrDefaultAsync(m => m.MobileId == entity.Id, token)
                ?? throw new NotFoundException();
            if (PreconditionFailed(version, storedEntity.Version))
            {
                throw new PreconditionFailedException(new MobileMovie(storedEntity));
            }
            entity.CopyTo(storedEntity);
            DataSet.Update(storedEntity);
            await Context.SaveChangesAsync(token).ConfigureAwait(false);

            // Copy the stored values for the metadata back into the entity.
            entity.Version = [.. storedEntity.Version];
            entity.UpdatedAt = storedEntity.UpdatedAt ?? DateTimeOffset.UtcNow;
        }
        catch (DbUpdateException ex)
        {
            throw new RepositoryException(ex.Message, ex);
        }
    }

    /// <summary>
    /// Checks that the version provided matches the version in the database.
    /// </summary>
    /// <param name="expectedVersion">The version that was expected in the record</param>
    /// <param name="currentVersion">The current version from the record.</param>
    /// <returns>True if we need to throw a <see cref="PreconditionFailedException"/>.</returns>
    internal static bool PreconditionFailed(byte[]? expectedVersion, byte[] currentVersion)
       => expectedVersion != null && currentVersion?.SequenceEqual(expectedVersion) != true;
}
