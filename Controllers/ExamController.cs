using ExamPrograme.Models.Entities;
using ExamPrograme.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExamPrograme.Controllers
{
    public class ExamController : Controller
    {
        private readonly IEntityService<Exam> _examService;

        public ExamController(IEntityService<Exam> examService)
        {
            _examService = examService;
        }

        public async Task<IActionResult> Index()
        {
            var exams = await _examService.GetAllEntitiesAsync();
            return View(exams);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Exam exam)
        {
            if (ModelState.IsValid)
            {
                await _examService.AddEntityAsync(exam);
                return RedirectToAction(nameof(Index)); 
            }
            return View(exam);
        }
    }
}
