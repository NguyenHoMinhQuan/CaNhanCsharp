//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
using System;
using System.Collections.Generic;
namespace Phan2_Bai18
{
    class Student
    {
        public string Name;
        public double Score;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();

            while (true)
            {
                Console.WriteLine("\nNhap thong tin (nhap 'done' o ten de tim nguoi diem cao nhat):");

                Student sv = new Student();
                Console.Write("Ten sinh vien: ");
                sv.Name = Console.ReadLine();

                if (sv.Name.ToLower() == "done") break;

                Console.Write("Diem: ");
                if (double.TryParse(Console.ReadLine(), out sv.Score))
                {
                    studentList.Add(sv);
                }
                else
                {
                    Console.WriteLine("Diem khong hop le, vui long nhap lai!");
                }
            }
            if (studentList.Count > 0)
            {
                Student maxStudent = studentList[0];

                foreach (Student s in studentList)
                {
                    if (s.Score > maxStudent.Score)
                    {
                        maxStudent = s;
                    }
                }
                Console.WriteLine("\n--- SINH VIEN CO DIEM CAO NHAT ---");
                Console.WriteLine("Ten: {0}", maxStudent.Name);
                Console.WriteLine("Diem: {0}", maxStudent.Score);
            }
            else
            {
                Console.WriteLine("Danh sach trong.");
            }
            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}