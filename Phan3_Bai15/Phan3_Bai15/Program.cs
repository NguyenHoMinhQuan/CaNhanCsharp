//Nguyễn Hồ Minh Quân_23115053122134_225LTC#02
using System;
using System.Collections.Generic;

namespace Phan2_Bai14_Updated
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> tuDien = new Dictionary<string, string>();

            tuDien.Add("hello", "xin chao");
            tuDien.Add("world", "the gioi");
            tuDien.Add("apple", "qua tao");
            tuDien.Add("computer", "may tinh");
            tuDien.Add("student", "sinh vien");

            while (true)
            {
                Console.WriteLine("\nNhap tu tieng Anh (hoac nhap '0' de dung):");
                string tuKhoa = Console.ReadLine();

                if (tuKhoa == "0")
                {
                    Console.WriteLine("Dang thoat...");
                    break;
                }

                tuKhoa = tuKhoa.ToLower();

                if (tuDien.ContainsKey(tuKhoa))
                {
                    Console.WriteLine("=> Nghia cua '{0}' la: {1}", tuKhoa, tuDien[tuKhoa]);
                }
                else
                {
                    Console.WriteLine("=> Tu '{0}' chua co trong tu dien!", tuKhoa);
                }

                Console.WriteLine("------------------------------------------");
            }

            Console.ReadKey();
        }
    }
}