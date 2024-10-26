using ExamPrograme.Models.Entities;
using ExamPrograme.Models.ViewModel;
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
            var examViewModels = MapperService.ToViewModelList(exams); 
            return View(examViewModels);
        }

        public IActionResult AddExam()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddExam(ExamViewModel examViewModel)
        {
            if (ModelState.IsValid)
            {
                var entityExam = MapperService.ToEntity(examViewModel);
                await _examService.AddEntityAsync(entityExam);
                return RedirectToAction(nameof(Index));
            }
            return View(examViewModel);
        }
    }
}
