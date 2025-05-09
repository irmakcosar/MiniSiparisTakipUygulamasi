using Microsoft.AspNetCore.Mvc;
using MiniSiparisTakipUygulamasi.Models.Entities;
using MiniSiparisTakipUygulamasi.Models.MyConext;

namespace MiniSiparisTakipUygulamasi.Controllers
{
    public class ProductController : Controller
    {
        //içindeki bilgileri okumak için
        private readonly Context _context;

        public ProductController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            var products = _context.Products.ToList();

            return View(products);
            
        }
        public IActionResult Details(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == id);
            
            return View(product);
            /*
             details sayfanısı browserda açmıyor herhangi bir hata da fırlatmıyor.
             
             
             */
        }

    }
}
