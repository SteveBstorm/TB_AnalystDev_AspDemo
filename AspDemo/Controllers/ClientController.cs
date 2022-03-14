using Microsoft.AspNetCore.Mvc;

namespace AspDemo.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
