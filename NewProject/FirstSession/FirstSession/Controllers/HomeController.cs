using FirstSession.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstSession.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCompany()
        {
            return PartialView("MyCompany");
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View();
        }
        public IActionResult Contact()
        {
            Contact C = new Contact()
            {
                Name = "Test",
                Email = "Test@Test.com",
                PhoneNumber = "012345",
                Massage = " aya haga"
            };
            return View(C);
        }
        [HttpPost]
        public IActionResult Contact(Contact CTest)
        {
            Console.WriteLine($"My Name {CTest.Name} my Phone : +2{CTest.PhoneNumber} my email : {CTest.Email}" );
            Console.WriteLine($"My Message {CTest.Massage}");
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}