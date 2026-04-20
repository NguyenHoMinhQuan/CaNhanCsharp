namespace BaiTapMVC.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseClassId { get; set; }
        public CourseClass CourseClass { get; set; }
    }
}
