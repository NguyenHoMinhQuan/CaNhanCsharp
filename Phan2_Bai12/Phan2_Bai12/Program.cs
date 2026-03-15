//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
using System;
using System.Collections.Generic;

namespace Phan2_Bai12
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
            studentList.Add(new Student { Id = 1, Name = "Nguyen Van A" });
            studentList.Add(new Student { Id = 2, Name = "Le Thi B" });
            studentList.Add(new Student { Id = 3, Name = "Tran Van C" });

            Console.WriteLine("Danh sach hien co:");
            foreach (var s in studentList)
            {
                Console.WriteLine("ID: {0} | Ten: {1}", s.Id, s.Name);
            }
            while (true)
            {
                Console.WriteLine("\nNhap ten sinh vien can tim (hoac nhap 'exit' de thoat):");
                string searchName = Console.ReadLine();

                if (searchName.ToLower() == "exit") break;

                bool found = false;
                foreach (Student s in studentList)
                {
                    if (s.Name.ToLower().Contains(searchName.ToLower()))
                    {
                        Console.WriteLine("=> Tim thay: ID: {0} | Ten: {1}", s.Id, s.Name);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("=> Khong tim thay sinh vien nao co ten: {0}", searchName);
                }
                Console.WriteLine("------------------------------------------");
            }
            Console.WriteLine("Chuong trinh ket thuc.");
            Console.ReadKey();
        }
    }
}