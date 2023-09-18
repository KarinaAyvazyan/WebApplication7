using Microsoft.AspNetCore.Mvc;
using WebApplication7.Services.Interfaces;
using WebApplication7.ViewModels;
using WebApplication7.ViewModels.Students;

namespace WebApplication7.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IFacultyService _facultyService;

        public StudentController(IStudentService studentService, IFacultyService facultyService)
        {
            _studentService = studentService;
            _facultyService = facultyService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddEdit(int? id)
        {
            ViewBag.Faculty = _facultyService.GetListForDropdown();
            StudentEditViewModel model = id.HasValue ?
                _studentService.GetById(id.Value) :
                new StudentEditViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddEdit(StudentEditViewModel model)
        {
            if (model.Id > 0)
            {
                _studentService.Update(model);
            }
            else
            {
                _studentService.Add(model);
            }
            return View();
        }
    }
}
