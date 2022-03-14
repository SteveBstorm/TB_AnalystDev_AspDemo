using AspDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDemo.Controllers
{
    public class ClientController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.Toto = 42;
            ViewData["truc"] = "Salut les filles";
            TempData["maValeur"] = "super valeur qui sera affichée dans Detail";
            return View(FakeDb.liste);
        }

        public IActionResult Detail(int id)
        {
            
            return View(FakeDb.GetById(id));
        }

        public IActionResult Delete(int id)
        {
            FakeDb.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
