using Microsoft.AspNetCore.Mvc;

namespace Integrador.Controllers
{
    public class ServiceListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
