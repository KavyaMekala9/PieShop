using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KavyaPieShop.Models
{
    public class MockCategoryRepository :ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Fruit Pies",Description="All the fruity pies"},
                new Category{CategoryId=2,CategoryName="Seasonal Pies",Description="Delicious seasonal pies"},
                new Category{CategoryId=3,CategoryName="Special Pies",Description="Enjoy wide varieties of special pies"},
                new Category{CategoryId=3,CategoryName="Cheese Cakes",Description="Love cheese cakes? Enjoy all types of Cheese cakes"}
            };
    }
}
