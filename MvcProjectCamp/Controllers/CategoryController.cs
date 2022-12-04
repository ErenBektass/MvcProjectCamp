using MvcProjectCamp.VMClasses;
using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class CategoryController : Controller
    {
        
        CategoryRepository _cRep;

        public CategoryController()
        {
            _cRep=new CategoryRepository();
        }

        public ActionResult Index() 
        {
            return View();
        }
        // GET: Category
        public ActionResult GetCategoryList()
        {
            CategoryVM cvm = new CategoryVM
            {
                Categories = _cRep.GetActives()
            };
            return View(cvm);

        }
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            return View();
        }
        
    }
    
}
