using System;
using System.Collections.Generic;

namespace ExamPrograme.Models.Entities;

public partial class Exam
{
    public int Id { get; set; }

    public short LessonCode { get; set; }

    public int StudentId { get; set; }

    public DateOnly ExamDate { get; set; }

    public int? Grade { get; set; }

    public virtual Lesson LessonCodeNavigation { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
