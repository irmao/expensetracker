//-----------------------------------------------------------------------
// <copyright file="ExpenseController.cs" company="Vinicius Dias">
//     All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace ExpenseTracker.Controllers
{
    using ExpenseTracker.Models;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Controller class for the <see cref="Expense"/> entity.
    /// </summary>
    [ApiController]
    [Route("api/v{version:apiVersion}/expenses")]
    public class ExpenseController : ExpenseTrackerControllerBase<Expense>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseController"/> class.
        /// </summary>
        /// <param name="context">The db context</param>
        public ExpenseController(ExpenseTrackerDBContext context)
            : base(context)
        {
        }

        /// <summary>
        /// The endpoint to access this controller.
        /// </summary>
        /// <returns>The endpoint to access this controller</returns>
        public override string EndPoint()
        {
            return "expenses";
        }
    }
}
