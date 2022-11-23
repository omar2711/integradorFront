using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Integrador.Controllers
{
    public class MyServiceController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
