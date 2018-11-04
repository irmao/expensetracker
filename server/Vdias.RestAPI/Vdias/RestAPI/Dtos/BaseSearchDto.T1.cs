//-----------------------------------------------------------------------
// <copyright file="BaseSearchDto{TEntity}.cs" company="Vinicius Dias">
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.RestAPI.Dtos
{
    using System.Linq;
    using Vdias.RestAPI.Models;

    /// <summary>
    /// Abstract base for DTOs used for searching in a GET requests.
    /// </summary>
    /// <typeparam name="TEntity">The type of the model that this DTO searches for.</typeparam>
    public abstract class BaseSearchDto<TEntity>
        where TEntity : BaseModel
    {
        /// <summary>
        /// Returns a new IQueryable with the DTO filters applied.
        /// </summary>
        /// <param name="query">The IQueryable to which the filters will be applied.</param>
        /// <returns>The updated IQueryable</returns>
        public abstract IQueryable<TEntity> ApplyFilter(IQueryable<TEntity> query);
    }
}
