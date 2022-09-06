using Microsoft.AspNetCore.Mvc;
using WebApplicationTask1.Models;

namespace WebApplicationTask1.Controllers


{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Home home = new Home
            {
              Title ="Home ",
              Descrption ="Home Controlleri icindeki  description"
            };
            return View(home);
        }
    }
}
