using AutoMarket.Presentation.Data.Models;

namespace AutoMarket.Presentation.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }

        public string CurrCategory { get; set; }
    }
}