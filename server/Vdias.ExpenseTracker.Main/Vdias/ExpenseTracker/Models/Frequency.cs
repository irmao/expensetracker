//-----------------------------------------------------------------------
// <copyright file="Frequency.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.ExpenseTracker.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Vdias.RestAPI.Models;

    /// <summary>
    /// Model that represents the frequency that an expense or income occurs.
    /// </summary>
    [Table("Frequency")]
    public class Frequency : BaseModel
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the average times that the expense occurs in a month.
        /// </summary>
        [Required]
        [Range(0, double.MaxValue)]
        public decimal AverageTimesPerMonth { get; set; }
    }
}
