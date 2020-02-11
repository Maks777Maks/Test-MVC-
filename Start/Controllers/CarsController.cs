using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Start.Data.Interfaces;
using Start.ViewModels;

namespace Start.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICars _cars;
        private readonly ICategory _category;

        public CarsController(ICars cars, ICategory category)
        {
            _cars = cars;
            _category = category;
        }

        public ViewResult ListCars()
        {
            ViewBag.Title = "All Cars";
            CarsListViewModel obj = new CarsListViewModel();
            obj.GetCars = _cars.GetCars;
            obj.CarCategory = "auto";
            return View(obj);

            //var cars = _cars.GetCars;
            //return View(cars);
        }
    }
}