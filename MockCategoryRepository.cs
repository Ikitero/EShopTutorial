using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
        new Category{CategoryId=1, CategoryName="Cheese cakes", Description="Cheesy as fuck"},
        new Category{ CategoryId=2, CategoryName="Fish cakes", Description="Smells just like your Ex one"},
        new Category{ CategoryId=3, CategoryName="Fruit pie", Description="Those are really nice"}
        };
    }
}
