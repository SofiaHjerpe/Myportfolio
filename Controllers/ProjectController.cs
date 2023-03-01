using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

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

        public async Task<IActionResult> Create()
        {
            return View();
        }

        
        [HttpPost]
        public async Task<IActionResult> Create(Project project)
        {
            Database db = new Database();

            await db.SaveProject(project);

            return Redirect("/Project");
        }
        
    }
}


