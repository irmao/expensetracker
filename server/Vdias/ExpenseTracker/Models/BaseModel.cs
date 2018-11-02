//-----------------------------------------------------------------------
// <copyright file="BaseModel.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.ExpenseTracker.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Base class for a Model.
    /// </summary>
    public class BaseModel
    {
        /// <summary>
        /// Gets or sets the identifier of the model.
        /// </summary>
        [Key]
        [Column]
        public long Id { get; set; }
    }
}
