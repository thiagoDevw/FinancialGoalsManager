using FinancialGoalsManager.Service;
using Microsoft.AspNetCore.Mvc;

namespace FinancialGoalsManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly FinancialObjectiveService _service;

        public TransactionController(FinancialObjectiveService service)
        {
            _service = service;
        }

        // GET: api/transaction
        [HttpGet]
        public async Task<IActionResult> GetAllTransactions()
        {
            return Ok();
        }
    }
}
