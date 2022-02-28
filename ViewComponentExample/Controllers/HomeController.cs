using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentExample.Models;
using ViewComponentExample.Services;

namespace ViewComponentExample.Controllers
{
    public class HomeController : Controller
    {
       

      //Sadece Index Action'ınında Dependency Injection kullanımı 
        public IActionResult Index([FromServices] ILog log)
        {
            log.WriteLog();
            return View();
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
