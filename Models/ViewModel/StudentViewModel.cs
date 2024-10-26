using ExamPrograme.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace ExamPrograme.Models.ViewModel
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        [Required(ErrorMessage = "Ad daxil edilməlidir")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad daxil edilməlidir")]
        public string LastName { get; set; }

        [Range(1, 11, ErrorMessage = "Sinif 1 ilə 11 arasında olmalıdır")]
        public int? ClassLevel { get; set; }

      
    }

}
