using FinancialGoalsManager.Service;
using Microsoft.AspNetCore.Mvc;

namespace FinancialGoalsManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinancialObjectiveController : ControllerBase
    {
        private readonly FinancialObjectiveService _service;

        public FinancialObjectiveController(FinancialObjectiveService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var objectives = await _service.GetAllFinancialObjectives();
            return Ok(objectives);
        }
    }
}
