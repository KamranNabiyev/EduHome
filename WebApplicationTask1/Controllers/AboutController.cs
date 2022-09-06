
using Microsoft.AspNetCore.Mvc;
using WebApplicationTask1.Models;

namespace WebApplicationTask1.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            About about = new About
            {
                Title ="About ",
                Description ="About controlleri icindeki description"
            };
            return View(about);
        }
    }
}
