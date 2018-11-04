//-----------------------------------------------------------------------
// <copyright file="ExpiringModel.cs" company="Vinicius Dias">
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.ExpenseTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Vdias.ExpenseTracker.Attributes;
    using Vdias.RestAPI.Models;

    /// <summary>
    /// Base class for models that have an start and an optional end date.
    /// </summary>
    public class ExpiringModel : BaseModel
    {
        /// <summary>
        /// Gets or sets the Start Date
        /// </summary>
        [Required]
        [NotInPast]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// Gets or sets the End Date
        /// </summary>
        public DateTimeOffset? EndDate { get; set; }

        /// <summary>
        /// Validates the model.
        /// </summary>
        /// <param name="validationContext">The validation context.</param>
        /// <returns>An IEnumerable with the validation errors.</returns>
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.EndDate != null && this.StartDate > this.EndDate.Value)
            {
                yield return new ValidationResult("The Start Date must be before the End Date.");
            }
        }
    }
}
