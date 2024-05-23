using Microsoft.AspNetCore.Mvc;
using CloudDevelopment.Models;

namespace CloudDevelopment.Controllers;

public class UserController : Controller
{
    public UserTable usrtbl = new UserTable();



    [HttpPost]
    public ActionResult Privacy(UserTable Users)
    {
        var result = usrtbl.insert_User(Users);
        return RedirectToAction("Privacya", "Home");
    }

    [HttpGet]
    public ActionResult Privacy()
    {
        return View(usrtbl);
    }


}