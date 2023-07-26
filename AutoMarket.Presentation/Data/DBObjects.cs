using AutoMarket.Presentation.Data.Models;

namespace AutoMarket.Presentation.Data
{
    public class DBObjects
    {
        public static void Initial(ApplicationContext applicationContext)
        {
            if (!applicationContext.Categories.Any())
            {
                applicationContext.Categories.AddRange(SelectCategories.Select(applicationContext => applicationContext.Value));
                applicationContext.SaveChanges();
            }

            if (!applicationContext.Cars.Any())
            {
                applicationContext.Cars.AddRange(SelectCars.Select(applicationContext => applicationContext.Value));
                applicationContext.SaveChanges();
            }
        }

        public static Dictionary<string, Category> SelectCategories
        {
            get
            {
                if (_category is null)
                {
                    var list = new Category[]
                    {
                         new Category { CategoryName = "Electric cars", Description = "Modern mode of transport" },
                         new Category { CategoryName = "Classic cars", Description = "Cars with internal combustion engine" },
                    };

                    _category = new Dictionary<string, Category>();
                    foreach (Category category in list)
                        _category.Add(category.CategoryName, category);
                }

                return _category;
            }
        }

        public static Dictionary<string, Car> SelectCars
        {
            get
            {
                if (_car is null)
                {
                    var list = new Car[]
                    {
                        new Car {
                            Name = "Tesla Model X",
                            ShortDescription = "Fast car",
                            LongDescription = "A beautiful, fast and very quiet Tesla car",
                            Image = "/img/Tesla-Model-X.jpg",
                            Price = 96.740m,
                            IsFavourite = true,
                            IsAvailable = true,
                            Category = SelectCategories["Electric cars"],
                        },

                        new Car {
                            Name = "BMW M5 F10",
                            ShortDescription = "Fast car",
                            LongDescription = "A comfortable car for city life",
                            Image = "/img/BMW-M5-F10.jpg",
                            Price = 39.000m,
                            IsFavourite = true,
                            IsAvailable = true,
                            Category = SelectCategories["Classic cars"],
                        },

                        new Car {
                            Name = "Maserati Ghibli III",
                            ShortDescription = "Bold and stylish",
                            LongDescription = "Convenient, comfortable, and most importantly fast car",
                            Image = "/img/Maserati-Ghibli-III.jpg",
                            Price = 52.990m,
                            IsFavourite = true,
                            IsAvailable = true,
                            Category = SelectCategories["Classic cars"],
                        },

                        new Car {
                            Name = "Mercedes-Benz S-Class W223",
                            ShortDescription = "The car has a luxurious design and a high level of comfort",
                            LongDescription = "It is one of the most prestigious cars in the world, having a high level of comfort and advanced technology.",
                            Image = "/img/Mercedes-Benz-S-Class-W223-1.jpg",
                            Price = 220.000m,
                            IsFavourite = true,
                            IsAvailable = true,
                            Category = SelectCategories["Classic cars"],
                        },

                        new Car {
                            Name = "BMW i8 I",
                            ShortDescription = "A sporty hybrid car from BMW of the middle class",
                            LongDescription = "The car has an innovative design made of lightweight materials such as carbon fiber, which together with high-tech solutions made it one of the most industrial hybrids, " +
                            "and also allowed to achieve outstanding dynamic characteristics.",
                            Image = "/img/BMW-i8-I.jpg",
                            Price = 126.000m,
                            IsFavourite = true,
                            IsAvailable = true,
                            Category = SelectCategories["Electric cars"],
                        },

                        new Car {
                            Name = "Mercedes-Benz AMG GT C190",
                            ShortDescription = "A sports car from the German manufacturer Mercedes-AMG GmbH.",
                            LongDescription = "The AMG GT C190 has a body made of aluminum alloys and other lightweight materials to reduce the weight of the car and improve performance. The body, made in the style of a coupe, " +
                            "is favorably distinguished by a proportional, elegant design created thanks to a noticeable \"side line\".",
                            Image = "/img/Mercedes-AMG-GT.jpg",
                            Price = 129.000m,
                            IsFavourite = true,
                            IsAvailable = true,
                            Category = SelectCategories["Classic cars"],
                        },
                    };

                    _car = new Dictionary<string, Car>();
                    foreach (Car car in list)
                        _car.Add(car.Name, car);
                }

                return _car;
            }

        }

        private static Dictionary<string, Category> _category;
        private static Dictionary<string, Car> _car;
    }
}