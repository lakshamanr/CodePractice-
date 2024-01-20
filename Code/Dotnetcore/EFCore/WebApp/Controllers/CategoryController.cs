using DataAccess.Data;
using DataModel.ModelClass;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class CategoryController : Controller
    {
        readonly  ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> lstCategories = new List<Category>();
            lstCategories= _db.Categories.ToList();
            return View(lstCategories);
        }
        [HttpGet]
        public IActionResult Upsert(int? id)
        {
            Category? lCategory = new Category();

            if (id == null || id == 0)
            {
                return View(lCategory);
            }
            lCategory = _db.Categories.FirstOrDefault(x=>x.CategoryId==id);
            if(lCategory!=null)
            {
               return View(lCategory);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Upsert(Category aobjCategory)
        { 
            if(ModelState.IsValid)
            {
                if(aobjCategory.CategoryId==0)
                {
                    //Create
                    _db.Categories.Add(aobjCategory);
               ;
                }
                else
                {
                    // Update

                    _db.Categories.Update(aobjCategory);
                   
                }
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(aobjCategory);
        }

        [HttpGet]
        public IActionResult Delete(int ? id)
        { 
            Category? lCategory = new Category(); 
            if (id == null || id == 0)
            {
                return View(lCategory);
            }
            lCategory = _db.Categories.FirstOrDefault(x => x.CategoryId == id); 
            return View(lCategory);
        }

        [HttpPost]
        public IActionResult Delete(Category aobjCategory)
        {
            if (ModelState.IsValid)
            {
                if (aobjCategory.CategoryId != 0)
                {
                    _db.Categories.Remove(aobjCategory);
                    _db.SaveChanges();
                } 
               
                return RedirectToAction(nameof(Index));
            }
            return View(aobjCategory); 
        }
    }
}
