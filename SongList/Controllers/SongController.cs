using Microsoft.AspNetCore.Mvc;
using SongList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongList.Controllers
{
    public class SongController : Controller
    {
        private readonly SongContext _db;

        public SongController(SongContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Create";
            return View("Edit", new Song());
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var song = _db.Songs.Find(id);
            return View(song);
        }


        [HttpPost]
        public IActionResult Edit(Song song)
        {
            if (ModelState.IsValid)
            {
                if (song.SongId == 0)
                {
                    _db.Songs.Add(song);
                }
                else
                {
                    _db.Songs.Update(song);
                }

                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = song.SongId == 0 ? "Create" : "Edit";
                return View(song);
            }
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var deleteSong = _db.Songs.Find(id);
            return View(deleteSong);
        }


        [HttpPost]
        public IActionResult Delete(Song song)
        {
            _db.Songs.Remove(song);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }



    }
}
