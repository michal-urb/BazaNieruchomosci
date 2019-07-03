using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BazaNieruchomosci.Models;
using BazaNieruchomosci.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BazaNieruchomosci.Controllers
{
    public class HomeController : Controller
    {
        private readonly IImmovablePropertyRepository _immovablePropertyRepository;

        public HomeController(IImmovablePropertyRepository immovablePropertyRepository)
        {
            _immovablePropertyRepository = immovablePropertyRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var immovableProperties = _immovablePropertyRepository.GetImmovableProperties().OrderBy(p => p.Price);

            var homeVM = new HomeVM
            {
                Tittle = "Przeglad nieruchomosci",
                ImmovableProperties = immovableProperties.ToList()
            };

            return View(homeVM);
        }

        public IActionResult Details(string id)
        {
            var immovableProperty = _immovablePropertyRepository.GetImmovableProperty(id);

            if (immovableProperty == null)
                return NotFound();

            return View(immovableProperty);
        }
    }
}
