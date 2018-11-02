//-----------------------------------------------------------------------
// <copyright file="ExpenseRepository.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.ExpenseTracker.Repositories
{
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
    }
}
