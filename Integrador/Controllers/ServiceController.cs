using Microsoft.AspNetCore.Mvc;

namespace Integrador.Controllers
{
  public class ServiceController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
