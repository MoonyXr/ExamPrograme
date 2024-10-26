using ExamPrograme.Models.Entities;
using ExamPrograme.Models.ViewModel;

namespace ExamPrograme.Services
{
    public class MapperService
    {
        public static StudentViewModel MapToViewModel(Student student)
        {
            return new StudentViewModel
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                ClassLevel = student.ClassLevel
            };
        }
        public static List<StudentViewModel> MapToViewModels(IEnumerable<Student> students)
        {
            return students.Select(student => MapToViewModel(student)).ToList();
        }
        public static LessonViewModel ToViewModel(Lesson lesson)
        {
            return new LessonViewModel
            {
                Code = lesson.Code.ToString(),
                Name = lesson.Name,
                ClassLevel = lesson.ClassLevel,
                TeacherFirstName = lesson.TeacherFirstName,
                TeacherLastName = lesson.TeacherLastName
            };
        }

        public static IEnumerable<LessonViewModel> ToViewModelList(IEnumerable<Lesson> lessons)
        {
            return lessons.Select(ToViewModel).ToList();
        }
        public static ExamViewModel ToViewModel(Exam exam)
        {
            return new ExamViewModel
            {
                Id = exam.Id,
                LessonCode = exam.LessonCode.ToString(), 
                StudentId = exam.StudentId,
                ExamDate = exam.ExamDate.ToDateTime(TimeOnly.MinValue), 
                Grade = exam.Grade
            };
        }

        public static List<ExamViewModel> ToViewModelList(IEnumerable<Exam> exams)
        {
            return exams.Select(e => ToViewModel(e)).ToList();
        }
        public static Exam ToEntity(ExamViewModel examViewModel)
        {
            return new Exam
            {
                Id = examViewModel.Id,
                LessonCode = short.Parse(examViewModel.LessonCode), 
                StudentId = examViewModel.StudentId,
                ExamDate = DateOnly.FromDateTime(examViewModel.ExamDate), 
                Grade = examViewModel.Grade
            };
        }

    }
}
