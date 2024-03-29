﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AbCatCore.Models;
using AbCatCore.Helpers;

namespace AbCatCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICatalogDataContext _Db;

        public HomeController(ILogger<HomeController> logger, ICatalogDataContext catalogDb)
        {
            _logger = logger;
            _Db = catalogDb;
        }

        public IActionResult Index()
        {
            _Db.Load();
            return RedirectToAction("Index","CatalogItems");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
