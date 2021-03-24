using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetShopProj5by5.Dal;
using PetShopProj5by5.Models;

namespace PetShopProj5by5.Controllers
{
    public class ServicesController : Controller
    {
        private PetShopContext psc = new PetShopContext();
        // GET: Custumer
        public ActionResult Index()
        {
            return View(psc.Services.ToList());
        }

        [HttpPost]
        public ActionResult Details(int id)
        {
            return View(psc.Schedules.First(s => s.AppointmentProtocol == id));
        }
    }
}