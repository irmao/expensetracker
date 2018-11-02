//-----------------------------------------------------------------------
// <copyright file="BaseRepository.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.RestAPI.Repositories
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Vdias.RestAPI.Dtos;
    using Vdias.RestAPI.Models;

    /// <summary>
    /// Base class for a generic repository.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity being stored.</typeparam>
    public class BaseRepository<TEntity>
        where TEntity : BaseModel
    {
        /// <summary>
        /// The db context.
        /// </summary>
        private readonly DbContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository{TEntity}"/> class.
        /// </summary>
        /// <param name="context">The context</param>
        public BaseRepository(DbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Returns an IQueryable with all the elements in the database that match the given filters.
        /// </summary>
        /// <param name="dto">The search dto that will apply the filters.</param>
        /// <returns>An IQueryable with all the elements in the database</returns>
        public virtual IQueryable<TEntity> Find(BaseSearchDto<TEntity> dto)
        {
            return dto.ApplyFilter(this.context.Set<TEntity>());
        }

        /// <summary>
        /// Finds a single element with the given id.
        /// </summary>
        /// <param name="id">The id of the element to be found.</param>
        /// <returns>The element</returns>
        public virtual TEntity FindOne(long id)
        {
            return this.context.Set<TEntity>().SingleOrDefault(e => e.Id == id);
        }

        /// <summary>
        /// Checks whether an entity with the given id exists in the database.
        /// </summary>
        /// <param name="id">The id of the element to be found.</param>
        /// <returns>True if the element is present in the db, false otherwise.</returns>
        public virtual bool Any(long id)
        {
            return this.context.Set<TEntity>().Any(e => e.Id == id);
        }

        /// <summary>
        /// Adds to the database a new record.
        /// </summary>
        /// <param name="record">The record to be added.</param>
        public virtual void Create(TEntity record)
        {
            this.context.Add(record);
        }

        /// <summary>
        /// Updates an existing record in to the database.
        /// </summary>
        /// <param name="record">The record to be updated.</param>
        public virtual void Update(TEntity record)
        {
            this.context.Update(record);
        }

        /// <summary>
        /// Deletes an existing record.
        /// </summary>
        /// <param name="record">Record to be deleted.</param>
        public virtual void Delete(TEntity record)
        {
            this.context.Remove(record);
        }

        /// <summary>
        /// Saves the changes made in the context.
        /// </summary>
        /// <returns>The code returned by the db context save changes.</returns>
        public virtual int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        /// <summary>
        /// Saves the changes made in the context asynchrosnously.
        /// </summary>
        /// <returns>The task that resolves to the code returned by the db context save changes.</returns>
        public virtual Task<int> SaveChangesAsync()
        {
            return this.context.SaveChangesAsync();
        }
    }
}
