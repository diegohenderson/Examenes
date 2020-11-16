using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examenes.Web.Controllers
{
    public class ExamenController : Controller
    {
        // GET: ExamenController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExamenController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExamenController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExamenController/Create
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

        // GET: ExamenController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExamenController/Edit/5
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

        // GET: ExamenController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExamenController/Delete/5
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
