using AutoMarket.Presentation.Data.Models;

namespace AutoMarket.Presentation.Data.Interfaces
{
    public interface ICars
    {
        IEnumerable<Car> Cars { get; }

        IEnumerable<Car> GetFavoriteCars { get; set; }

        Car GetObjectCar(int carId);
    }
}