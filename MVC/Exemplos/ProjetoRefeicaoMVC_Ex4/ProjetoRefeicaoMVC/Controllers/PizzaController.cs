using Data;
using Model;
using Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoRefeicaoMVC.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Index()
        {
            var lst = Crud().Select();
            return View(lst);
        }

        public ActionResult Create()
        {
            return View();
        }
       

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create (Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                Crud().Insert(pizza);
                return RedirectToAction("Index");
            }
            return View(pizza);
        }

        public ActionResult Edit(int id)
        {
            var pizza = Crud().LocalizarPizza(id);
            return View(pizza);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                Crud().Editar(pizza);
                return RedirectToAction("Index");
            }
            return View(pizza);
        }

        public ActionResult Details(int id)
        {
            var pizza = Crud().LocalizarPizza(id);
            return View(pizza);
        }

        public ActionResult Delete(int id)
        {
            var pizza = Crud().LocalizarPizza(id);
            return View(pizza);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirm(int id)
        {
            Crud().Remover(id);
            return RedirectToAction("Index");
        }
        private IMonitore Crud()
        {
            return new Proxy.Proxy(new PizzaDB());
        }
    }
}