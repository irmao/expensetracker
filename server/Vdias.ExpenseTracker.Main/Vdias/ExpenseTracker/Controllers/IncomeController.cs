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
    using Vdias.ExpenseTracker.Repositories;
    using Vdias.RestAPI.Controllers;
    using Vdias.RestAPI.Dtos;

    /// <summary>
    /// Controller class for the <see cref="Income"/> entity.
    /// </summary>
    [ApiController]
    [Route("api/v{version:apiVersion}/incomes")]
    public class IncomeController : BaseController<Income, IncomeSearchDto>
    {
        /// <summary>
        /// The income repository
        /// </summary>
        protected IncomeRepository incomeRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="IncomeController"/> class.
        /// </summary>
        /// <param name="context">The db context</param>
        public IncomeController(ExpenseTrackerDBContext context)
            : base(context, new IncomeRepository(context))
        {
            this.incomeRepository = this.repository as IncomeRepository;
        }

        /// <summary>
        /// Returns the sum of the 'value' property of all the incomes that match the given filter.
        /// </summary>
        /// <param name="searchDto">DTO to filter the elements to be returned</param>
        /// <returns>Action Result wrapping the sum of the 'value' property.</returns>
        /// <response code="200">Ok</response>
        [HttpGet("sum")]
        [ProducesResponseType(200)]
        public virtual ActionResult<decimal> GetValueSum([FromQuery] IncomeSearchDto searchDto)
        {
            return new OkObjectResult(this.incomeRepository.GetValueSum(searchDto));
        }
    }
}
