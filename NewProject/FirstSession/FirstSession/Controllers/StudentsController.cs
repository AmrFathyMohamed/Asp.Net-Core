using Microsoft.AspNetCore.Mvc;

namespace FirstSession.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
