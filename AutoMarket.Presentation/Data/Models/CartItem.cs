namespace AutoMarket.Presentation.Data.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        public Car Car { get; set; }

        public decimal Price { get; set; }

        public string ShopCartId { get; set; }
    }
}