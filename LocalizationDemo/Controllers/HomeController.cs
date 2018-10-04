using LocalizationDemo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizationDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext context;

        public HomeController(DataContext context) => this.context = context;

        public IActionResult Index()
        {
            List<Foo> data = this.context.Foos.Include(f => f.Bars).ToList();

            return this.View(data);
        }
    }
}