using ProjetoPizzaEx5MVC.Dal;
using ProjetoPizzaEx5MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPizzaEx5MVC.Controllers
{
    public class PizzaController : Controller
    {

        private PizzaContext db = new PizzaContext();
        // GET: Pizza
        public ActionResult Index()
        {
            return View(db.pizzas.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                db.pizzas.Add(pizza);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pizza);
        }

        public ActionResult Edit(int id)
        {
            return View(db.pizzas.First(d => d.Id == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                Pizza dogUpdate = db.pizzas.First(d => d.Id == pizza.Id);
                dogUpdate.Nome = pizza.Nome;
                dogUpdate.Valor = pizza.Valor;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pizza);
        }

        public ActionResult Details(int id)
        {
            return View(db.pizzas.First(d => d.Id == id));
        }

        public ActionResult Delete(int id)
        {
            return View(db.pizzas.First(d => d.Id == id));

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCofirm(int id)
        {
            db.pizzas.Remove(db.pizzas.First(d => d.Id == id));
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}