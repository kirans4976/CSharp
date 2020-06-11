
using KShoppingKartMock.Data.Interfaces;
using KShoppingKartMock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KShoppingKartMock.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                     {
                         new Category { CategoryName = "Android", Description = "Android OS" },
                         new Category { CategoryName = "Windows", Description = "Windows OS" }
                     };
            }
        }
    }
}
