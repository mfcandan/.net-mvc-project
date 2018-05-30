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
        public ActionResult Detay(int id)
        {
            ViewData["departmanId"] = id;
            return View();
        }
    }
}