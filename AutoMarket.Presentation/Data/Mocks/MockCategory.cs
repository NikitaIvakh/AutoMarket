using AutoMarket.Presentation.Data.Interfaces;
using AutoMarket.Presentation.Data.Models;

namespace AutoMarket.Presentation.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>()
                {
                    new Category { CategoryName = "Electric cars", Description = "Modern mode of transport" },
                    new Category { CategoryName = "Classic cars", Description = "Cars with internal combustion engine" },
                };
            }
        }
    }
}