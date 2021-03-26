using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetShopProj5by5.Dal;
using PetShopProj5by5.Models;

namespace PetShopProj5by5.Controllers
{
    public class ScheduleController : Controller
    {
        private PetShopContext psc = new PetShopContext();
        // GET: Custumer
        public ActionResult Index()
        {
            return View(psc.Schedules.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                psc.Schedules.Add(schedule);
                psc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(schedule);
        }
        public ActionResult Edit(int id)
        {
            return View(psc.Schedules.First(s => s.AppointmentProtocol == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Schedule schedule) //Consertar essa gabirosca
        {
            if (ModelState.IsValid)
            {
                Schedule scheduleUpdate = psc.Schedules.First(s => s.AppointmentProtocol == schedule.AppointmentProtocol);
                scheduleUpdate.AppointmentData = schedule.AppointmentData;
                scheduleUpdate.AppointmentTime = schedule.AppointmentTime;
                scheduleUpdate.PaymentMethod = schedule.PaymentMethod;
                psc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(schedule);
        }

        public ActionResult Details(int id)
        {
            return View(psc.Schedules.First(s => s.AppointmentProtocol == id));
        }

        public ActionResult Delete(int id)
        {
            return View(psc.Schedules.First(s => s.AppointmentProtocol == id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            psc.Schedules.Remove(psc.Schedules.First(s => s.AppointmentProtocol == id));
            psc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}