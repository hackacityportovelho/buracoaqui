using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.App.TapaBuraco.Controllers
{
    public class asdfController : Controller
    {
        // GET: asdf
        public ActionResult Index()
        {
            return View();
        }

        // GET: asdf/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: asdf/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: asdf/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: asdf/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: asdf/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: asdf/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: asdf/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
