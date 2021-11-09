using DI.interfaces;
using DI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IService<A> _aservice;
        private readonly IService<B> _bservice;
        private readonly IService<C> _cservice;

        public HomeController(ILogger<HomeController> logger, IService<A> aservice, IService<B> bservice, IService<C> cservice)
        {
            _logger = logger;
            _aservice = aservice;
            _bservice = bservice;
            _cservice = cservice;

        }

        public IActionResult Index()
        {
            var a = _aservice.GetAll();


            return View(a);
        }
        public IActionResult Index1()
        {
            var b = _bservice.GetAll();


            return View(b);
        }
        public IActionResult Index2()
        {
            var c = _cservice.GetAll();


            return View(c);
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
