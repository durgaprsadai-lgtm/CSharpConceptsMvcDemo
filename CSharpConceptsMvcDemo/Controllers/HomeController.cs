using Microsoft.AspNetCore.Mvc;

namespace CSharpConceptsMvcDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
