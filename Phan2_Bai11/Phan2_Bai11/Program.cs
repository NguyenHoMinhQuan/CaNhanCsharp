//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
using System;
using System.Collections.Generic;

namespace Phan2_Bai11
{
    class Student
    {
        public int Id;
        public string Name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            while (true)
            {
                Console.WriteLine("\nNhap thong tin sinh vien (hoac nhap 'done' o phan ten de dung):");
                Student sv = new Student();
                Console.Write("Nhap Id: ");
                string idInput = Console.ReadLine();
                if (!int.TryParse(idInput, out sv.Id))
                {
                    Console.WriteLine("Id khong hop le, vui long nhap lai.");
                    continue;
                }
                Console.Write("Nhap Ten: ");
                sv.Name = Console.ReadLine();

                if (sv.Name.ToLower() == "done")
                {
                    break;
                }
                studentList.Add(sv);
                Console.WriteLine("Da them sinh vien thanh cong.");
            }
            if (studentList.Count > 0)
            {
                Console.WriteLine("\n--- DANH SACH SINH VIEN DA LUU ---");
                foreach (Student s in studentList)
                {
                    Console.WriteLine("ID: {0} | Ten: {1}", s.Id, s.Name);
                }
            }
            else
            {
                Console.WriteLine("Danh sach trong.");
            }
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("Nhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}
