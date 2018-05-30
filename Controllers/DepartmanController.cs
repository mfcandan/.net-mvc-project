using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DepartmanController : Controller
    {
        public ActionResult Merhaba()
        {
            var departman = new Departman() {Id=1, Ad="Bilgi İşlem" };
            return View(departman);
        }

        public ActionResult Test()
        {
            return RedirectToAction("Index", "Personel", new { SortBy="maas"});
        }

        public ActionResult Sil(int departmanId)
        {
            return Content("Gelen Id:" + departmanId);
        }
        public ActionResult Update(int departmanId, string ad)
        {
            return Content("Did:"+departmanId+" "+" Ad:"+ad);
        }
    }
}