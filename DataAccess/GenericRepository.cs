using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    /// <summary>
    /// Base implementation of the generic repository pattern for CRUD operations.
    /// </summary>
    /// <typeparam name="TEntity">The entity type.</typeparam>
    /// <remarks>
    /// This abstract class provides reusable data access logic for derived repositories.
    /// It uses EF Core's DbSet for entity operations.
    /// </remarks>
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// The DbSet for the entity type.
        /// </summary>
        protected readonly DbSet<TEntity> set;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericRepository{TEntity}"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        protected GenericRepository(DbContext context) =>
            set = context.Set<TEntity>();

        /// <summary>
        /// Retrieves all entities from the data store.
        /// </summary>
        /// <returns>An enumerable of all entities.</returns>
        public virtual IEnumerable<TEntity> GetAll() => set.ToList();

        /// <summary>
        /// Retrieves an entity by its identifier.
        /// </summary>
        /// <param name="id">The entity identifier.</param>
        /// <returns>The entity if found; otherwise, null.</returns>
        /// <remarks>
        /// Uses EF Core's Find method, which may return null if the entity does not exist.
        /// </remarks>
        public virtual TEntity GetById(int id) => set.Find(id)!;

        /// <summary>
        /// Adds a new entity to the data store.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        public virtual void Add(TEntity entity) => set.Add(entity);

        /// <summary>
        /// Updates the specified entity in the data store.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        public virtual void Update(TEntity entity) => set.Update(entity);

        /// <summary>
        /// Deletes the specified entity from the data store.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        public virtual void Delete(TEntity entity) => set.Remove(entity);

        /// <summary>
        /// Deletes an entity by its identifier.
        /// </summary>
        /// <param name="id">The identifier of the entity to delete.</param>
        /// <remarks>
        /// If the entity is not found, no action is taken.
        /// </remarks>
        public virtual void DeleteById(int id)
        {
            TEntity entity = GetById(id);
            if (entity is not null)
            {
                Delete(entity);
            }
        }

        /// <summary>
        /// Retrieves all entities from the data store asynchronously.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains an enumerable of all entities.</returns>
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync() => await set.ToListAsync();

        /// <summary>
        /// Retrieves an entity by its identifier asynchronously.
        /// </summary>
        /// <param name="id">The entity identifier.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the entity if found; otherwise, null.</returns>
        public virtual async Task<TEntity> GetByIdAsync(int id) => (await set.FindAsync(id))!;

        /// <summary>
        /// Adds a new entity to the data store asynchronously.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public virtual async Task AddAsync(TEntity entity) => await set.AddAsync(entity);
    }
}
