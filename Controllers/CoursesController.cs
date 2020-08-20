using Microsoft.AspNetCore.Mvc;
using MyCourse.Models.Services.Application;
using MyCourse.Models.ViewModels;
using System.Collections.Generic;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index(){
            var courseService = new CourseService();
            List<CourseViewModel> courses = courseService.GetServices();
            return   View(courses);        
        }

        public IActionResult Detail(int id){
            return   View();        
        }
    }
}