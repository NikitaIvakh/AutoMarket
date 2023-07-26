using AutoMarket.Presentation.Data.Interfaces;
using AutoMarket.Presentation.Data.Models;

namespace AutoMarket.Presentation.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly ApplicationContext _applicationContext;
        private readonly AutoMarketCart _autoMarketCart;

        public OrdersRepository(ApplicationContext applicationContext, AutoMarketCart autoMarketCart)
        {
            _applicationContext = applicationContext;
            _autoMarketCart = autoMarketCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            _applicationContext.Orders.Add(order);
            _applicationContext.SaveChanges();

            var items = _autoMarketCart.ListAutoMarketItems;

            foreach (var item in items)
            {
                _applicationContext.OrderDetails.Add(new OrderDetail
                {
                    CarId = item.Car.Id,
                    OrderId = order.Id,
                    Price = item.Car.Price,
                });

                _applicationContext.SaveChanges();
            }

            _applicationContext.SaveChanges();
        }
    }
}