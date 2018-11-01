//-----------------------------------------------------------------------
// <copyright file="ExpenseType.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace vdias.ExpenseTracker.Models
{
    /// <summary>
    /// Model that represents an expense type.
    /// </summary>
    public class ExpenseType : ModelBase
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }
    }
}
