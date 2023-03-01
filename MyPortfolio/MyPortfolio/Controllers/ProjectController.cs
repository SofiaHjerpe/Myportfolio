using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class ProjectController : Controller
    {
        public async Task<IActionResult> Index()
        {
            Database db = new Database();
            var Projects = await db.GetProjectsAsync();
            
            return View(Projects);
        }
    }
}
