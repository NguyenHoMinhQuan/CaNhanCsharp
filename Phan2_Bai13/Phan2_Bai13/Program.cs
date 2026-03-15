//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
//Đếm tổng số sinh viên trong List<Student>.
using System;
using System.Collections.Generic;
namespace Phan2_Bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", Age = 20 },
                new Student { Name = "Bob", Age = 22 },
                new Student { Name = "Charlie", Age = 21 },
                new Student { Name = "Minh Quan", Age = 21 },
            };
            int totalStudents = students.Count;
            Console.WriteLine($"Tong so sinh vien: {totalStudents}");
        }
    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
