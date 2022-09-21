using Microsoft.AspNetCore.Mvc;

namespace PoolMaintenance.Controllers
{
    public class MaintenanceController : Controller
    {
        private readonly IMaintenanceRepository repo;

        public MaintenanceController(IMaintenanceRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var chems = repo.GetAllMaintenances();
            return View(chems);
        }
    }
}
