using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BazaNieruchomosci.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BazaNieruchomosci.Controllers
{
    [Authorize]
    public class ImmovablePropertyController : Controller
    {
        private readonly IImmovablePropertyRepository _immovablePropertyRepository;
        private IHostingEnvironment _env;

        public ImmovablePropertyController(IImmovablePropertyRepository immovablePropertyRepository, IHostingEnvironment env)
        {
            _immovablePropertyRepository = immovablePropertyRepository;
            _env = env;
        }
        
        public IActionResult Index()
        {
            var immovableProperties = _immovablePropertyRepository.GetImmovableProperties();

            return View(immovableProperties);
        }

        public IActionResult Details(string id)
        {
            var immovableProperty = _immovablePropertyRepository.GetImmovableProperty(id);

            if (immovableProperty == null)
                return NotFound();

            return View(immovableProperty);
        }

        public IActionResult Create(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
                ViewBag.ImgPath = "/images/" + fileName;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ImmovableProperty immovableProperty)
        {
            if (ModelState.IsValid)
            {
                _immovablePropertyRepository.AddImmovableProperty(immovableProperty);

                return RedirectToAction("Index");
            }

            return View(immovableProperty);
        }

        public IActionResult Edit(string id, string fileName)
        {
            var immovableProperty = _immovablePropertyRepository.GetImmovableProperty(id);

            if (immovableProperty == null)
                return NotFound();

            if (!string.IsNullOrEmpty(fileName))
                ViewBag.ImgPath = "/images/" + fileName;
            else
                ViewBag.ImgPath = immovableProperty.Image;

            return View(immovableProperty);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ImmovableProperty immovableProperty)
        {
            if (ModelState.IsValid)
            {
                _immovablePropertyRepository.EditImmovableProperty(immovableProperty);

                return RedirectToAction("Index");
            }

            return View(immovableProperty);
        }

        public IActionResult Delete(string id)
        {
            var immovableProperty = _immovablePropertyRepository.GetImmovableProperty(id);

            if (immovableProperty == null)
                return NotFound();

            return View(immovableProperty);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            var immovableProperty = _immovablePropertyRepository.GetImmovableProperty(id);

            _immovablePropertyRepository.DeleteImmovableProperty(immovableProperty);

            return RedirectToAction("Index");
        }

        [HttpPost("UploadFile")]
        public async Task<IActionResult> UploadFile(IFormCollection form)
        {
            var wwwRoot = _env.WebRootPath;
            var filePath = Path.Combine(wwwRoot.ToString() + "\\images\\" + form.Files[0].FileName);

            if (form.Files[0].FileName.Length > 0)
            {
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await form.Files[0].CopyToAsync(fileStream);
                }
            }

            if (Convert.ToString(form["id"]) == string.Empty || Convert.ToString(form["id"]) == "0")
                return RedirectToAction(nameof(Create), new { Filename = Convert.ToString(form.Files[0].FileName) });

            return RedirectToAction(nameof(Edit), new { Filename = Convert.ToString(form.Files[0].FileName), id = Convert.ToString(form["id"]) });
        }
    }
}
