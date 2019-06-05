using Microsoft.AspNetCore.Mvc;

namespace Ponto_Digital.Controllers
{
    public class FACController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}