using System.ComponentModel.DataAnnotations;
namespace BaiTapMVC.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required]
        public string CourseName { get; set; }

        public ICollection<CourseClass> CourseClasses { get; set; }
    }
}