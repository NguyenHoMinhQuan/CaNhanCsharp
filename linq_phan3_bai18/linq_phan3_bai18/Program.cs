//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
using System;
using System.Collections.Generic;
using System.Linq;
namespace linq_phan2_bai18
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
                new Student{Id=4, Name="Dung", Score=7},
                new Student{Id=5, Name=" Minh Quan", Score=4}
            };

            var groups = students.GroupBy(s => {
                if (s.Score >= 8) return "Gioi";
                if (s.Score >= 6) return "Kha";
                return "Trung binh";
            });

            foreach (var group in groups)
            {
                Console.WriteLine("\nNhom xep loai: {0}", group.Key);
                foreach (var s in group)
                {
                    Console.WriteLine("- {0} ({1} diem)", s.Name, s.Score);
                }
            }
            Console.ReadKey();
        }
    }
}