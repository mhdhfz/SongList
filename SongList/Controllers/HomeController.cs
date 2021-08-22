using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SongList.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SongList.Controllers
{
    public class HomeController : Controller
    {
        private readonly SongContext _db;

        public HomeController(SongContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var songs = _db.Songs.OrderBy(m => m.Name).ToList();
            return View(songs);
        }
    }
}
