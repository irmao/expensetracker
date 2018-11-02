//-----------------------------------------------------------------------
// <copyright file="Expense.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.ExpenseTracker.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Vdias.RestAPI.Models;

    /// <summary>
    /// Model that represents an expense.
    /// </summary>
    [Table("Expense")]
    public class Expense : BaseModel
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
        [Required]
        public ExpenseType ExpenseType { get; set; }

        /// <summary>
        /// Gets or sets the expense type id.
        /// </summary>
        public long ExpenseTypeId { get; set; }

        /// <summary>
        /// Gets or sets the expense frequency.
        /// </summary>
        [Required]
        public ExpenseFrequency ExpenseFrequency { get; set; }

        /// <summary>
        /// Gets or sets the expense frequency id.
        /// </summary>
        public long ExpenseFrequencyId { get; set; }
    }
}
