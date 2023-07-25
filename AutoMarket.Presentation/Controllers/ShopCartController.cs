using AutoMarket.Presentation.Data.Interfaces;
using AutoMarket.Presentation.Data.Models;
using AutoMarket.Presentation.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AutoMarket.Presentation.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly ICars _carRepository;
        private readonly AutoMarketCart _autoMarketCart;

        public ShopCartController(ICars carRepository, AutoMarketCart autoMarketCart)
        {
            _carRepository = carRepository;
            _autoMarketCart = autoMarketCart;
        }

        public ViewResult Index()
        {
            var items = _autoMarketCart.GetShopItems();
            _autoMarketCart.ListAutoMarketItems = items;

            var obj = new ShopCartViewModel
            {
                AutoMarketCart = _autoMarketCart
            };
            return View(obj);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _carRepository.Cars.FirstOrDefault(key => key.Id == id);
            if (item is not null)
                _autoMarketCart.AddToCart(item);

            return RedirectToAction("Index");
        }
    }
}