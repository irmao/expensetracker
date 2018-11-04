//-----------------------------------------------------------------------
// <copyright file="ExpenseTrackerDBContext.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.ExpenseTracker.Models
{
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// The DB Context for the ExpenseTracker application.
    /// </summary>
    public class ExpenseTrackerDBContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseTrackerDBContext"/> class.
        /// </summary>
        /// <param name="options">The options</param>
        public ExpenseTrackerDBContext(DbContextOptions options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the Expenses db reference.
        /// </summary>
        public DbSet<Expense> Expenses { get; set; }

        /// <summary>
        /// Gets or sets the Expense Types db reference.
        /// </summary>
        public DbSet<ExpenseType> ExpenseTypess { get; set; }

        /// <summary>
        /// Gets or sets the Frequencies db reference.
        /// </summary>
        public DbSet<Frequency> Frequencies { get; set; }

        /// <summary>
        /// Gets or sets the Incomes db reference.
        /// </summary>
        public DbSet<Income> Incomes { get; set; }
    }
}
