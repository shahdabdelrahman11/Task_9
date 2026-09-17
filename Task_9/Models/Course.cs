using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentSystem.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public ICollection<StudentCourse> Courses { get; set; }
        public ICollection<Resource> Resources { get; set; }
        public ICollection<HomeworkSubmission> HomeworkSubmissions { get; set; }
    }
}
