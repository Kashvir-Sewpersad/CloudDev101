using CloudDevelopment.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloudDevelopment.Controllers
{
    public class LoginController : Controller
    {

        private readonly LoginModel _login;

        public LoginController()
        {
            
            _login = new LoginModel();

        }




        [HttpPost]
        public ActionResult Privacy(string email, string name)
        {
            var loginModel = new LoginModel();


            var userID = LoginModel.SelectUser(email, name);


            if (userID != -1)
            {

                //return RedirectToAction("Index", "Home", new { userID = userID });
                return RedirectToAction("Products", "Home", new { userID = userID });
            }


           
                
                return View("Index");
            
        }
    }
}