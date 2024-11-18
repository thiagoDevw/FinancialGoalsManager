using FinancialGoalsManager.Application.Models.FinancialObjective;
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

            var viewModel = objectives.Select(obj => new FinancialObjectiveViewModel
            {
                Id = obj.Id,
                Titulo = obj.Titulo,
                ValorTotal = obj.ValorTotal
            });

            return Ok(viewModel);
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

            var viewModel = new FinancialObjectiveItemViewModel
            {
                Id = objective.Id,
                Titulo = objective.Titulo,
                QuantidadeAlvo = objective.QuantidadeAlvo,
                Prazo = objective.Prazo,
                Status = (FinancialObjectiveStatus)objective.Status,
                ValorTotal = objective.ValorTotal,
                QuantIdealAporte = objective.QuantidadeIdealAporteMensal,
                DataCriacao = objective.DataCriacao
            };
            return Ok(objective);
        }

        // POST: api/FinancialObjective
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateFinancialObjectiveInputModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Mapear InputModel para entidade
            var newObjective = new FinancialObjective(new List<Transaction>())
            {
                Titulo = inputModel.Titulo,
                QuantidadeAlvo = inputModel.QuantidadeAlvo,
                Prazo = inputModel.Prazo,
                Status = (ObjectiveStatus)Enum.Parse(typeof(ObjectiveStatus), inputModel.Status.ToString()),
                QuantidadeIdealAporteMensal = inputModel.QuantidadeIdealAporteMensal,
                DataCriacao = DateTime.UtcNow
            };

            var createdObjective = await _service.CreateFinancialObjective(newObjective);

            // Retornar com ViewModel
            var viewModel = new FinancialObjectiveItemViewModel
            {
                Id = createdObjective.Id,
                Titulo = createdObjective.Titulo,
                QuantidadeAlvo = createdObjective.QuantidadeAlvo,
                Prazo = createdObjective.Prazo,
                Status = (FinancialObjectiveStatus)createdObjective.Status,
                ValorTotal = createdObjective.ValorTotal
            };

            return CreatedAtAction(nameof(GetById), new { id = viewModel.Id }, viewModel);
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
