namespace ExamPrograme.Models.ViewModel
{
    public class LessonViewModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int? ClassLevel { get; set; }
        public string TeacherFullName => $"{TeacherFirstName} {TeacherLastName}";
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
    }
}
