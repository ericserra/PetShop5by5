using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetShopProj5by5.Dal;
using PetShopProj5by5.Models;

namespace PetShopProj5by5.Controllers
{
    public class CustomerController : Controller
    {
        private PetShopContext psc = new PetShopContext();
        // GET: Custumer
        public ActionResult Index()
        {
            return View(psc.Customers.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                psc.Customers.Add(customer);
                psc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }
        public ActionResult Edit(int id)
        {
            return View(psc.Customers.First(c => c.CustomerId == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer customer) //Consertar essa gabirosca
        {
            if (ModelState.IsValid)
            {
                Customer customerUpdate = psc.Customers.First(c => c.CustomerId == customer.CustomerId);
                customerUpdate.Name = customer.Name;
                customerUpdate.PhoneNumber = customer.PhoneNumber;
                customerUpdate.Street= customer.Street;
                customerUpdate.Neighborhood = customer.Neighborhood;
                customerUpdate.State = customer.State;
                customerUpdate.PostalCode = customer.PostalCode;
                psc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        public ActionResult Details(int id)
        {
            return View(psc.Customers.First(c => c.CustomerId == id));
        }
        
        public ActionResult Delete(int id)
        {
            return View(psc.Customers.First(c => c.CustomerId == id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            psc.Customers.Remove(psc.Customers.First(c => c.CustomerId == id));
            psc.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}