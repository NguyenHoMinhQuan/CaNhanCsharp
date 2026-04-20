using System.ComponentModel.DataAnnotations;
namespace BaiTapMVC.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<CourseClass> CourseClasses { get; set; }
    }
}