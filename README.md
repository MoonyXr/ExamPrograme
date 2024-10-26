# Layihə Adı  
Bu layihə, tələbələrin dərs və imtahan nəticələrini idarə etmək məqsədilə hazırlanmışdır.

## İstifadə Edilən Texnologiyalar  
- Verilənlər bazası: MS SQL Server  
- Backend: .NET 8 Web APP 
- ORM: Entity Framework Core  (DB first yanaşması tətbiq edilmişdir)
- HTML, CSS, Boostrap

## SQL Sorğuları  
### Lessons Cədvəli
CREATE TABLE Lessons (
    Code smallint IDENTITY(1,1)  PRIMARY KEY,  
    Name VARCHAR(30) NOT NULL,  
    ClassLevel INT CHECK (ClassLevel BETWEEN 1 AND 11), 
    TeacherFirstName VARCHAR(20) NOT NULL,  
    TeacherLastName VARCHAR(20) NOT NULL  
);

### Student Cədvəli

CREATE TABLE Students (
    Id INT IDENTITY(1,1)  PRIMARY KEY, 
    FirstName VARCHAR(30) NOT NULL,  
    LastName VARCHAR(30) NOT NULL,  
    ClassLevel INT CHECK (ClassLevel BETWEEN 1 AND 11)  
);

### Exam Cədvəli
CREATE TABLE Exams (
    Id INT IDENTITY(1,1) PRIMARY KEY,  
    LessonCode smallint NOT NULL,  
    StudentId INT NOT NULL,  
    ExamDate DATE NOT NULL,  
    Grade INT CHECK (Grade BETWEEN 0 AND 5),  
    
    CONSTRAINT FK_Exam_Lesson FOREIGN KEY (LessonCode) REFERENCES Lessons(Code),
    CONSTRAINT FK_Exam_Student FOREIGN KEY (StudentId) REFERENCES Students(Id)
);