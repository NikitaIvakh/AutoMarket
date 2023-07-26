using AutoMarket.Presentation.Data.Interfaces;
using AutoMarket.Presentation.Data.Models;
using AutoMarket.Presentation.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AutoMarket.Presentation.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders _allOrders;
        private readonly AutoMarketCart _autoMarketCart;

        public OrderController(IAllOrders allOrders, AutoMarketCart autoMarketCart)
        {
            _allOrders = allOrders;
            _autoMarketCart = autoMarketCart;
        }

        public IActionResult CheckOut()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckOut(Order order)
        {
            _autoMarketCart.ListAutoMarketItems = _autoMarketCart.GetShopItems();

            if (_autoMarketCart.ListAutoMarketItems.Count == 0)
                ModelState.AddModelError("", "You must have the goods");

            if (ModelState.IsValid)
            {
                _allOrders.CreateOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "The order has been successfully processed";
            return View();
        }
    }
}