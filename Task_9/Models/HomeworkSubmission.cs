using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace P01_StudentSystem.Models
{
    public enum ContentType
    {
        Application,
        pdf,
        zip
    }
    internal class HomeworkSubmission
    {
        [Key]
        public int HomeworkId { get; set; }
        public string Content { get; set; }
        public ContentType ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
