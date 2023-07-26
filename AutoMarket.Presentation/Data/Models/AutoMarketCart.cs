using Microsoft.EntityFrameworkCore;

namespace AutoMarket.Presentation.Data.Models
{
    public class AutoMarketCart
    {
        private readonly ApplicationContext _applicationContext;

        public AutoMarketCart(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public static AutoMarketCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<ApplicationContext>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new AutoMarketCart(context) { AutoMarketCartId = shopCartId };
        }

        public void AddToCart(Car car)
        {
            _applicationContext.CartItems.Add(new CartItem
            {
                ShopCartId = AutoMarketCartId,
                Car = car,
                Price = car.Price,
            });

            _applicationContext.SaveChanges();
        }

        public List<CartItem> GetShopItems()
        {
            return _applicationContext.CartItems.Where(key => key.ShopCartId == AutoMarketCartId).Include(key => key.Car).ToList();
        }

        public string AutoMarketCartId { get; set; }

        public List<CartItem> ListAutoMarketItems { get; set; }
    }
}