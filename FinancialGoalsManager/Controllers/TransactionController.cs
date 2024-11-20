using FinancialGoalsManager.Application.Models.Transaction;
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

        // GET: api/transactions
        [HttpGet]
        public async Task<IActionResult> GetAllTransactions()
        {
            // Chamar o serviço para pegar todas as transações


            return Ok();
        }

        // GET api/transaction
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById()
        {
            return Ok();
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> Post(CreateTransactionInputModel model)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(UpdateTransactionInputModel model)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok();
        }
    }
}
