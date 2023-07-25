using AutoMarket.Presentation.Data.Interfaces;
using AutoMarket.Presentation.Data.Models;
using System.Data.Entity;

namespace AutoMarket.Presentation.Data.Repository
{
    public class CarRepository : ICars
    {
        private readonly ApplicationContext _applicationContext;

        public CarRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public IEnumerable<Car> Cars => _applicationContext.Cars.Include(key => key.Category);

        public IEnumerable<Car> GetFavoriteCars => _applicationContext.Cars.Where(key => key.IsFavourite).Include(key => key.Category);

        public Car GetObjectCar(int carId) => _applicationContext.Cars.FirstOrDefault(key => key.Id == carId);
    }
}