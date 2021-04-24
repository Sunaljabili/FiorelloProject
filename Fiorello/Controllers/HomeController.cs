using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorello.DAL;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders = _db.Sliders,
                SliderContents = _db.SliderContents.FirstOrDefault(),
                FlowerCatgs=_db.FlowerCatgs,
                FlowerExpert=_db.FlowerExperts.FirstOrDefault(),
                FlowerExperts=_db.FlowerExperts,
                Valentine=_db.Valentines.FirstOrDefault(),
                Valentines=_db.Valentines,
                Blog =_db.Blogs.FirstOrDefault(),
                Blogs=_db.Blogs,
                Instagrams=_db.Instagrams,
                SayStarts=_db.SayStarts

            };
            return View(homeVM);
        }
    }
}