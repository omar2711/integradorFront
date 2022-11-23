using Microsoft.AspNetCore.Mvc;

namespace Integrador.Controllers
{
    public class ServiceDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
