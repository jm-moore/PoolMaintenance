using Microsoft.AspNetCore.Mvc;

namespace PoolMaintenance.Controllers
{
    public class PoolsController : Controller
    {
        private readonly IPoolRepository repo;

        public PoolsController(IPoolRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var pools = repo.GetAllPools();
            return View(pools);
        }

    }
}
