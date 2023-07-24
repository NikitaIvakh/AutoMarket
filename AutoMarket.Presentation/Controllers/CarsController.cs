using AutoMarket.Presentation.Data.Interfaces;
using AutoMarket.Presentation.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AutoMarket.Presentation.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICars _cars;
        private readonly ICarsCategory _carsCategory;

        public CarsController(ICars cars, ICarsCategory carsCategory)
        {
            _cars = cars;
            _carsCategory = carsCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Page with cars";
            CarsListViewModel obj = new()
            {
                AllCars = _cars.Cars,
                CurrCategory = "Cars"
            };

            return View(obj);
        }
    }
}