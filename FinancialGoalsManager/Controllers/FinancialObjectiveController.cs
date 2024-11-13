using FinancialGoalsManager.Entities;
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

        // GET: api/FinancialObjective
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var objectives = await _service.GetAllFinancialObjectives();
            return Ok(objectives);
        }

        // GET: api/FinancialObjective/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var objective = await _service.GetFinancialObjectiveById(id);
            if (objective == null)
            {
                return NotFound();
            }
            return Ok(objective);
        }

        // POST: api/FinancialObjective
        [HttpPost]
        public async Task<IActionResult> Create(FinancialObjective objective)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createObjective = await _service.CreateFinancialObjective(objective);
            return CreatedAtAction(nameof(GetById), new { id = createObjective.Id }, createObjective);
        }

        // PUT: api/FinancialObjective/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, FinancialObjective objective)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != objective.Id) return BadRequest();
            await _service.UpdateFinancialObjective(objective);
            return NoContent();
        }

        // DELETE: api/FinancialObjective/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteFinancialObjective(id);
            return NoContent();
        }
    }
}
