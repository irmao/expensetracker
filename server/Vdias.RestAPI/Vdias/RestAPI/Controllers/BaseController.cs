//-----------------------------------------------------------------------
// <copyright file="BaseController.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.RestAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Vdias.RestAPI.Models;
    using Vdias.RestAPI.Repositories;

    /// <summary>
    /// Base class for the API controllers in the application.
    /// </summary>
    /// <typeparam name="TEntity">The entity type that will be accessed/modified through this endpoint.</typeparam>
    [ApiController]
    public abstract class BaseController<TEntity> : ControllerBase
        where TEntity : BaseModel
    {
        private readonly BaseRepository<TEntity> repository;

        private readonly DbContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseController{TEntity}"/> class.
        /// </summary>
        /// <param name="context">The db context</param>
        public BaseController(DbContext context)
        {
            this.repository = new BaseRepository<TEntity>(context);
            this.context = context;
        }

        /// <summary>
        /// Returns a list with all the entities
        /// </summary>
        /// <returns>Action Result wrapping the list of returned entities.</returns>
        [HttpGet]
        public virtual ActionResult<List<TEntity>> Find()
        {
            return new OkObjectResult(this.repository.Find());
        }

        /// <summary>
        /// Returns the entity with the given id.
        /// </summary>
        /// <param name="id">The id of the entity to be found.</param>
        /// <returns>Action Result wrapping the entity found</returns>
        [HttpGet("{id}")]
        public virtual ActionResult<TEntity> Find(long id)
        {
            var record = this.repository.Find(id);

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
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            this.repository.Create(record);
            this.context.SaveChanges();

            return this.CreatedAtAction(nameof(Find), new { id = record.Id }, record);
        }
    }
}
