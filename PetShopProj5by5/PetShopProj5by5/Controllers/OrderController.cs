using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetShopProj5by5.Dal;
using PetShopProj5by5.Models;

namespace PetShopProj5by5.Controllers
{
    public class OrderController : Controller
    {
        private PetShopContext psc = new PetShopContext();
        // GET: Custumer
        public ActionResult Index()
        {
            return View(psc.Orders.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                List<Product> products = psc.Products.ToList();
                foreach (var item in products)
                {
                    if (item.ProductId == order.ProductID)
                    {
                        order.OrderTotal = item.IndividualValue;
                    }
                }
                psc.Orders.Add(order);
                psc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(order);
        }
        public ActionResult Edit(int id)
        {
            return View(psc.Orders.First(o => o.OrderId == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Order order) //Consertar essa gabirosca
        {
            if (ModelState.IsValid)
            {
                Order orderUpdate = psc.Orders.First(o => o.OrderId == order.OrderId);
                orderUpdate.PaymentMethod = order.PaymentMethod;
                psc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(order);
        }

        public ActionResult Details(int id)
        {
            return View(psc.Orders.First(o => o.OrderId == id));
        }

        public ActionResult Delete(int id)
        {
            return View(psc.Orders.First(o => o.OrderId == id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            psc.Orders.Remove(psc.Orders.First(o => o.OrderId == id));
            psc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}