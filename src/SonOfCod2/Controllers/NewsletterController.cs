using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SonOfCod2.Models;
using System.Collections.Generic;
using System.Linq;


namespace SonOfCod2.Controllers
{
    public class NewsletterController : Controller
    {
        private ApplicationDbContext _db;

        public NewsletterController(ApplicationDbContext db)
        {
            _db = db;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SignUp(Subscriber model)
        {
            _db.Subscriber.Add(model);
            _db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }


        [Authorize]
        public IActionResult Subscribers()
        {
            List<Subscriber> subscribers = _db.Subscriber.ToList();
            return View(subscribers);
        }
    }
}
