//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_phan2_bai20
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{Id=1, Name="An", Score=8},
                new Student{Id=2, Name="Binh", Score=6},
                new Student{Id=3, Name="Chi", Score=9.5},
                new Student{Id=4, Name="Dung", Score=7},
                new Student{Id=5, Name="Minh Quan", Score=8.5},
                new Student{Id=6, Name="Thuy Trang", Score=9}
            };

            var top3Students = students.OrderByDescending(s => s.Score)
                                       .Take(3);

            Console.WriteLine("Top 3 sinh vien co diem cao nhat:");
            int rank = 1;
            foreach (var s in top3Students)
            {
                Console.WriteLine("{0}. {1} - {2} diem", rank++, s.Name, s.Score);
            }

            Console.ReadKey();
        }
    }
}