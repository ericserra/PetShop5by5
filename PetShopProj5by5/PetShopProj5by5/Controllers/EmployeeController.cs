using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetShopProj5by5.Dal;
using PetShopProj5by5.Models;

namespace PetShopProj5by5.Controllers
{
    public class EmployeeController : Controller
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
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                psc.Employees.Add(employee);
                psc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }
        public ActionResult Edit(int id)
        {
            return View(psc.Employees.First(e => e.IdEmployee == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee) //Consertar essa gabirosca
        {
            if (ModelState.IsValid)
            {
                Employee employeeUpdate = psc.Employees.First(e => e.IdEmployee == employee.IdEmployee);
                employeeUpdate.Name = employee.Name;
                psc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public ActionResult Details(int id)
        {
            return View(psc.Employees.First(e => e.IdEmployee == id));
        }

        public ActionResult Delete(int id)
        {
            return View(psc.Employees.First(e => e.IdEmployee == id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            psc.Employees.Remove(psc.Employees.First(e => e.IdEmployee == id));
            psc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}