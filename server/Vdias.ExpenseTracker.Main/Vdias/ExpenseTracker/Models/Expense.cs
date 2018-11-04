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
    using Vdias.ExpenseTracker.Attributes;
    using Vdias.RestAPI.Models;

    /// <summary>
    /// Model that represents an expense.
    /// </summary>
    [Table("Expense")]
    public class Expense : ExpiringModel
    {
        /// <summary>
        /// Gets or sets the expense value.
        /// </summary>
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Value { get; set; }

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
        public ExpenseType ExpenseType { get; set; }

        /// <summary>
        /// Gets or sets the expense type id.
        /// </summary>
        [ReallyRequired]
        public long ExpenseTypeId { get; set; }

        /// <summary>
        /// Gets or sets the expense frequency.
        /// </summary>
        public Frequency Frequency { get; set; }

        /// <summary>
        /// Gets or sets the expense frequency id.
        /// </summary>
        [ReallyRequired]
        public long FrequencyId { get; set; }
    }
}
