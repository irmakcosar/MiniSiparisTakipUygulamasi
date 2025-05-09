using Microsoft.AspNetCore.Mvc;
using MiniSiparisTakipUygulamasi.Models.Entities;

namespace MiniSiparisTakipUygulamasi.Controllers
{
    public class CategoryController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
