// Nguyễn Hồ Minh Quân - 134
// Tạo List chứa tên sinh viên,xóa tên do người dùng nhập vào
using System;
using System.Collections.Generic;

namespace Phan1_Bai5
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> students = new List<string>();
            students.Add("Nguyen Van A");
            students.Add("Le Thi B");
            students.Add("Tran Van C");
            students.Add("Pham Thi D");
            students.Add("Hoang Van E");

            Console.WriteLine("Danh sach sinh vien:");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nNhap ten sinh vien can xoa:");
            string nameToRemove = Console.ReadLine();

            if (students.Remove(nameToRemove))
            {
                Console.WriteLine("Da xoa sinh vien: {0}", nameToRemove);
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien: {0}", nameToRemove);
            }

            Console.WriteLine("\nDanh sach sinh vien sau khi xoa:");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}