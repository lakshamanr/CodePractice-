using DataModel.ModelClass;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
