//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
using System;
using System.Collections.Generic;

namespace Phan2_Bai13
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

            List<Student> studentList = new List<Student>
            {
                new Student { Id = 1, Name = "Nguyen Van A" },
                new Student { Id = 2, Name = "Le Thi B" }
            };

            while (true)
            {
                Console.WriteLine("\nDanh sach hien tai:");
                foreach (var s in studentList) Console.WriteLine("ID: {0} | Ten: {1}", s.Id, s.Name);

                Console.Write("\nNhap ID can xoa (nhap 'done' de thoat): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "done") break;

                if (int.TryParse(input, out int idTarget))
                {
                    int indexToRemove = -1;
                    for (int i = 0; i < studentList.Count; i++)
                    {
                        if (studentList[i].Id == idTarget)
                        {
                            indexToRemove = i;
                            break;
                        }
                    }

                    if (indexToRemove != -1)
                    {
                        studentList.RemoveAt(indexToRemove);
                        Console.WriteLine("=> Da xoa thanh cong sinh vien ID: {0}", idTarget);
                    }
                    else
                    {
                        Console.WriteLine("=> Khong tim thay ID: {0} trong danh sach!", idTarget);
                    }
                }
                else
                {
                    Console.WriteLine("=> Vui long nhap ID la mot so nguyen!");
                }
            }
        }
    }
}