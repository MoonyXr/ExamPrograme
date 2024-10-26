namespace ExamPrograme.Models.ViewModel
{
    public class ExamViewModel
    {
        public int Id { get; set; }

        public string LessonCode { get; set; } = string.Empty; 

        public int StudentId { get; set; } 

        public DateTime ExamDate { get; set; } 

        public int? Grade { get; set; } 
    }
}
