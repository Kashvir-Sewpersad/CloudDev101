
//********************************* start of file ****************************//

using CloudDev101.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CloudDev101.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// *Kashvir Sewpersad
        /// st10257503
        /// Kashclk31@gmail.com
        /// </summary>
        /// <returns></returns>


        //******************* start of about method *************************//

        /*
         This method titled About will add the about "page / tab " to the website
        
         */
        public IActionResult About()
        {
            return View(); // This will make it visable on the webpage 
        }
         //************************** end of about method **********************//
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult OurProducts()
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
//************************************ end of file ***************************//