using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// Marker interface for generic repositories.
    /// </summary>
    /// <remarks>
    /// Used for type safety and to allow non-generic handling of repositories.
    /// </remarks>
    public interface IGenericRepository { }

    /// <summary>
    /// Defines basic CRUD operations for a repository of a specific entity type.
    /// </summary>
    /// <typeparam name="TEntity">The entity type.</typeparam>
    /// <remarks>
    /// This interface should be implemented by all repositories to ensure consistent data access patterns.
    /// </remarks>
    public interface IGenericRepository<TEntity> : IGenericRepository where TEntity : class
    {
        /// <summary>
        /// Retrieves all entities from the data store.
        /// </summary>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Retrieves an entity by its identifier.
        /// </summary>
        /// <param name="id">The entity identifier.</param>
        /// <returns>The entity if found; otherwise, null.</returns>
        TEntity GetById(int id);

        /// <summary>
        /// Adds a new entity to the data store.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        void Add(TEntity entity);

        /// <summary>
        /// Updates the specified entity in the data store.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        void Update(TEntity entity);

        /// <summary>
        /// Deletes the specified entity from the data store.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        void Delete(TEntity entity);

        /// <summary>
        /// Deletes an entity by its identifier.
        /// </summary>
        /// <param name="id">The identifier of the entity to delete.</param>
        void DeleteById(int id);

        /// <summary>
        /// Retrieves all entities from the data store asynchronously.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains an enumerable of all entities.</returns>
        Task<IEnumerable<TEntity>> GetAllAsync();

        /// <summary>
        /// Retrieves an entity by its identifier asynchronously.
        /// </summary>
        /// <param name="id">The entity identifier.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the entity if found; otherwise, null.</returns>
        Task<TEntity> GetByIdAsync(int id);

        /// <summary>
        /// Adds a new entity to the data store asynchronously.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task AddAsync(TEntity entity);
    }
}
