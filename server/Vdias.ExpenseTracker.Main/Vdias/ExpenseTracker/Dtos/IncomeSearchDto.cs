//-----------------------------------------------------------------------
// <copyright file="IncomeSearchDto.cs" company="Vinicius Dias">
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.ExpenseTracker.Dtos
{
    using System;
    using System.Linq;
    using Vdias.ExpenseTracker.Extensions;
    using Vdias.ExpenseTracker.Models;
    using Vdias.RestAPI.Dtos;

    /// <summary>
    /// Search DTO for the <see cref="Income" /> model.
    /// </summary>
    public class IncomeSearchDto : BaseSearchDto<Income>
    {
        /// <summary>
        /// Gets or sets the income frequency id to filter by.
        /// </summary>
        public long? FrequencyId { get; set; }

        /// <summary>
        /// Gets or sets the start date to filter by.
        /// </summary>
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date to filter by.
        /// </summary>
        public DateTimeOffset? EndDate { get; set; }

        /// <summary>
        /// Applies the filters.
        /// </summary>
        /// <param name="query">The query to which the filters will be applied.</param>
        /// <returns>The updated query</returns>
        public override IQueryable<Income> ApplyFilter(IQueryable<Income> query)
        {
            if (this.FrequencyId != null)
            {
                query = query.Where(i => i.FrequencyId == this.FrequencyId);
            }

            if (this.StartDate != null)
            {
                query = query.Where(i => i.StartDate.StartOfDay() >= this.StartDate);
            }

            if (this.EndDate != null)
            {
                query = query.Where(i => !i.EndDate.HasValue || i.EndDate.Value.EndOfDay() <= this.EndDate);
            }

            return query;
        }
    }
}
