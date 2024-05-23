using CloudDevelopment.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloudDevelopment.Controllers;

public class ProductController : Controller
{
    public ProductTable prodtbl = new ProductTable();


    [HttpPost]
    public ActionResult InsertProducts(ProductTable products)
    {
        var result2 = prodtbl.insert_product(products);
        return RedirectToAction("Products", "Home");
    }

    [HttpGet]
    public ActionResult InsertProducts()
    {
        //return View(_productTable);
        return View();
    }
}