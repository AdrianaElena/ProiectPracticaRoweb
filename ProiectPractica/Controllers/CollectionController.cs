using LibraryData;
using LibraryData.Models;
using Microsoft.AspNetCore.Mvc;
using ProiectPractica.Services;

namespace ProiectPractica.Controllers
{
    public class CollectionController : Controller
    {
        private IMovieCollection _collections;

        public CollectionController(IMovieCollection collection)
        {
            _collections = collection;
        }

        public IActionResult Index()
        {
            var model = _collections.GetAll();
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            _collections.Delete(id);

            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateList(MovieCollection movieCollection)
        {
            _collections.Add(movieCollection);
            return RedirectToAction("Index");
        }

    }
}
