//-----------------------------------------------------------------------
// <copyright file="BaseController{TEntity}{TSearchDto}.cs" company="Vinicius Dias">
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
    using Vdias.RestAPI.Dtos;
    using Vdias.RestAPI.Models;
    using Vdias.RestAPI.Repositories;

    /// <summary>
    /// Base class for the API controllers in the application.
    /// </summary>
    /// <typeparam name="TEntity">The entity type that will be accessed/modified through this endpoint.</typeparam>
    /// <typeparam name="TSearchDto">The search dto type that will be responsible to filter the entities to be found.</typeparam>
    [ApiController]
    public abstract class BaseController<TEntity, TSearchDto> : ControllerBase
        where TEntity : BaseModel
        where TSearchDto : BaseSearchDto<TEntity>
    {
        protected readonly BaseRepository<TEntity> repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseController{TEntity, TSearchDto}"/> class.
        /// </summary>
        /// <param name="context">The db context</param>
        protected BaseController(DbContext context) : this(context, new BaseRepository<TEntity>(context))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseController{TEntity, TSearchDto}"/> class.
        /// </summary>
        /// <param name="context">The db context</param>
        /// <param name="repository">The db repository</param>
        protected BaseController(DbContext context, BaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Returns a list with all the entities
        /// </summary>
        /// <param name="searchDto">DTO to filter the elements to be returned</param>
        /// <returns>Action Result wrapping the list of returned entities.</returns>
        /// <response code="200">Ok</response>
        [HttpGet]
        [ProducesResponseType(200)]
        public virtual ActionResult<List<TEntity>> Find([FromQuery] TSearchDto searchDto)
        {
            return new OkObjectResult(this.repository.Find(searchDto));
        }

        /// <summary>
        /// Returns the entity with the given id.
        /// </summary>
        /// <param name="id">The id of the entity to be found.</param>
        /// <returns>Action Result wrapping the entity found</returns>
        /// <response code="200">Found and returned</response>
        /// <response code="404">Not found</response>
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        public virtual ActionResult<TEntity> Find(long id)
        {
            var record = this.repository.FindOne(id);

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
        /// <response code="201">Created</response>
        /// <response code="400">Entity not valid</response>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public virtual ActionResult<TEntity> Create([FromBody] TEntity record)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            this.repository.Create(record);
            this.repository.SaveChanges();

            return this.CreatedAtAction(nameof(this.Find), new { id = record.Id }, record);
        }

        /// <summary>
        /// Updates an existing entity.
        /// </summary>
        /// <param name="id">The id of the entity to be updated.</param>
        /// <param name="record">The entity data to be updated.</param>
        /// <returns>Action result for NoContent.</returns>
        /// <response code="204">Updated. No content returned</response>
        /// <response code="400">The entity is not valid or its id does not match the url id</response>
        /// <response code="404">Not found</response>
        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public virtual ActionResult<NoContentResult> Update(long id, [FromBody] TEntity record)
        {
            if (id != record.Id || !this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            if (!this.repository.Any(id))
            {
                return this.NotFound();
            }

            this.repository.Update(record);
            this.repository.SaveChanges();

            return this.NoContent();
        }

        /// <summary>
        /// Deletes an existing entity.
        /// </summary>
        /// <param name="id">The id of the entity to be deleted.</param>
        /// <returns>ActionResult for NoContent</returns>
        /// <response code="204">Deleted. No content returned</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        public virtual ActionResult<NoContentResult> Delete(long id)
        {
            var entity = this.repository.FindOne(id);

            if (entity != null)
            {
                this.repository.Delete(entity);
                this.repository.SaveChanges();
            }

            return this.NoContent();
        }
    }
}
