using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KavyaPieShop.Models;

namespace KavyaPieShop.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string CurrentCategory { get; set; }
    }
}
