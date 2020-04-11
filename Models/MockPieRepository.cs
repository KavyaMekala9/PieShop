using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KavyaPieShop.Models
{
    public class MockPieRepository: IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie{PieId=1,Name="Blueberry Pie",CategoryId=1,Price=12.99M,ShortDescription="Loaded with tasty blueberries"},
                new Pie{PieId=1,Name="Blueberry1 Pie",CategoryId=2,Price=13.99M,ShortDescription="Loaded with tasy blueberries"},
                new Pie{PieId=1,Name="Blueberry2 Pie",CategoryId=3,Price=14.99M,ShortDescription="Loaded with tasy blueberries"},
                new Pie{PieId=1,Name="Blueberry3 Pie",CategoryId=2,Price=15.99M,ShortDescription="Loaded with tasy blueberries"},
                new Pie{PieId=1,Name="Blueberry4 Pie",CategoryId=1,Price=16.99M,ShortDescription="Loaded with tasy blueberries"},
                new Pie{PieId=1,Name="Blueberry5 Pie",CategoryId=3,Price=17.99M,ShortDescription="Loaded with tasy blueberries"}
            };
        public IEnumerable<Pie> PiesOfTheWeek { get; }
        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}   
