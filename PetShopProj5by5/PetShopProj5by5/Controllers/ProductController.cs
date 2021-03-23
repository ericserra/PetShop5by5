using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetShopProj5by5.Dal;
using PetShopProj5by5.Models;

namespace PetShopProj5by5.Controllers
{
    public class ProductController : Controller
    {
        private PetShopContext psc = new PetShopContext();
        // GET: Custumer
        public ActionResult Index()
        {
            return View(psc.Products.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                psc.Products.Add(product);
                psc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }
        public ActionResult Edit(int id)
        {
            return View(psc.Products.First(p => p.ProductId == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product) //Consertar essa gabirosca
        {
            if (ModelState.IsValid)
            {
                Product productUpdate = psc.Products.First(p => p.ProductId == product.ProductId);
                productUpdate.ProductDescription = product.ProductDescription;
                productUpdate.IndividualValue = product.IndividualValue;
                psc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public ActionResult Details(int id)
        {
            return View(psc.Products.First(p => p.ProductId == id));
        }

        public ActionResult Delete(int id)
        {
            return View(psc.Products.First(p => p.ProductId == id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            psc.Products.Remove(psc.Products.First(p => p.ProductId == id));
            psc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}