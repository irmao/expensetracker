//-----------------------------------------------------------------------
// <copyright file="IncomeRepository.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.ExpenseTracker.Repositories
{
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Vdias.ExpenseTracker.Models;
    using Vdias.RestAPI.Dtos;
    using Vdias.RestAPI.Repositories;

    /// <summary>
    /// Repository class for the <see cref="Income"/> model.
    /// </summary>
    public class IncomeRepository : BaseRepository<Income>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomeRepository"/> class.
        /// </summary>
        /// <param name="context">The db context</param>
        public IncomeRepository(ExpenseTrackerDBContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Includes the necessary child entities into the given queryable.
        /// </summary>
        /// <param name="queryable">The queryable</param>
        public override IQueryable<Income> Include(IQueryable<Income> queryable)
        {
            return queryable.Include(i => i.Frequency);
        }

        /// <summary>
        /// Returns the sum of the values of all Incomes that match the given filter.
        /// </summary>
        /// <param name="dto">The search dto that will apply the filters.</param>
        /// <returns>The sum of the 'value' property of the returned items.</returns>
        public virtual decimal GetValueSum(BaseSearchDto<Income> dto)
        {
            return this.Find(dto).Sum(i => i.Value);
        }
    }
}
