using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPooWebMVC.Controllers
{
    public class DogController : Controller
    {
        // GET: Dog
        public ActionResult Index()
        {
            var lst = this.Crud().Select();
            return View(lst);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Dog dog)
        {
            if (ModelState.IsValid)
            {
                Crud().Insert(dog);

                return RedirectToAction("Index");
            }

            return View(dog);
        }

        public ActionResult Edit(int id)
        {
            var dog = Crud().SelectById(id);
            return View(dog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Dog dog)
        {
            if (ModelState.IsValid)
            {
                Crud().Update(dog);
                return RedirectToAction("Index");
            }
            return View(dog);
            
        }

        public ActionResult Details(int id)
        {
            var dog = Crud().SelectById(id);
            return View(dog);
        }

        public ActionResult Delete(int id)
        {
            var dog = Crud().SelectById(id);
            return View(dog);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            Crud().Delete(id);
            return RedirectToAction("Index");
        }

        private IDogDB Crud()
        {
            return new DogDB();
        }
    }
}