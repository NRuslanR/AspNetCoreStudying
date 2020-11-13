using System;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreFromScratch
{
    public class ProductsController : Controller
    {
        // GET
        public IActionResult List()
        {
            return Content(
                string.Join(Environment.NewLine,
                    new string[]
                    {
                        "Product1",
                        "Product2",
                        "Product3"
                    }
                )
            );
        }
        
        public IActionResult GetProduct(int productId)
        {
            if (!ModelState.IsValid)
                return Content("productId is not valid");
            
            return Content("View for product with id: " + productId);
        }
    }
}