
//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
// kiểm tra sinh viên rớt score < 5.0
using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_phan2_bai14
{
    class Student { public int Id; public string Name; public double Score; }
    class Program
    {
        static void Main()
        {
            List<Student> students = GetList();
            bool check = students.Any(s => s.Score < 5);
            Console.WriteLine("Co sv rot ko: " + (check ? "Co" : "Khong"));
            Console.ReadKey();
        }
        static List<Student> GetList() => new List<Student> {
            new Student{Id=1, Name="An", Score=8}, new Student{Id=2, Name="Binh", Score=6},
            new Student{Id=3, Name="Chi", Score=9}, new Student{Id=4, Name="Dung", Score=7}
        };
    }
}