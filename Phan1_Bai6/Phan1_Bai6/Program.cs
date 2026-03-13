// Nguyễn Hồ Minh Quân - 134
//kiểm tra một chuỗi có tồn tại trong danh sách hay không
using System;
using System.Collections.Generic;
namespace Phan1_Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> danhSach = new List<string> { "apple", "banana", "cherry" };
            while (true)
            {
                Console.WriteLine("\nNhap chuoi can kiem tra (hoac nhap 'exit' de dung):");
                string chuoiCanKiemTra = Console.ReadLine();

                if (chuoiCanKiemTra.ToLower() == "exit")
                {
                    break;
                }

                if (danhSach.Contains(chuoiCanKiemTra))
                {
                    Console.WriteLine("Chuoi '{0}' ton tai trong danh sach.", chuoiCanKiemTra);
                }
                else
                {
                    Console.WriteLine("Chuoi '{0}' khong ton tai trong danh sach.", chuoiCanKiemTra);
                }

                Console.WriteLine("------------------------------------------");
            }

            Console.WriteLine("Chuong trinh ket thuc.");
            Console.ReadKey();
        }
    }
}