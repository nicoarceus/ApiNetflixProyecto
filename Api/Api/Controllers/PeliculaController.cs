using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class PeliculaController : Controller
    {
        // GET: PeliculaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PeliculaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PeliculaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PeliculaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeliculaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PeliculaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeliculaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PeliculaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
