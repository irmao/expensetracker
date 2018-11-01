//-----------------------------------------------------------------------
// <copyright file="RepositoryBase.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace vdias.ExpenseTracker.Repositories
{
    using System.Linq;
    using vdias.ExpenseTracker.Models;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Base class for a generic repository.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity being stored.</typeparam>
    public class RepositoryBase<TEntity>
        where TEntity : ModelBase
    {
        /// <summary>
        /// The ExpenseTracker db context.
        /// </summary>
        private readonly ExpenseTrackerDBContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryBase{TEntity}"/> class.
        /// </summary>
        /// <param name="context">The context</param>
        public RepositoryBase(ExpenseTrackerDBContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Returns an IQueryable with all the elements in the database.
        /// </summary>
        /// <returns>An IQueryable with all the elements in the database</returns>
        public virtual IQueryable<TEntity> GetAll()
        {
            return this.context.Set<TEntity>();
        }

        /// <summary>
        /// Gets a single element with the given id.
        /// </summary>
        /// <param name="id">The id of the element to be found.</param>
        /// <returns>The element</returns>
        public virtual TEntity GetOne(long id)
        {
            return this.GetAll().SingleOrDefault(e => e.Id == id);
        }

        /// <summary>
        /// Adds to the database a new record.
        /// </summary>
        /// <param name="record">The record to be added.</param>
        public virtual void Create(TEntity record)
        {
            this.context.Add(record);
        }
    }
}
