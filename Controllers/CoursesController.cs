using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index(){
            return   Content("Sono Index");        
        }

        public IActionResult Detail(int id){
            return   Content($"Sono il dettaglio Index {id}");        
        }
    }
}