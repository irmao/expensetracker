//-----------------------------------------------------------------------
// <copyright file="FrequencyController.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.ExpenseTracker.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Vdias.ExpenseTracker.Dtos;
    using Vdias.ExpenseTracker.Models;
    using Vdias.RestAPI.Controllers;
    using Vdias.RestAPI.Dtos;

    /// <summary>
    /// Controller class for the <see cref="Frequency"/> entity.
    /// </summary>
    [ApiController]
    [Route("api/v{version:apiVersion}/frequencies")]
    public class FrequencyController : BaseController<Frequency, NoSearchDto<Frequency>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrequencyController"/> class.
        /// </summary>
        /// <param name="context">The db context</param>
        public FrequencyController(ExpenseTrackerDBContext context)
            : base(context)
        {
        }
    }
}
