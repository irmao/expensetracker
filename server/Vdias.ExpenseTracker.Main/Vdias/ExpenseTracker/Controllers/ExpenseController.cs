//-----------------------------------------------------------------------
// <copyright file="ExpenseController.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vdias.ExpenseTracker.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Vdias.ExpenseTracker.Dtos;
    using Vdias.ExpenseTracker.Models;
    using Vdias.ExpenseTracker.Repositories;
    using Vdias.RestAPI.Controllers;

    /// <summary>
    /// Controller class for the <see cref="Expense"/> entity.
    /// </summary>
    [ApiController]
    [Route("api/v{version:apiVersion}/expenses")]
    public class ExpenseController : BaseController<Expense, ExpenseSearchDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseController"/> class.
        /// </summary>
        /// <param name="context">The db context</param>
        public ExpenseController(ExpenseTrackerDBContext context)
            : base(context, new ExpenseRepository(context))
        {
        }
    }
}
