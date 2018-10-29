//-----------------------------------------------------------------------
// <copyright file="ExpenseTrackerControllerBase.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace ExpenseTracker.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ExpenseTracker.Models;
    using ExpenseTracker.Repositories;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Base class for the API controllers in the application.
    /// </summary>
    /// <typeparam name="TEntity">The entity type that will be accessed/modified through this endpoint.</typeparam>
    [ApiController]
    public abstract class ExpenseTrackerControllerBase<TEntity> : ControllerBase
        where TEntity : ModelBase
    {
        private RepositoryBase<TEntity> repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseTrackerControllerBase{TEntity}"/> class.
        /// </summary>
        /// <param name="context">The db context</param>
        public ExpenseTrackerControllerBase(ExpenseTrackerDBContext context)
        {
            this.repository = new RepositoryBase<TEntity>(context);
        }

        /// <summary>
        /// Returns a list with all the entities
        /// </summary>
        /// <returns>Action Result wrapping the list of returned entities.</returns>
        [HttpGet]
        public virtual ActionResult<List<TEntity>> GetAll()
        {
            return new OkObjectResult(this.repository.GetAll());
        }

        /// <summary>
        /// Returns the entity with the given id.
        /// </summary>
        /// <param name="id">The id of the entity to be found.</param>
        /// <returns>Action Result wrapping the entity found</returns>
        [HttpGet("id")]
        public virtual ActionResult<TEntity> GetOne(long id)
        {
            var record = this.repository.GetOne(id);

            if (record == null)
            {
                return this.NotFound();
            }

            return new OkObjectResult(record);
        }

        /// <summary>
        /// Creates a new entity with the given data.
        /// </summary>
        /// <param name="record">The entity data to be created.</param>
        /// <returns>Action result containing the data of the entity just created.</returns>
        [HttpPost]
        public virtual ActionResult<TEntity> Create([FromBody] TEntity record)
        {
            this.repository.Create(record);
            return new CreatedAtActionResult("GetOne", this.EndPoint(), new { id = record.Id }, record);
        }

        /// <summary>
        /// Abstract method that returns the endpoint of the controller which is implementing this base class.
        /// </summary>
        /// <returns>A string with the controller's endpoint.</returns>
        public abstract string EndPoint();
    }
}
