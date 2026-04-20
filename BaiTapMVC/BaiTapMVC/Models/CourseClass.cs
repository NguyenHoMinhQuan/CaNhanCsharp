namespace BaiTapMVC.Models
{
    public class CourseClass
    {
        public int CourseClassId { get; set; }

        public int CourseId { get; set; }
        public int TeacherId { get; set; }

        public Course? Course { get; set; }
        public Teacher? Teacher { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
