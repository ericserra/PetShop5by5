using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetShopProj5by5.Dal;
using PetShopProj5by5.Models;

namespace PetShopProj5by5.Controllers
{
    public class PetController : Controller
    {
        private PetShopContext psc = new PetShopContext();
        // GET: Custumer
        public ActionResult Index()
        {
            return View(psc.Pets.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pet pet)
        {
            if (ModelState.IsValid)
            {
                psc.Pets.Add(pet);
                psc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pet);
        }
        public ActionResult Edit(int id)
        {
            return View(psc.Pets.First(p => p.PetId == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Pet pet) //Consertar essa gabirosca
        {
            if (ModelState.IsValid)
            {
                Pet petUpdate = psc.Pets.First(p => p.PetId == pet.PetId);
                petUpdate.Name = pet.Name;
                psc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pet);
        }

        public ActionResult Details(int id)
        {
            return View(psc.Pets.First(p => p.PetId == id));
        }

        public ActionResult Delete(int id)
        {
            return View(psc.Pets.First(p => p.PetId == id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            psc.Pets.Remove(psc.Pets.First(p => p.PetId == id));
            psc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
