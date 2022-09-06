

using Microsoft.AspNetCore.Mvc;
using WebApplicationTask1.Models;

namespace WebApplicationTask1.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {  Contact contact =new Contact
        {
            Title ="Contact",
            Descrption ="Contact controlleri icindeki descrption"
        };
            return View(contact );
        }
    }
}
