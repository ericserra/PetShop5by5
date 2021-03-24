using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetShopProj5by5.Dal;
using PetShopProj5by5.Models;

namespace PetShopProj5by5.Controllers
{
    public class AddressController : Controller
    {
        private PetShopContext psc = new PetShopContext();
        // GET: Custumer
        public ActionResult Index()
        {
            return View(psc.Addresses.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Address address)
        {
            if (ModelState.IsValid)
            {
                psc.Addresses.Add(address);
                psc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(address);
        }
        public ActionResult Edit(string id)
        {
            return View(psc.Addresses.First(a => a.Cep == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Address address) //Consertar essa gabirosca
        {
            if (ModelState.IsValid)
            {
                Address addressUpdate = psc.Addresses.First(a => a.Cep == address.Cep);
                addressUpdate.Cep = address.Cep;
                psc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(address);
        }

        public ActionResult Details(string id)
        {
            return View(psc.Addresses.First(a => a.Cep == id));
        }

        public ActionResult Delete(string id)
        {
            return View(psc.Addresses.First(a => a.Cep == id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(string id)
        {
            psc.Addresses.Remove(psc.Addresses.First(a => a.Cep == id));
            psc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}