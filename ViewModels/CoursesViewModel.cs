using PhoDucHuy_2011060374_Bai3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoDucHuy_2011060374_Bai3.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}