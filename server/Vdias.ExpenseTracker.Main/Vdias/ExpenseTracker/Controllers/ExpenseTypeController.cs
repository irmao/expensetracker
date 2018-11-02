//-----------------------------------------------------------------------
// <copyright file="ExpenseTypeController.cs" company="Vinicius Dias">
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
    /// Controller class for the <see cref="ExpenseType"/> entity.
    /// </summary>
    [ApiController]
    [Route("api/v{version:apiVersion}/expensetypes")]
    public class ExpenseTypeController : BaseController<ExpenseType, NoSearchDto<ExpenseType>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseTypeController"/> class.
        /// </summary>
        /// <param name="context">The db context</param>
        public ExpenseTypeController(ExpenseTrackerDBContext context)
            : base(context)
        {
        }
    }
}
