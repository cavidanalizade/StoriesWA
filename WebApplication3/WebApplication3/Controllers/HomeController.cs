using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication3.DAL;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {

        AppDBC _context;

        public HomeController(AppDBC context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Images.ToList();
            return View(data);
        }

        public IActionResult About()
        {
            var data = _context.Images.ToList();
            return View(data);
        }


    }
}