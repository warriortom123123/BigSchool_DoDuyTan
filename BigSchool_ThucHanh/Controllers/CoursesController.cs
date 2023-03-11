using BigSchool_ThucHanh.Models;
using BigSchool_ThucHanh.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool_ThucHanh.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList(),
            };
            return View(viewModel);
        }
    }
}