//-----------------------------------------------------------------------
// <copyright file="IncomeController.cs" company="Vinicius Dias">
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
    /// Controller class for the <see cref="Income"/> entity.
    /// </summary>
    [ApiController]
    [Route("api/v{version:apiVersion}/incomes")]
    public class IncomeController : BaseController<Income, NoSearchDto<Income>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomeController"/> class.
        /// </summary>
        /// <param name="context">The db context</param>
        public IncomeController(ExpenseTrackerDBContext context)
            : base(context)
        {
        }
    }
}
