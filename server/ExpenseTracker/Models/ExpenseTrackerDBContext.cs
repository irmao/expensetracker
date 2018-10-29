//-----------------------------------------------------------------------
// <copyright file="ExpenseTrackerDBContext.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace ExpenseTracker.Models
{
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// The DB Context for the ExpenseTracker application.
    /// </summary>
    public class ExpenseTrackerDBContext : DbContext
    {
        /// <summary>
        /// Gets or sets the Expenses db reference.
        /// </summary>
        public DbSet<Expense> Expenses { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseTrackerDBContext"/> class.
        /// </summary>
        /// <param name="options">The options</param>
        public ExpenseTrackerDBContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
