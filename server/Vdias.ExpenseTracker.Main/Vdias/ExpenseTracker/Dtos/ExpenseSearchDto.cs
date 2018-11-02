//-----------------------------------------------------------------------
// <copyright file="ExpenseSearchDto.cs" company="Vinicius Dias">
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.ExpenseTracker.Dtos
{
    using System.Linq;
    using Vdias.ExpenseTracker.Models;
    using Vdias.RestAPI.Dtos;

    /// <summary>
    /// Search DTO for the <see cref="Expense" /> model.
    /// </summary>
    public class ExpenseSearchDto : BaseSearchDto<Expense>
    {
        /// <summary>
        /// Gets or sets the id to filter by.
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Applies the filters.
        /// </summary>
        /// <param name="query">The query to which the filters will be applied.</param>
        /// <returns>The updated query</returns>
        public override IQueryable<Expense> ApplyFilter(IQueryable<Expense> query)
        {
            if (this.Id != null)
            {
                query = query.Where(e => e.Id == this.Id);
            }

            return query;
        }
    }
}