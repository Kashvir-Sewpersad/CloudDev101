
//********************************* start of file ****************************//

using CloudDev101.Models;
using CloudDevelopment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Transactions;

namespace CloudDev101.Controllers
{

    /// <summary>
    /// *Kashvir Sewpersad
    /// st10257503
    /// Kashclk31@gmail.com
    /// </summary>
    /// <returns></returns>






    public class HomeController(ILogger<HomeController> logger) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;

        public IActionResult Products(int userId)
        {
            var products = ProductTable.GetAllProducts();

            ViewData["Products"] = products;
            ViewData["UserID"] = userId;

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult Orders()
        {
            var orders = Transactions.GetAllOrders();

            ViewData["Orders"] = orders;
            return View();
        }


        /*
         
         public class HomeController : Controller

        {

            private readonly ILogger<HomeController> _logger;

            public HomeController(ILogger<HomeController> logger)
            {
                _logger = logger;
            }


        */


        /*
        public IActionResult SignUp()
        {
            return View();
        }*/



        public IActionResult Index()
        {
            return View();
        }



        public IActionResult About()
        {
            return View(); // This will make it visable on the webpage 
        }


         
        public IActionResult Privacy()
        {
            return View();
        }



        public IActionResult ContactUs()
        {
            return View();
        }


        /*
         
         ourProducts is the "MyWork" page
         */

        public IActionResult OurProducts()
        {
            return View();
        }



        public IActionResult Privacya()
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