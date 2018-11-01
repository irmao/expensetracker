//-----------------------------------------------------------------------
// <copyright file="ExpenseFrequency.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace vdias.ExpenseTracker.Models
{
    /// <summary>
    /// Model that represents the frequency that the expense occurs.
    /// </summary>
    public class ExpenseFrequency : ModelBase
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the average times that the expense occurs in a month.
        /// </summary>
        public decimal AverageTimesPerMonth { get; set; }
    }
}