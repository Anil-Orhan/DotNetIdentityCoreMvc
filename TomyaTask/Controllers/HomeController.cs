using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Web.Mvc;
using BusinessLayer.Abstract;
using TomyaTask.Models;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace TomyaTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICalculatorService _calculatorService;

        public HomeController(ILogger<HomeController> logger, ICalculatorService calculatorService)
        {
            _logger = logger;
            _calculatorService = calculatorService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Microsoft.AspNetCore.Authorization.Authorize]
        public IActionResult Calculator()
        {
            ViewData["sonuc"] = "0";
            return View();
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IActionResult Calculator(CalculatorModel cal,string hesapText)
        {
            try
            {
                if (cal.hesap == "=")
                {
                    cal.sonuc = _calculatorService.Calculation(cal.hesapText);
                    ViewData["sonuc"] = cal.sonuc;

                    return View();

                }
            }
            catch (Exception e)
            {

                TempData["alert"] = "Geçerli Bir Değer Girmediniz!";
                
            }

            return RedirectToAction("Error");




        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
