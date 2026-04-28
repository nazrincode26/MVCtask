using Microsoft.AspNetCore.Mvc;
using MVC_2.Models;
using MVCtask.Models;

namespace MVC_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product >
{
                new Product { Id = 1, Name = "Macallan 18 Year Old Sherry Oak", Price = 399.99m, ImageUrl = " kind-1.jpg ", Category = "Whiskey" },
                new Product { Id = 2, Name = "Johnnie Walker Blue Label", Price = 249.99m, ImageUrl = " kind-2.jpg  ", Category = "Whiskey" },
                new Product { Id = 3, Name = "Grey Goose VX Vodka", Price = 89.99m, ImageUrl = " kind-6.jpg  ", Category = "Vodka" },
                new Product { Id = 4, Name = "Beluga Gold Line Vodka", Price = 129.99m, ImageUrl = " kind-4.jpg ", Category = "Vodka" },
                new Product { Id = 5, Name = "Zacapa XO Rum", Price = 119.99m, ImageUrl = " kind-3.jpg ", Category = "Rum" },
                new Product { Id = 6, Name = "Diplomatico Ambassador Rum", Price = 289.99m, ImageUrl = " kind-5.jpgv ", Category = "Rum" },
    
};
          

            List<Slider> sliders = new List<Slider>
            {
                new Slider
                {
                    Id = 1,
                    Title = "Leave the page",
                    Discount = 5,
                    Desc = "Don’t drink",
                    ImageUrl = "bg_2.jpg"
                },

            };

            Home_VM vM = new Home_VM()
            {
                Products = products,
                Sliders = sliders
            };
            return View(vM);

        }
    }
}