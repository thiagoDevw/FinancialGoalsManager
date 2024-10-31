using FinancialGoalsManager.Service;
using Microsoft.AspNetCore.Mvc;

namespace FinancialGoalsManager.Controllers
{
    public class FinancialObjectiveController : ControllerBase
    {
        private readonly FinancialObjectiveService _service;

        public FinancialObjectiveController(FinancialObjectiveService service)
        {
            _service = service;
        }
    }
}
