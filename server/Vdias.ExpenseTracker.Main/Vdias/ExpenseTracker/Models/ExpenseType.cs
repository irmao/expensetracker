//-----------------------------------------------------------------------
// <copyright file="ExpenseType.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.ExpenseTracker.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Vdias.RestAPI.Models;

    /// <summary>
    /// Model that represents an expense type.
    /// </summary>
    [Table("ExpenseType")]
    public class ExpenseType : BaseModel
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [Required]
        public string Description { get; set; }
    }
}
