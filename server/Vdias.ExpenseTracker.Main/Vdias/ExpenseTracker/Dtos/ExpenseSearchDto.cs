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
        /// Gets or sets the expense type id to filter by.
        /// </summary>
        public long? ExpenseTypeId { get; set; }

        /// <summary>
        /// Gets or sets the expense frequency id to filter by.
        /// </summary>
        public long? ExpenseFrequencyId { get; set; }

        /// <summary>
        /// Applies the filters.
        /// </summary>
        /// <param name="query">The query to which the filters will be applied.</param>
        /// <returns>The updated query</returns>
        public override IQueryable<Expense> ApplyFilter(IQueryable<Expense> query)
        {
            if (this.ExpenseFrequencyId != null)
            {
                query = query.Where(e => e.ExpenseFrequencyId == this.ExpenseFrequencyId);
            }

            if (this.ExpenseTypeId != null)
            {
                query = query.Where(e => e.ExpenseTypeId == this.ExpenseTypeId);
            }

            return query;
        }
    }
}
