using Microsoft.AspNetCore.Mvc;
using LeaveManagementSystem.Web.Models;

namespace LeaveManagementSystem.Web.Controllers
{
    public class ProductController : Controller
    {
        
        public IActionResult Index()
        {
            //bind data to the view

            var data = new Product
            {
                Name = "Fruits Cake",
                Quantity = 10

            };

            return View(data);
        }
    }
}
