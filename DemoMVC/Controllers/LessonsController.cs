using DemoMVC.Data;
using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers
{
    public class LessonsController : Controller
    {
        public IActionResult Index()
        {
            return View(LearningData.Lessons);
        }
        public IActionResult Detail(int id)
        {
            var lesson = LearningData.Lessons
                .FirstOrDefault(x => x.Id == id);
            if (lesson == null)
            {
                return NotFound();
            }
            return View(lesson);
        }
    }
}