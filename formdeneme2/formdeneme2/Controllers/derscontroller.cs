using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using formdeneme2.Models;
using Microsoft.AspNetCore.Mvc;

namespace formdeneme2.Controllers
{
    public class derscontroller : Controller
    {

        [HttpGet]
        public IActionResult uygulama()
        {
            return View();
        }

        [HttpPost]
        public IActionResult uygulama(ogrenci ogrenci)
        {
            if (ModelState.IsValid)
            {
                depo.Addogrenci(ogrenci);
                return View("Tesekkur", ogrenci);
            }
            else
            {
                return View(ogrenci);
            }

        }

        public IActionResult detay()
        {
            var course = new ders();
            course.Name = "Programlama Dersi";
            course.description = "Harika bir ders bu derse girmekten mutlu oluyorum.";
            course.isPublished = true;

            return View(course);
        }

        public IActionResult Liste()
        {
            var ogrencis = depo.ogrencis.Where(i => i.Confirm == true);
            return View(ogrencis);
        }

    }
}

