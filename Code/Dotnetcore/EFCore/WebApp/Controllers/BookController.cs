using DataAccess.Data;
using DataModel.ModelClass;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace WebApp.Controllers
{
    public class BookController : Controller
    {
        readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Book> listBook=_db.Books.ToList();

            return View(listBook);
        }
    }
}
