using System;
using System.Collections.Generic;

namespace ExamPrograme.Models.Entities;

public partial class Lesson
{
    public short Code { get; set; }

    public string Name { get; set; } = null!;

    public int? ClassLevel { get; set; }

    public string TeacherFirstName { get; set; } = null!;

    public string TeacherLastName { get; set; } = null!;

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();
}
