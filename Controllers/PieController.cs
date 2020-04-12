using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KavyaPieShop.Models;
using KavyaPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KavyaPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;
        public PieController(IPieRepository iPieRepository, ICategoryRepository iCategoryRepository)
        {
            _pieRepository = iPieRepository;
            _categoryRepository = iCategoryRepository;
        }
        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;
            piesListViewModel.Categories = _categoryRepository.AllCategories;
            piesListViewModel.CurrentCategory = "Cheese Cakes";
            return View(piesListViewModel);
        }
        public IActionResult Details (int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();
            return View(pie);
        }
    }
}