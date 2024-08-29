using Microsoft.AspNetCore.Mvc;

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
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
            }
            return View();
        }
    }
}