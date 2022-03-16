using AspDemo.FormModels;
using AspDemo.Models;
using AspDemo.Tools;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ClientForm form)
        {
            if(ModelState.IsValid)
            {
                FakeDb.Create(form.ToClient());
                return RedirectToAction("Index");
            }

            return View(form);
            
        }
    }
}
