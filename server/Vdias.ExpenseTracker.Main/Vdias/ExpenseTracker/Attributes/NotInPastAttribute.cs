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

    /// <summary>
    /// Attribute for validating dates that should not be in the past.
    /// </summary>
    public class NotInPastAttribute : ValidationAttribute
    {
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

            if (date < DateTimeOffset.Now)
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }

        /// <summary>
        /// Gets the error message.
        /// </summary>
        private static string GetErrorMessage()
        {
            return "Date is in the past.";
        }
    }
}
