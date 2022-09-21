using Microsoft.AspNetCore.Mvc;

namespace PoolMaintenance.Controllers
{
    public class ChemsController : Controller
    {
        private readonly IChemRepository repo;

        public ChemsController(IChemRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var chems = repo.GetAllChems();
            return View(chems);
        }
    }
}
