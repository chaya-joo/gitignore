using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tryPraktikum.Controllers
{
    public class successController : Controller
    {
        // GET: successController
        public ActionResult Index()
        {
            return View();
        }

        // GET: successController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: successController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: successController/Create
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

        // GET: successController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: successController/Edit/5
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

        // GET: successController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: successController/Delete/5
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
