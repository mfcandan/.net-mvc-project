using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class DepartmanController : Controller
    {
        public ActionResult Detay(int id)
        {
            var departman = new Departman() { Id = id, Ad = "Mühendislik" };
            var personeller = new List<Personel>()
            {
                new Personel(){ Ad="Personel1" },
                new Personel(){ Ad="Personel2" },
                new Personel(){ Ad="Personel3" }
            };

            var model = new DepartmanDetayViewModel() {
                Departman = departman,
                Personeller = personeller
            };
            return View(model);
        }
    }
}