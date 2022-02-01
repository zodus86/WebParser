using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebParser.Data;
using WebParser.Models;

namespace WebParser.Controllers
{
    public class HomeController : Controller
    {
        private readonly IParser _parser;

        public HomeController (IParser iparser)
        {
            _parser = iparser;
        }
       
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Parser = _parser.Parsers;
            return View();
        }



        
        public IActionResult AddContactAction(Parser model)
        {
            _parser.Add(model.WebHost);

            return Redirect("~/Home/Privacy");
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

      
    }
}
