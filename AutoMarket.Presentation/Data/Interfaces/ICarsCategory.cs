using AutoMarket.Presentation.Data.Models;

namespace AutoMarket.Presentation.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}