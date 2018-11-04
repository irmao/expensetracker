//-----------------------------------------------------------------------
// <copyright file="Income.cs" company="Vinicius Dias">
//     All rights reserved.
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
    /// Model that represents an income.
    /// </summary>
    [Table("Income")]
    public class Income : ExpiringModel
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the frequency.
        /// </summary>
        public Frequency Frequency { get; set; }

        /// <summary>
        /// Gets or sets the frequency id.
        /// </summary>
        [ReallyRequired]
        public long FrequencyId { get; set; }

        /// <summary>
        /// Gets or sets the income value.
        /// </summary>
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Value { get; set; }
    }
}
