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
                    new Category { CategiryName = "Electric cars", Description = "Modern mode of transport" },
                    new Category { CategiryName = "Classic cars", Description = "Cars with internal combustion engine" },
                };
            }
        }
    }
}