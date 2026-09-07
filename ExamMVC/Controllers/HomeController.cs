using ExamMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace ExamMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var questions = QuestionBank.GetAll();
            return View(questions);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
