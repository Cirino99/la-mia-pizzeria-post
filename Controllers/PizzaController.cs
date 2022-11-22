using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            PizzeriaDbContext db = new PizzeriaDbContext();
            List<Pizza> pizze = db.Pizze.ToList();
            return View(pizze);
        }

        public IActionResult Detail(int id)
        {
            PizzeriaDbContext db = new PizzeriaDbContext();
            Pizza pizza = db.Pizze.Where(p => p.Id == id).FirstOrDefault();
            if(pizza == null)
                return View("NotFound","La pizza cercata non è stata trovata");
            return View(pizza);
        }
    }
}
