using CarShopWebApp0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShopWebApp0.Controllers
{
    public class InventoryController : Controller
    {
        private List<Car> _inventory = new List<Car>();

        public ActionResult Index()
        {
            return View(_inventory);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Car newCar)
        {
            _inventory.Add(newCar);
            return RedirectToAction("Index");
        }

        public ActionResult Remove(int id)
        {
            var carToRemove = _inventory.FirstOrDefault(c => c.ID == id);
            _inventory.Remove(carToRemove);
            return RedirectToAction("Index");
        }
    }

}
