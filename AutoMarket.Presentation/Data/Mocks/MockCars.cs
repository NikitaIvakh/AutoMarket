using AutoMarket.Presentation.Data.Interfaces;
using AutoMarket.Presentation.Data.Models;

namespace AutoMarket.Presentation.Data.Mocks
{
    public class MockCars : ICars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>()
                {
                    new Car {
                        Name = "Tesla Model X",
                        ShortDescription = "Fast car",
                        LongDescription = "A beautiful, fast and very quiet Tesla car",
                        Image = "https://topelectricsuv.com/wp-content/uploads/2023/01/Tesla-Model-X-Plaid-front-three-quarter.jpg",
                        Price = 96.740m,
                        IsFavourite = true,
                        Available = true,
                        Category = _carsCategory.AllCategories.First()},

                    new Car {
                        Name = "BMW M5 F10",
                        ShortDescription = "Fast car",
                        LongDescription = "A comfortable car for city life",
                        Image = "https://www.wallpaperup.com/uploads/wallpapers/2017/11/07/1151505/79e9c1af52e1341280943799e912dbfc.jpg", 
                        Price = 39.000m,
                        IsFavourite = true,
                        Available = true,
                        Category = _carsCategory.AllCategories.Last()},

                    new Car {
                        Name = "Maserati Ghibli III",
                        ShortDescription = "Bold and stylish",
                        LongDescription = "Convenient, comfortable, and most importantly fast car",
                        Image = "https://avatars.mds.yandex.net/get-autoru-vos/1687199/f09d64b19394fd287dff8c41d2f7c35a/1200x900", 
                        Price = 52.990m,
                        IsFavourite = true,
                        Available = true,
                        Category = _carsCategory.AllCategories.Last()},

                    new Car {
                        Name = "Mercedes-Benz S-Class W223",
                        ShortDescription = "The car has a luxurious design and a high level of comfort",
                        LongDescription = "It is one of the most prestigious cars in the world, having a high level of comfort and advanced technology.",
                        Image = "https://paultan.org/image/2020/09/2021-W223-Mercedes-Benz-S-Class-Plug-in-Hybrid-Model-1.jpg",
                        Price = 220.000m,
                        IsFavourite = true,
                        Available = true,
                        Category = _carsCategory.AllCategories.Last()},

                    new Car {
                        Name = "BMW i8 I",
                        ShortDescription = "A sporty hybrid car from BMW of the middle class",
                        LongDescription = "The car has an innovative design made of lightweight materials such as carbon fiber, which together with high-tech solutions made it one of the most industrial hybrids, and also allowed to achieve outstanding dynamic characteristics.",
                        Image = "https://w.forfun.com/fetch/6a/6a24a56de387dbe579611207072827f7.jpeg",
                        Price = 126.000m,
                        IsFavourite = true,
                        Available = true,
                        Category = _carsCategory.AllCategories.First()},
                };
            }
        }

        public IEnumerable<Car> GetFavoriteCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}