using AutoMarket.Presentation.Data.Interfaces;
using AutoMarket.Presentation.Data.Models;
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

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";

            if (string.IsNullOrEmpty(_category))
                cars = _cars.Cars.OrderBy(key => key.Id);

            else
            {
                if (string.Equals("Electric", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _cars.Cars.Where(key => key.CategoryId == 1).OrderBy(key => key.Id);
                    currCategory = "Electric cars";
                }

                else if (string.Equals("Classic", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _cars.Cars.Where(key => key.CategoryId == 2).OrderBy(key => key.Id);
                    currCategory = "Classic cars";
                }
            }

            ViewBag.Title = "Page with cars";
            var carObject = new CarsListViewModel { AllCars = cars, CurrCategory = currCategory };
            return View(carObject);
        }
    }
}