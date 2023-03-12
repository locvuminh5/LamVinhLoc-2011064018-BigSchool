using LamVinhLoc_2011064018_THWEB.Models;
using LamVinhLoc_2011064018_THWEB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LamVinhLoc_2011064018_THWEB.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses

        private readonly ApplicationDbContext _dbContext;

        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        public ActionResult Create()
        {
            var viewModel = new CourseViewModel()
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}