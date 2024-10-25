using ExamPrograme.Models.Entities;
using ExamPrograme.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExamPrograme.Controllers
{
    public class StudentController : Controller
    {
        private readonly IEntityService<Student> _studentService;

        public StudentController(IEntityService<Student> studentService)
        {
            _studentService = studentService;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _studentService.GetAllEntitiesAsync();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                await _studentService.AddEntityAsync(student);
                return RedirectToAction(nameof(Index)); // Index metoduna yönləndirin
            }
            return View(student);
        }
    }
}
