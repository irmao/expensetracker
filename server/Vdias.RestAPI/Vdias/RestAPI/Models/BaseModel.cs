//-----------------------------------------------------------------------
// <copyright file="BaseModel.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.RestAPI.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    /// <summary>
    /// Base class for a Model.
    /// </summary>
    public class BaseModel : IValidatableObject
    {
        /// <summary>
        /// Gets or sets the identifier of the model.
        /// </summary>
        [Key]
        [Column]
        public long Id { get; set; }

        /// <summary>
        /// Validates the model.
        /// </summary>
        /// <param name="validationContext">The validation context.</param>
        /// <returns>An enumerable with the validation errors.</returns>
        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return Enumerable.Empty<ValidationResult>();
        }
    }
}
