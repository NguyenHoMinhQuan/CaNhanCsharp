//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_phan2_bai8
{
    class Student { public int Id; public string Name; public double Score; }
    class Program
    {
        static void Main()
        {
            List<Student> students = GetList();
            var result = students.Where(s => s.Score >= 8);
            foreach (var s in result) Console.WriteLine(s.Name + " - " + s.Score);
            Console.ReadKey();
        }
        static List<Student> GetList() => new List<Student> {
            new Student{Id=1, Name="An", Score=8}, new Student{Id=2, Name="Binh", Score=6},
            new Student{Id=3, Name="Chi", Score=9}, new Student{Id=4, Name="Dung", Score=7}
        };
    }
}