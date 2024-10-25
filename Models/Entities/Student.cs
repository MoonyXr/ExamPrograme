using System;
using System.Collections.Generic;

namespace ExamPrograme.Models.Entities;

public partial class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int? ClassLevel { get; set; }

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();
}
