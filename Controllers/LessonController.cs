using ExamPrograme.Models.Entities;
using ExamPrograme.Models.ViewModel;
using ExamPrograme.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var lessonViewModels = MapperService.ToViewModelList(lessons);
            return View(lessonViewModels);
        }

        public IActionResult AddLesson()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddLesson(Lesson lesson)
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
