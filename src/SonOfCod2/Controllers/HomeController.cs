using SonOfCod2.Models;
using Microsoft.AspNetCore.Mvc;

namespace SonOfCod2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
