//-----------------------------------------------------------------------
// <copyright file="ExpenseType.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.ExpenseTracker.Models
{
    using Vdias.RestAPI.Models;

    /// <summary>
    /// Model that represents an expense type.
    /// </summary>
    public class ExpenseType : BaseModel
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }
    }
}
