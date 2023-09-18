using Microsoft.AspNetCore.Mvc;
using WebApplication7.Services.Interfaces;
using WebApplication7.ViewModels.Faculties;

namespace WebApplication7.Controllers
{
    public class FacultyController : Controller
    {
        private readonly IFacultyService _facultyService;
        public FacultyController(IFacultyService facultyService)
        {
            _facultyService= facultyService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddEdit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEdit(FacultyAddEdit facultyAddEdit)
        {
          
            return View();
        }
    }
}
