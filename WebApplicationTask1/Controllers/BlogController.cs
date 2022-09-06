using Microsoft.AspNetCore.Mvc;
using WebApplicationTask1.Models;

namespace WebApplicationTask1.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            Blog blog = new Blog
            {
                Title ="Blog",
                Descrption ="Blog controlleri icindeki descrption"

            };
            return View(blog);
        }
    }
}
