using DevCardProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCardProject.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        
        public IViewComponentResult Invoke(string name)
        {
            List<Project> projects = new()
            {
                new Project(1, "ماشین حساب", "یک ماشین حساب پیشرفته روز دنیا", "project-1.jpg", "International"),

            };
            return View("_Projects", projects);
        }
    }
}
