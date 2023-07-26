using AutoMarket.Presentation.Data.Interfaces;
using AutoMarket.Presentation.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AutoMarket.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICars _cars;

        public HomeController(ICars cars)
        {
            _cars = cars;
        }

        public ViewResult Index()
        {
            HomeViewModel viewModel = new()
            {
                FavoriteCars = _cars.GetFavoriteCars,
            };

            return View(viewModel);
        }
    }
}