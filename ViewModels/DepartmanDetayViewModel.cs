using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class DepartmanDetayViewModel
    {
        public Departman Departman { get; set; }
        public List<Personel> Personeller { get; set; }
    }
}