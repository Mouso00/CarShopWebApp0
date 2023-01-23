using CarShopWebApp0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShopWebApp0.Controllers
{
    public class CarsController : Controller
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

        public ActionResult Edit(int id)
        {
            var carToEdit = _inventory.FirstOrDefault(c => c.ID == id);
            return View(carToEdit);
        }

        [HttpPost]
        public ActionResult Edit(Car updatedCar)
        {
            var carToEdit = _inventory.FirstOrDefault(c => c.ID == updatedCar.ID);
            carToEdit.Make = updatedCar.Make;
            carToEdit.Model = updatedCar.Model;
            carToEdit.Year = updatedCar.Year;
            carToEdit.Price = updatedCar.Price;
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var carToDelete = _inventory.FirstOrDefault(c => c.ID == id);
            _inventory.Remove(carToDelete);
            return RedirectToAction("Index");
        }
    }

}
