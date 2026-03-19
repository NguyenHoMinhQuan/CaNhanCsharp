
//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_phan2_bai17
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
                new Student{Id=3, Name="Chi", Score=9},
                new Student{Id=4, Name="Dung", Score=7}
            };

            double averageScore = students.Average(s => s.Score);

            Console.WriteLine("Diem trung binh cua tat ca sinh vien la: {0}", averageScore);

            Console.WriteLine("------------------------------------------");
            Console.ReadKey();
        }
    }
}