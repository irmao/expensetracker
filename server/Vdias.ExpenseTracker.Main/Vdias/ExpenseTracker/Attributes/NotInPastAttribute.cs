//-----------------------------------------------------------------------
// <copyright file="NotInPastAttribute.cs" company="Vinicius Dias">
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.ExpenseTracker.Attributes
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
    using Vdias.ExpenseTracker.Extensions;

    /// <summary>
    /// Attribute for validating dates that should not be in the past.
    /// </summary>
    public class NotInPastAttribute : ValidationAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotInPastAttribute"/> class.
        /// </summary>
        public NotInPastAttribute()
            : base("Date in in the past")
        {
        }

        /// <summary>
        /// Validates the date in the validation context against the current date. If the date in the context is in the past,
        /// returns an error.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="validationContext">The validation context.</param>
        /// <returns>The result of the validation</returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var date = (DateTimeOffset)value;

            if (date < DateTimeOffset.Now.StartOfDay())
            {
                return new ValidationResult(this.ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
