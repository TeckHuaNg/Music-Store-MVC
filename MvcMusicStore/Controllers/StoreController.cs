using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            //create a typed list of Genres
            var genres = new List<Genre>();

            //create 10 Genre in memory to pass to the main store view
            for(int i = 1;i <= 10; i++)
            {
                genres.Add(new Genre { Name = "Genre" + i.ToString() });
            }
            //pass the typed list to the view for display
            return View(genres);
        }

        // GET: Store/Browse
        public ActionResult Browse(string genre)
        {
            ViewBag.Genre = genre;
            return View();
        }

        public String Details(int id)
        {
            string message = "Store Details, ID = " + id;
            return message;
        }
    }
}