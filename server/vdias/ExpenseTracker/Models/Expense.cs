//-----------------------------------------------------------------------
// <copyright file="Expense.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace vdias.ExpenseTracker.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Model that represents an expense.
    /// </summary>
    [Table("Expense")]
    public class Expense : ModelBase
    {
        /// <summary>
        /// Gets or sets the expense value.
        /// </summary>
        [Required]
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or sets the date that the value was expended.
        /// </summary>
        [Required]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the expense description.
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the expense comment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the expense type.
        /// </summary>
        // public ExpenseType ExpenseType { get; set; }

        /// <summary>
        /// Gets or sets the expense frequency.
        /// </summary>
        // public ExpenseFrequency ExpenseFrequency { get; set; }
    }
}
