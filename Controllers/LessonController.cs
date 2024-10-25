using ExamPrograme.Models.Entities;
using ExamPrograme.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExamPrograme.Controllers
{
    public class LessonController : Controller
    {
        private readonly IEntityService<Lesson> _lessonService;

        public LessonController(IEntityService<Lesson> lessonService)
        {
            _lessonService = lessonService;
        }

        public async Task<IActionResult> Index()
        {
            var lessons = await _lessonService.GetAllEntitiesAsync();
            return View(lessons);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Lesson lesson)
        {
            if (ModelState.IsValid)
            {
                await _lessonService.AddEntityAsync(lesson);
                return RedirectToAction(nameof(Index)); 
            }
            return View(lesson);
        }
    }
}
