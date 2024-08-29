﻿using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        // GET: ComicBooks
        public ActionResult Index()
        {
            ViewData["Title"] = "Comic Book Home";
            return View();
        }
        public ActionResult Detail()
        {
            ViewData["Title"] = "Comic Book Details";
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
            }
            return View();
        }
    }
}