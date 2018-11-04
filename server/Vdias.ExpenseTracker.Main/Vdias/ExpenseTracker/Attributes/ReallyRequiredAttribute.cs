//-----------------------------------------------------------------------
// <copyright file="ReallyRequiredAttribute.cs" company="Vinicius Dias">
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.ExpenseTracker.Attributes
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Reflection;
    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

    /// <summary>
    /// Attribute for validating objects that can't assume the value null or the default value for their type.
    /// </summary>r
    public class ReallyRequiredAttribute : ValidationAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReallyRequiredAttribute"/> class.
        /// </summary>
        public ReallyRequiredAttribute()
            : base("Field is required.")
        {
        }

        /// <summary>
        /// Checks whether the value is null or have the default have for its type. If so, returns an error.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="validationContext">The validation context.</param>
        /// <returns>The result of the validation</returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var entityType = validationContext.ObjectType;
            var propType = entityType.GetProperty(validationContext.MemberName, BindingFlags.Instance | BindingFlags.Public).PropertyType;

            // validation error if the value is null or it is a primitive type with the same value as the
            // default constructor of that primitive type.
            if (value == null
                || (propType.IsValueType && object.Equals(Activator.CreateInstance(propType), value)))
            {
                return new ValidationResult(this.ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
