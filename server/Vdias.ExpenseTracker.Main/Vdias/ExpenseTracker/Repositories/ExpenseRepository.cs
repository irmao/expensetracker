//-----------------------------------------------------------------------
// <copyright file="ExpenseRepository.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.ExpenseTracker.Repositories
{
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Vdias.ExpenseTracker.Models;
    using Vdias.RestAPI.Repositories;

    /// <summary>
    /// Repository class for the <see cref="Expense"/> model.
    /// </summary>
    public class ExpenseRepository : BaseRepository<Expense>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseRepository"/> class.
        /// </summary>
        /// <param name="context">The db context</param>
        public ExpenseRepository(ExpenseTrackerDBContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Includes the necessary child entities into the given queryable.
        /// </summary>
        /// <param name="queryable">The queryable</param>
        public override IQueryable<Expense> Include(IQueryable<Expense> queryable)
        {
            return queryable
                .Include(i => i.Frequency)
                .Include(e => e.ExpenseType);
        }
    }
}
