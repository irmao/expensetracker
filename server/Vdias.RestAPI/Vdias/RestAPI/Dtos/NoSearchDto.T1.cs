//-----------------------------------------------------------------------
// <copyright file="NoSearchDto.cs" company="Vinicius Dias">
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.RestAPI.Dtos
{
    using System.Linq;
    using Vdias.RestAPI.Models;

    /// <summary>
    /// DTO that does not apply any search.
    /// </summary>
    /// <typeparam name="TEntity">The type of the model that this DTO searches for.</typeparam>
    public class NoSearchDto<TEntity> : BaseSearchDto<TEntity>
        where TEntity : BaseModel
    {
        /// <summary>
        /// Returns a new IQueryable with the no DTO filters applied. That is, the query is returned as it is.
        /// </summary>
        /// <param name="query">The IQueryable to which the filters will be applied.</param>
        /// <returns>The given query without any modifications</returns>
        public override IQueryable<TEntity> ApplyFilter(IQueryable<TEntity> query) => query;
    }
}
