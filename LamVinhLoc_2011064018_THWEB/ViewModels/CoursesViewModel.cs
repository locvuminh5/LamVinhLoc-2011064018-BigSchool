using LamVinhLoc_2011064018_THWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LamVinhLoc_2011064018_THWEB.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}