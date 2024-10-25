namespace ExamPrograme.Models.ViewModel
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ClassLevel { get; set; }
    }
}
