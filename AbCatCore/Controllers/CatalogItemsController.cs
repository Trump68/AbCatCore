using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbCatCore.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AbCatCore.Controllers
{
    public class CatalogItemsController : Controller
    {
        private readonly ICatalogDataContext _context;
        private readonly IConfiguration _configuration;

        public CatalogItemsController(ICatalogDataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        // GET: CatItem
        public ActionResult Index()
        {
            return View(_context.Items);
        }

        // GET: CatItem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CatItem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CatItem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CatItem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CatItem/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CatItem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CatItem/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}